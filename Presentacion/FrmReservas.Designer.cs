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
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReservas));
        errores = new ErrorProvider(components);
        titulo = new Label();
        encabezado = new Panel();
        subtitulo = new Label();
        edicion = new Label();
        lblNombre = new Label();
        txtNombre = new Guna2TextBox();
        lblCorreo = new Label();
        txtCorreo = new Guna2TextBox();
        lblTipo = new Label();
        cmbTipo = new Guna2ComboBox();
        lblSala = new Label();
        cmbSala = new Guna2ComboBox();
        lblFecha = new Label();
        fecha = new DateTimePicker();
        lblHoras = new Label();
        horas = new NumericUpDown();
        detalle = new Label();
        importe = new Label();
        guardar = new Guna2Button();
        nuevo = new Guna2Button();
        lista = new Label();
        buscar = new Guna2TextBox();
        lblBuscar = new Label();
        tabla = new DataGridView();
        resumen = new Label();
        editar = new Guna2Button();
        eliminar = new Guna2Button();
        picLogo = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)errores).BeginInit();
        encabezado.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)horas).BeginInit();
        ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
        SuspendLayout();
        // 
        // errores
        // 
        errores.ContainerControl = this;
        // 
        // titulo
        // 
        titulo.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
        titulo.ForeColor = Color.White;
        titulo.Location = new Point(22, 9);
        titulo.Name = "titulo";
        titulo.Size = new Size(390, 44);
        titulo.TabIndex = 0;
        titulo.Text = "Creative Studio";
        // 
        // encabezado
        // 
        encabezado.BackColor = Color.FromArgb(85, 58, 76);
        encabezado.Controls.Add(picLogo);
        encabezado.Controls.Add(titulo);
        encabezado.Controls.Add(subtitulo);
        encabezado.Dock = DockStyle.Top;
        encabezado.Location = new Point(0, 0);
        encabezado.Name = "encabezado";
        encabezado.Size = new Size(1304, 122);
        encabezado.TabIndex = 0;
        // 
        // subtitulo
        // 
        subtitulo.Font = new Font("Segoe UI", 10F);
        subtitulo.ForeColor = Color.FromArgb(243, 230, 236);
        subtitulo.Location = new Point(25, 54);
        subtitulo.Name = "subtitulo";
        subtitulo.Size = new Size(380, 24);
        subtitulo.TabIndex = 1;
        subtitulo.Text = "Reservas del estudio";
        // 
        // edicion
        // 
        edicion.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        edicion.ForeColor = Color.FromArgb(56, 45, 55);
        edicion.Location = new Point(22, 136);
        edicion.Name = "edicion";
        edicion.Size = new Size(305, 31);
        edicion.TabIndex = 1;
        edicion.Text = "Nueva reserva";
        // 
        // lblNombre
        // 
        lblNombre.Font = new Font("Segoe UI", 10F);
        lblNombre.ForeColor = Color.FromArgb(90, 81, 87);
        lblNombre.Location = new Point(22, 177);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(305, 21);
        lblNombre.TabIndex = 2;
        lblNombre.Text = "Nombre del cliente";
        // 
        // txtNombre
        // 
        txtNombre.BorderRadius = 6;
        txtNombre.CustomizableEdges = customizableEdges1;
        txtNombre.DefaultText = "";
        txtNombre.Font = new Font("Segoe UI", 9F);
        txtNombre.Location = new Point(22, 200);
        txtNombre.Name = "txtNombre";
        txtNombre.PlaceholderText = "Persona o empresa";
        txtNombre.SelectedText = "";
        txtNombre.ShadowDecoration.CustomizableEdges = customizableEdges2;
        txtNombre.Size = new Size(305, 36);
        txtNombre.TabIndex = 3;
        // 
        // lblCorreo
        // 
        lblCorreo.Font = new Font("Segoe UI", 10F);
        lblCorreo.ForeColor = Color.FromArgb(90, 81, 87);
        lblCorreo.Location = new Point(22, 246);
        lblCorreo.Name = "lblCorreo";
        lblCorreo.Size = new Size(310, 22);
        lblCorreo.TabIndex = 4;
        lblCorreo.Text = "Correo electrónico";
        // 
        // txtCorreo
        // 
        txtCorreo.BorderRadius = 6;
        txtCorreo.CustomizableEdges = customizableEdges3;
        txtCorreo.DefaultText = "";
        txtCorreo.Font = new Font("Segoe UI", 9F);
        txtCorreo.Location = new Point(22, 269);
        txtCorreo.Name = "txtCorreo";
        txtCorreo.PlaceholderText = "cliente@ejemplo.cr";
        txtCorreo.SelectedText = "";
        txtCorreo.ShadowDecoration.CustomizableEdges = customizableEdges4;
        txtCorreo.Size = new Size(305, 36);
        txtCorreo.TabIndex = 5;
        // 
        // lblTipo
        // 
        lblTipo.Font = new Font("Segoe UI", 10F);
        lblTipo.ForeColor = Color.FromArgb(90, 81, 87);
        lblTipo.Location = new Point(22, 316);
        lblTipo.Name = "lblTipo";
        lblTipo.Size = new Size(295, 22);
        lblTipo.TabIndex = 6;
        lblTipo.Text = "Tipo de reserva";
        // 
        // cmbTipo
        // 
        cmbTipo.BackColor = Color.Transparent;
        cmbTipo.BorderRadius = 6;
        cmbTipo.CustomizableEdges = customizableEdges5;
        cmbTipo.DrawMode = DrawMode.OwnerDrawFixed;
        cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTipo.FocusedColor = Color.Empty;
        cmbTipo.Font = new Font("Segoe UI", 10F);
        cmbTipo.ForeColor = Color.FromArgb(68, 88, 112);
        cmbTipo.ItemHeight = 30;
        cmbTipo.Location = new Point(22, 339);
        cmbTipo.Name = "cmbTipo";
        cmbTipo.ShadowDecoration.CustomizableEdges = customizableEdges6;
        cmbTipo.Size = new Size(305, 36);
        cmbTipo.TabIndex = 7;
        // 
        // lblSala
        // 
        lblSala.Font = new Font("Segoe UI", 10F);
        lblSala.ForeColor = Color.FromArgb(90, 81, 87);
        lblSala.Location = new Point(22, 386);
        lblSala.Name = "lblSala";
        lblSala.Size = new Size(295, 22);
        lblSala.TabIndex = 8;
        lblSala.Text = "Sala";
        // 
        // cmbSala
        // 
        cmbSala.BackColor = Color.Transparent;
        cmbSala.BorderRadius = 6;
        cmbSala.CustomizableEdges = customizableEdges7;
        cmbSala.DrawMode = DrawMode.OwnerDrawFixed;
        cmbSala.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbSala.FocusedColor = Color.Empty;
        cmbSala.Font = new Font("Segoe UI", 10F);
        cmbSala.ForeColor = Color.FromArgb(68, 88, 112);
        cmbSala.ItemHeight = 30;
        cmbSala.Location = new Point(22, 409);
        cmbSala.Name = "cmbSala";
        cmbSala.ShadowDecoration.CustomizableEdges = customizableEdges8;
        cmbSala.Size = new Size(305, 36);
        cmbSala.TabIndex = 9;
        // 
        // lblFecha
        // 
        lblFecha.Font = new Font("Segoe UI", 10F);
        lblFecha.ForeColor = Color.FromArgb(90, 81, 87);
        lblFecha.Location = new Point(22, 458);
        lblFecha.Name = "lblFecha";
        lblFecha.Size = new Size(210, 22);
        lblFecha.TabIndex = 10;
        lblFecha.Text = "Fecha y hora";
        // 
        // fecha
        // 
        fecha.CustomFormat = "dd/MM/yyyy  HH:mm";
        fecha.Format = DateTimePickerFormat.Custom;
        fecha.Location = new Point(22, 483);
        fecha.Name = "fecha";
        fecha.ShowUpDown = true;
        fecha.Size = new Size(205, 25);
        fecha.TabIndex = 11;
        // 
        // lblHoras
        // 
        lblHoras.Font = new Font("Segoe UI", 10F);
        lblHoras.ForeColor = Color.FromArgb(90, 81, 87);
        lblHoras.Location = new Point(243, 458);
        lblHoras.Name = "lblHoras";
        lblHoras.Size = new Size(85, 22);
        lblHoras.TabIndex = 12;
        lblHoras.Text = "Horas";
        // 
        // horas
        // 
        horas.Location = new Point(243, 483);
        horas.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
        horas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        horas.Name = "horas";
        horas.Size = new Size(84, 25);
        horas.TabIndex = 13;
        horas.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // detalle
        // 
        detalle.Font = new Font("Segoe UI", 10F);
        detalle.ForeColor = Color.FromArgb(90, 81, 87);
        detalle.Location = new Point(34, 550);
        detalle.Name = "detalle";
        detalle.Size = new Size(309, 23);
        detalle.TabIndex = 14;
        // 
        // importe
        // 
        importe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        importe.ForeColor = Color.FromArgb(56, 45, 55);
        importe.Location = new Point(34, 577);
        importe.Name = "importe";
        importe.Size = new Size(309, 33);
        importe.TabIndex = 15;
        // 
        // guardar
        // 
        guardar.BorderRadius = 6;
        guardar.CustomizableEdges = customizableEdges9;
        guardar.FillColor = Color.FromArgb(111, 68, 96);
        guardar.Font = new Font("Segoe UI", 9F);
        guardar.ForeColor = Color.White;
        guardar.Location = new Point(22, 629);
        guardar.Name = "guardar";
        guardar.ShadowDecoration.CustomizableEdges = customizableEdges10;
        guardar.Size = new Size(158, 36);
        guardar.TabIndex = 16;
        guardar.Text = "Registrar";
        // 
        // nuevo
        // 
        nuevo.BorderRadius = 6;
        nuevo.CustomizableEdges = customizableEdges11;
        nuevo.FillColor = Color.FromArgb(238, 232, 235);
        nuevo.Font = new Font("Segoe UI", 9F);
        nuevo.ForeColor = Color.FromArgb(82, 52, 70);
        nuevo.Location = new Point(190, 629);
        nuevo.Name = "nuevo";
        nuevo.ShadowDecoration.CustomizableEdges = customizableEdges12;
        nuevo.Size = new Size(137, 36);
        nuevo.TabIndex = 17;
        nuevo.Text = "Limpiar";
        // 
        // lista
        // 
        lista.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lista.ForeColor = Color.FromArgb(56, 45, 55);
        lista.Location = new Point(377, 137);
        lista.Name = "lista";
        lista.Size = new Size(400, 36);
        lista.TabIndex = 18;
        lista.Text = "Reservas registradas";
        // 
        // buscar
        // 
        buscar.BorderRadius = 6;
        buscar.CustomizableEdges = customizableEdges13;
        buscar.DefaultText = "";
        buscar.Font = new Font("Segoe UI", 9F);
        buscar.Location = new Point(482, 178);
        buscar.Name = "buscar";
        buscar.PlaceholderText = "Buscar por nombre del cliente";
        buscar.SelectedText = "";
        buscar.ShadowDecoration.CustomizableEdges = customizableEdges14;
        buscar.Size = new Size(320, 36);
        buscar.TabIndex = 20;
        // 
        // lblBuscar
        // 
        lblBuscar.ForeColor = Color.FromArgb(90, 81, 87);
        lblBuscar.Location = new Point(377, 186);
        lblBuscar.Name = "lblBuscar";
        lblBuscar.Size = new Size(100, 25);
        lblBuscar.TabIndex = 19;
        lblBuscar.Text = "Buscar cliente";
        // 
        // tabla
        // 
        tabla.AllowUserToAddRows = false;
        tabla.AllowUserToDeleteRows = false;
        dataGridViewCellStyle1.BackColor = Color.FromArgb(251, 248, 250);
        tabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        tabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        tabla.BackgroundColor = Color.White;
        tabla.BorderStyle = BorderStyle.None;
        tabla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        tabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.FromArgb(237, 231, 234);
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(72, 49, 64);
        dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(237, 231, 234);
        dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(72, 49, 64);
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        tabla.ColumnHeadersHeight = 37;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = SystemColors.Window;
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
        dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(234, 218, 229);
        dataGridViewCellStyle3.SelectionForeColor = Color.Black;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
        tabla.DefaultCellStyle = dataGridViewCellStyle3;
        tabla.EnableHeadersVisualStyles = false;
        tabla.GridColor = Color.FromArgb(230, 223, 227);
        tabla.Location = new Point(377, 233);
        tabla.MultiSelect = false;
        tabla.Name = "tabla";
        tabla.ReadOnly = true;
        tabla.RowHeadersVisible = false;
        tabla.RowTemplate.Height = 35;
        tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        tabla.Size = new Size(915, 401);
        tabla.TabIndex = 21;
        // 
        // resumen
        // 
        resumen.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        resumen.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        resumen.ForeColor = Color.FromArgb(56, 45, 55);
        resumen.Location = new Point(377, 646);
        resumen.Name = "resumen";
        resumen.Size = new Size(666, 28);
        resumen.TabIndex = 22;
        // 
        // editar
        // 
        editar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        editar.BorderRadius = 6;
        editar.CustomizableEdges = customizableEdges15;
        editar.FillColor = Color.FromArgb(238, 232, 235);
        editar.Font = new Font("Segoe UI", 9F);
        editar.ForeColor = Color.FromArgb(82, 52, 70);
        editar.Location = new Point(377, 677);
        editar.Name = "editar";
        editar.ShadowDecoration.CustomizableEdges = customizableEdges16;
        editar.Size = new Size(120, 36);
        editar.TabIndex = 23;
        editar.Text = "Editar";
        // 
        // eliminar
        // 
        eliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        eliminar.BorderRadius = 6;
        eliminar.CustomizableEdges = customizableEdges17;
        eliminar.FillColor = Color.FromArgb(249, 235, 232);
        eliminar.Font = new Font("Segoe UI", 9F);
        eliminar.ForeColor = Color.FromArgb(139, 55, 53);
        eliminar.Location = new Point(507, 677);
        eliminar.Name = "eliminar";
        eliminar.ShadowDecoration.CustomizableEdges = customizableEdges18;
        eliminar.Size = new Size(120, 36);
        eliminar.TabIndex = 24;
        eliminar.Text = "Eliminar";
        // 
        // picLogo
        // 
        picLogo.Image = (Image)resources.GetObject("picLogo.Image");
        picLogo.Location = new Point(1007, -22);
        picLogo.Name = "picLogo";
        picLogo.Size = new Size(338, 210);
        picLogo.TabIndex = 2;
        picLogo.TabStop = false;
        // 
        // FrmReservas
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(251, 249, 247);
        ClientSize = new Size(1304, 720);
        Controls.Add(encabezado);
        Controls.Add(edicion);
        Controls.Add(lblNombre);
        Controls.Add(txtNombre);
        Controls.Add(lblCorreo);
        Controls.Add(txtCorreo);
        Controls.Add(lblTipo);
        Controls.Add(cmbTipo);
        Controls.Add(lblSala);
        Controls.Add(cmbSala);
        Controls.Add(lblFecha);
        Controls.Add(fecha);
        Controls.Add(lblHoras);
        Controls.Add(horas);
        Controls.Add(detalle);
        Controls.Add(importe);
        Controls.Add(guardar);
        Controls.Add(nuevo);
        Controls.Add(lista);
        Controls.Add(lblBuscar);
        Controls.Add(buscar);
        Controls.Add(tabla);
        Controls.Add(resumen);
        Controls.Add(editar);
        Controls.Add(eliminar);
        Font = new Font("Segoe UI", 10F);
        MinimumSize = new Size(1030, 705);
        Name = "FrmReservas";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Creative Studio | Reservas";
        ((System.ComponentModel.ISupportInitialize)errores).EndInit();
        encabezado.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)horas).EndInit();
        ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
        ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
        ResumeLayout(false);
    }

    private PictureBox picLogo;
}
