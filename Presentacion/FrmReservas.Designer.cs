#nullable enable
using Guna.UI2.WinForms;

namespace Presentacion;

partial class FrmReservas
{
    private System.ComponentModel.IContainer? components;
    private Label titulo = null!;
    private Panel encabezado = null!;
    private Label lblBuscar = null!;
    private Label subtitulo = null!;
    private Label edicion = null!;
    private Label lblNombre = null!;
    private Guna2TextBox txtNombre = null!;
    private Label lblCorreo = null!;
    private Guna2TextBox txtCorreo = null!;
    private Label lblTipo = null!;
    private Guna2ComboBox cmbTipo = null!;
    private Label lblSala = null!;
    private Guna2ComboBox cmbSala = null!;
    private Label lblFecha = null!;
    private DateTimePicker fecha = null!;
    private Label lblHoras = null!;
    private NumericUpDown horas = null!;
    private Label detalle = null!;
    private Label importe = null!;
    private Guna2Button guardar = null!;
    private Guna2Button nuevo = null!;
    private Label lista = null!;
    private Guna2TextBox buscar = null!;
    private DataGridView tabla = null!;
    private Label resumen = null!;
    private Guna2Button editar = null!;
    private Guna2Button eliminar = null!;
    private ErrorProvider errores = null!;

    protected override void Dispose(bool disposing)
    {
        if (disposing) components?.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        errores = new ErrorProvider(components);
        SuspendLayout();
        Text = "Creative Studio | Reservas";
        BackColor = Color.FromArgb(251, 249, 247);
        Font = new Font("Segoe UI", 10F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScaleDimensions = new SizeF(7F, 17F);
        ClientSize = new Size(1085, 665);
        MinimumSize = new Size(1030, 705);
        StartPosition = FormStartPosition.CenterScreen;
        titulo = new Label();
        titulo.Name = "titulo";
        titulo.Location = new Point(22, 9);
        titulo.Size = new Size(390, 44);
        titulo.Text = "Creative Studio";
        titulo.ForeColor = Color.White;
        titulo.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
        encabezado = new Panel();
        encabezado.Name = "encabezado";
        encabezado.Size = new Size(1085, 88);
        encabezado.Dock = DockStyle.Top;
        encabezado.BackColor = Color.FromArgb(85, 58, 76);
        encabezado.Controls.Add(titulo);
        Controls.Add(encabezado);

        subtitulo = new Label();
        subtitulo.Name = "subtitulo";
        subtitulo.Location = new Point(25, 54);
        subtitulo.Size = new Size(380, 24);
        subtitulo.Text = "Reservas del estudio";
        subtitulo.ForeColor = Color.FromArgb(243, 230, 236);
        subtitulo.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        encabezado.Controls.Add(subtitulo);

        edicion = new Label();
        edicion.Name = "edicion";
        edicion.Location = new Point(24, 108);
        edicion.Size = new Size(305, 31);
        edicion.Text = "Nueva reserva";
        edicion.ForeColor = Color.FromArgb(56, 45, 55);
        edicion.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        Controls.Add(edicion);

        lblNombre = new Label();
        lblNombre.Name = "lblNombre";
        lblNombre.Location = new Point(24, 149);
        lblNombre.Size = new Size(305, 21);
        lblNombre.Text = "Nombre del cliente";
        lblNombre.ForeColor = Color.FromArgb(90, 81, 87);
        lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        Controls.Add(lblNombre);

        txtNombre = new Guna2TextBox();
        txtNombre.Name = "txtNombre";
        txtNombre.Location = new Point(24, 172);
        txtNombre.Size = new Size(305, 36);
        txtNombre.BorderRadius = 6;
        txtNombre.PlaceholderText = "Persona o empresa";
        Controls.Add(txtNombre);

        lblCorreo = new Label();
        lblCorreo.Name = "lblCorreo";
        lblCorreo.Location = new Point(24, 218);
        lblCorreo.Size = new Size(310, 22);
        lblCorreo.Text = "Correo electrónico";
        lblCorreo.ForeColor = Color.FromArgb(90, 81, 87);
        lblCorreo.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        Controls.Add(lblCorreo);

        txtCorreo = new Guna2TextBox();
        txtCorreo.Name = "txtCorreo";
        txtCorreo.Location = new Point(24, 241);
        txtCorreo.Size = new Size(305, 36);
        txtCorreo.BorderRadius = 6;
        txtCorreo.PlaceholderText = "cliente@ejemplo.cr";
        Controls.Add(txtCorreo);

        lblTipo = new Label();
        lblTipo.Name = "lblTipo";
        lblTipo.Location = new Point(24, 288);
        lblTipo.Size = new Size(295, 22);
        lblTipo.Text = "Tipo de reserva";
        lblTipo.ForeColor = Color.FromArgb(90, 81, 87);
        lblTipo.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        Controls.Add(lblTipo);

        cmbTipo = new Guna2ComboBox();
        cmbTipo.Name = "cmbTipo";
        cmbTipo.Location = new Point(24, 311);
        cmbTipo.Size = new Size(305, 36);
        cmbTipo.BorderRadius = 6;
        cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        Controls.Add(cmbTipo);

        lblSala = new Label();
        lblSala.Name = "lblSala";
        lblSala.Location = new Point(24, 358);
        lblSala.Size = new Size(295, 22);
        lblSala.Text = "Sala";
        lblSala.ForeColor = Color.FromArgb(90, 81, 87);
        lblSala.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        Controls.Add(lblSala);

        cmbSala = new Guna2ComboBox();
        cmbSala.Name = "cmbSala";
        cmbSala.Location = new Point(24, 381);
        cmbSala.Size = new Size(305, 36);
        cmbSala.BorderRadius = 6;
        cmbSala.DropDownStyle = ComboBoxStyle.DropDownList;
        Controls.Add(cmbSala);

        lblFecha = new Label();
        lblFecha.Name = "lblFecha";
        lblFecha.Location = new Point(24, 430);
        lblFecha.Size = new Size(210, 22);
        lblFecha.Text = "Fecha y hora";
        lblFecha.ForeColor = Color.FromArgb(90, 81, 87);
        lblFecha.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        Controls.Add(lblFecha);

        fecha = new DateTimePicker();
        fecha.Name = "fecha";
        fecha.Location = new Point(24, 455);
        fecha.Size = new Size(205, 28);
        fecha.Format = DateTimePickerFormat.Custom;
        fecha.CustomFormat = "dd/MM/yyyy  HH:mm";
        fecha.ShowUpDown = true;
        Controls.Add(fecha);

        lblHoras = new Label();
        lblHoras.Name = "lblHoras";
        lblHoras.Location = new Point(245, 430);
        lblHoras.Size = new Size(85, 22);
        lblHoras.Text = "Horas";
        lblHoras.ForeColor = Color.FromArgb(90, 81, 87);
        lblHoras.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        Controls.Add(lblHoras);

        horas = new NumericUpDown();
        horas.Name = "horas";
        horas.Location = new Point(245, 455);
        horas.Size = new Size(84, 28);
        horas.Minimum = 1;
        horas.Maximum = 4;
        horas.Value = 1;
        Controls.Add(horas);

        detalle = new Label();
        detalle.Name = "detalle";
        detalle.Location = new Point(24, 505);
        detalle.Size = new Size(330, 23);
        detalle.Text = "";
        detalle.ForeColor = Color.FromArgb(90, 81, 87);
        detalle.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        Controls.Add(detalle);

        importe = new Label();
        importe.Name = "importe";
        importe.Location = new Point(24, 532);
        importe.Size = new Size(330, 33);
        importe.Text = "";
        importe.ForeColor = Color.FromArgb(56, 45, 55);
        importe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        Controls.Add(importe);

        guardar = new Guna2Button();
        guardar.Name = "guardar";
        guardar.Location = new Point(24, 601);
        guardar.Size = new Size(158, 36);
        guardar.Text = "Registrar";
        guardar.FillColor = Color.FromArgb(111, 68, 96);
        guardar.BorderRadius = 6;
        guardar.ForeColor = Color.White;
        Controls.Add(guardar);

        nuevo = new Guna2Button();
        nuevo.Name = "nuevo";
        nuevo.Location = new Point(192, 601);
        nuevo.Size = new Size(137, 36);
        nuevo.Text = "Limpiar";
        nuevo.FillColor = Color.FromArgb(238, 232, 235);
        nuevo.BorderRadius = 6;
        nuevo.ForeColor = Color.FromArgb(82, 52, 70);
        Controls.Add(nuevo);

        lista = new Label();
        lista.Name = "lista";
        lista.Location = new Point(365, 108);
        lista.Size = new Size(400, 36);
        lista.Text = "Reservas registradas";
        lista.ForeColor = Color.FromArgb(56, 45, 55);
        lista.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        Controls.Add(lista);

        buscar = new Guna2TextBox();
        buscar.Name = "buscar";
        lblBuscar = new Label();
        lblBuscar.Name = "lblBuscar";
        lblBuscar.Text = "Buscar cliente";
        lblBuscar.Location = new Point(365, 157);
        lblBuscar.Size = new Size(100, 25);
        lblBuscar.ForeColor = Color.FromArgb(90, 81, 87);
        Controls.Add(lblBuscar);
        buscar.Location = new Point(470, 149);
        buscar.Size = new Size(320, 36);
        buscar.BorderRadius = 6;
        buscar.PlaceholderText = "Buscar por nombre del cliente";
        Controls.Add(buscar);

        tabla = new DataGridView();
        tabla.Name = "tabla";
        tabla.Location = new Point(365, 204);
        tabla.Size = new Size(696, 347);
        tabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tabla.BackgroundColor = Color.White;
        tabla.BorderStyle = BorderStyle.None;
        tabla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        tabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        tabla.GridColor = Color.FromArgb(230, 223, 227);
        tabla.AllowUserToAddRows = false;
        tabla.AllowUserToDeleteRows = false;
        tabla.ReadOnly = true;
        tabla.RowHeadersVisible = false;
        tabla.MultiSelect = false;
        tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        tabla.AutoGenerateColumns = false;
        tabla.EnableHeadersVisualStyles = false;
        tabla.ColumnHeadersHeight = 37;
        Controls.Add(tabla);

        resumen = new Label();
        resumen.Name = "resumen";
        resumen.Location = new Point(365, 563);
        resumen.Size = new Size(666, 28);
        resumen.Text = "";
        resumen.ForeColor = Color.FromArgb(56, 45, 55);
        resumen.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        Controls.Add(resumen);

        editar = new Guna2Button();
        editar.Name = "editar";
        editar.Location = new Point(365, 601);
        editar.Size = new Size(120, 36);
        editar.Text = "Editar";
        editar.FillColor = Color.FromArgb(238, 232, 235);
        editar.BorderRadius = 6;
        editar.ForeColor = Color.FromArgb(82, 52, 70);
        Controls.Add(editar);

        eliminar = new Guna2Button();
        eliminar.Name = "eliminar";
        eliminar.Location = new Point(495, 601);
        eliminar.Size = new Size(120, 36);
        eliminar.Text = "Eliminar";
        eliminar.FillColor = Color.FromArgb(249, 235, 232);
        eliminar.BorderRadius = 6;
        eliminar.ForeColor = Color.FromArgb(139, 55, 53);
        Controls.Add(eliminar);
        errores.ContainerControl = this;
        resumen.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        editar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        eliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        tabla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(237, 231, 234);
        tabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(72, 49, 64);
        tabla.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(237, 231, 234);
        tabla.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.FromArgb(72, 49, 64);
        tabla.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(251, 248, 250);
        tabla.DefaultCellStyle.SelectionBackColor = Color.FromArgb(234, 218, 229);
        tabla.DefaultCellStyle.SelectionForeColor = Color.Black;
        tabla.RowTemplate.Height = 35;
        ResumeLayout(false);
    }
}
