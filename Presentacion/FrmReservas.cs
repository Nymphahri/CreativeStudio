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
            dgvTabla.Columns.Add(new DataGridViewTextBoxColumn
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
        nudHoras.ValueChanged += (_, _) => Cotizar();
        txtBuscar.TextChanged += (_, _) => MostrarReservas();
        btnGuardar.Click += (_, _) => Guardar();
        btnNuevo.Click += (_, _) => Limpiar();
        btnEditar.Click += (_, _) => Editar();
        btnEliminar.Click += (_, _) => Eliminar();
        dgvTabla.CellDoubleClick += (_, e) => { if (e.RowIndex >= 0) Editar(); };
        Limpiar();
        MostrarReservas();
    }

    private string Colones(decimal valor) => "₡" + valor.ToString("N0", cultura);
    private DatosReserva Leer() => new(txtNombre.Text, txtCorreo.Text, (TipoReserva)cmbTipo.SelectedIndex,
        (TipoSala)cmbSala.SelectedIndex, dtpFecha.Value, (int)nudHoras.Value);

    private void Cotizar()
    {
        if (cmbSala.SelectedIndex < 0 || cmbTipo.SelectedIndex < 0) return;
        var r = control.Cotizar(Leer());
        lblDetalle.Text = $"Subtotal {Colones(r.Subtotal)}   ·   Descuento {Colones(r.Descuento)}";
        lblImporte.Text = $"Total  {Colones(r.Total)}";
    }

    private void Limpiar()
    {
        codigoActual = null;
        lblEdicion.Text = "Nueva reserva";
        btnGuardar.Text = "Registrar";
        errores.Clear();
        txtNombre.Clear();
        txtCorreo.Clear();
        cmbTipo.SelectedIndex = cmbSala.SelectedIndex = 0;
        dtpFecha.Value = DateTime.Today.AddDays(1).AddHours(9);
        nudHoras.Value = 1;
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
            [nameof(datos.Fecha)] = dtpFecha, [nameof(datos.Horas)] = nudHoras
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
        txtBuscar.Clear();
        MostrarReservas();
        Limpiar();
    }

    private void MostrarReservas()
    {
        dgvTabla.Rows.Clear();
        foreach (var r in control.BuscarPorNombre(txtBuscar.Text))
        {
            int fila = dgvTabla.Rows.Add(r.Codigo, r.NombreCliente, r.Tipo,
                r.Sala == TipoSala.Podcast ? "Podcast" : "Video y streaming",
                r.FechaReserva.ToString("dd/MM/yyyy HH:mm"), r.Horas, Colones(r.Total),
                r.CorreoCliente, r.FechaRegistro.ToString("dd/MM/yyyy HH:mm"));
            dgvTabla.Rows[fila].Tag = r;
        }
        var (cantidad, monto) = control.Resumen();
        lblResumen.Text = $"Reservas: {cantidad}     ·     Total acumulado: {Colones(monto)}";
        btnEditar.Enabled = btnEliminar.Enabled = dgvTabla.Rows.Count > 0;
    }

    private void Editar()
    {
        if (dgvTabla.CurrentRow?.Tag is not Reserva r) return;
        errores.Clear();
        codigoActual = r.Codigo;
        lblEdicion.Text = $"Editar reserva #{r.Codigo}";
        btnGuardar.Text = "Guardar cambios";
        txtNombre.Text = r.NombreCliente;
        txtCorreo.Text = r.CorreoCliente;
        dtpFecha.Value = r.FechaReserva;
        cmbTipo.SelectedIndex = (int)r.Tipo;
        cmbSala.SelectedIndex = (int)r.Sala;
        nudHoras.Value = r.Horas;
        Cotizar();
    }

    private void Eliminar()
    {
        if (dgvTabla.CurrentRow?.Tag is not Reserva r) return;
        var respuesta = MessageBox.Show(this, $"¿Eliminar la reserva #{r.Codigo} de {r.NombreCliente}?",
            "Eliminar reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        if (respuesta != DialogResult.Yes) return;
        control.Eliminar(r.Codigo);
        if (codigoActual == r.Codigo) Limpiar();
        MostrarReservas();
    }
}
