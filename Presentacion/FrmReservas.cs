using Logica;
using Logica.Modelos;
using System.Globalization;

namespace Presentacion;

public partial class FrmReservas : Form
{
    private readonly ControlReservas control = new();
    private int? codigoActual;
    private readonly CultureInfo cultura = CultureInfo.GetCultureInfo("es-CR");

    public FrmReservas()
    {
        InitializeComponent();
        cmbTipo.Items.AddRange(["Individual", "Corporativa"]);
        cmbSala.Items.AddRange(["Sala de podcast", "Sala de video y streaming"]);
        (string titulo, int minimo, int peso)[] columnas =
        [
            ("Código", 52, 55), ("Cliente", 62, 105), ("Tipo", 82, 100),
            ("Sala", 62, 98), ("Inicio", 84, 100), ("Horas", 42, 45),
            ("Total", 70, 75), ("Correo", 78, 145), ("Registro", 80, 125)
        ];
        foreach (var (titulo, minimo, peso) in columnas)
        {
            tabla.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = titulo,
                MinimumWidth = minimo,
                Width = minimo,
                AutoSizeMode = titulo is "Código" or "Tipo" or "Horas" or "Total"
                    ? DataGridViewAutoSizeColumnMode.None : DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = peso,
                SortMode = DataGridViewColumnSortMode.NotSortable
            });
        }

        cmbTipo.SelectedIndexChanged += (_, _) => Cotizar();
        cmbSala.SelectedIndexChanged += (_, _) => Cotizar();
        horas.ValueChanged += (_, _) => Cotizar();
        buscar.TextChanged += (_, _) => MostrarReservas();
        guardar.Click += (_, _) => Guardar();
        nuevo.Click += (_, _) => Limpiar();
        editar.Click += (_, _) => Editar();
        eliminar.Click += (_, _) => Eliminar();
        tabla.CellDoubleClick += (_, e) => { if (e.RowIndex >= 0) Editar(); };
        Limpiar();
        MostrarReservas();
    }

    private string Colones(decimal valor) => "₡" + valor.ToString("N0", cultura);
    private DatosReserva Leer() => new(txtNombre.Text, txtCorreo.Text, (TipoReserva)cmbTipo.SelectedIndex,
        (TipoSala)cmbSala.SelectedIndex, fecha.Value, (int)horas.Value);

    private void Cotizar()
    {
        if (cmbSala.SelectedIndex < 0 || cmbTipo.SelectedIndex < 0) return;
        var r = control.Cotizar(Leer());
        detalle.Text = $"Subtotal {Colones(r.Subtotal)}   ·   Descuento {Colones(r.Descuento)}";
        importe.Text = $"Total  {Colones(r.Total)}";
    }

    private void Limpiar()
    {
        codigoActual = null;
        edicion.Text = "Nueva reserva";
        guardar.Text = "Registrar";
        errores.Clear();
        txtNombre.Clear();
        txtCorreo.Clear();
        cmbTipo.SelectedIndex = cmbSala.SelectedIndex = 0;
        fecha.Value = DateTime.Today.AddDays(1).AddHours(9);
        horas.Value = 1;
        Cotizar();
        txtNombre.Focus();
    }

    private void Guardar()
    {
        var datos = Leer();
        var campos = new Dictionary<string, Control>
        {
            [nameof(datos.Nombre)] = txtNombre, [nameof(datos.Correo)] = txtCorreo,
            [nameof(datos.Tipo)] = cmbTipo, [nameof(datos.Sala)] = cmbSala,
            [nameof(datos.Fecha)] = fecha, [nameof(datos.Horas)] = horas
        };
        errores.Clear();
        var pendientes = control.Validar(datos);
        foreach (var error in pendientes) errores.SetError(campos[error.Key], error.Value);
        if (pendientes.Count > 0) { campos[pendientes.First().Key].Focus(); return; }

        try
        {
            if (codigoActual.HasValue) control.Modificar(codigoActual.Value, datos);
            else control.Registrar(datos);
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(this, ex.Message, "Revisa los datos");
            return;
        }
        buscar.Clear();
        MostrarReservas();
        Limpiar();
    }

    private void MostrarReservas()
    {
        tabla.Rows.Clear();
        foreach (var r in control.BuscarPorNombre(buscar.Text))
        {
            int fila = tabla.Rows.Add(r.Codigo, r.NombreCliente, r.Tipo,
                r.Sala == TipoSala.Podcast ? "Podcast" : "Video y streaming",
                r.FechaReserva.ToString("dd/MM/yyyy HH:mm"), r.Horas, Colones(r.Total),
                r.CorreoCliente, r.FechaRegistro.ToString("dd/MM/yyyy HH:mm"));
            tabla.Rows[fila].Tag = r;
        }
        var (cantidad, monto) = control.Resumen();
        resumen.Text = $"Reservas: {cantidad}     ·     Total acumulado: {Colones(monto)}";
        editar.Enabled = eliminar.Enabled = tabla.Rows.Count > 0;
    }

    private void Editar()
    {
        if (tabla.CurrentRow?.Tag is not Reserva r) return;
        errores.Clear();
        codigoActual = r.Codigo;
        edicion.Text = $"Editar reserva #{r.Codigo}";
        guardar.Text = "Guardar cambios";
        txtNombre.Text = r.NombreCliente;
        txtCorreo.Text = r.CorreoCliente;
        fecha.Value = r.FechaReserva;
        cmbTipo.SelectedIndex = (int)r.Tipo;
        cmbSala.SelectedIndex = (int)r.Sala;
        horas.Value = r.Horas;
        Cotizar();
    }

    private void Eliminar()
    {
        if (tabla.CurrentRow?.Tag is not Reserva r) return;
        var respuesta = MessageBox.Show(this, $"¿Eliminar la reserva #{r.Codigo} de {r.NombreCliente}?",
            "Eliminar reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        if (respuesta != DialogResult.Yes) return;
        control.Eliminar(r.Codigo);
        if (codigoActual == r.Codigo) Limpiar();
        MostrarReservas();
    }
}
