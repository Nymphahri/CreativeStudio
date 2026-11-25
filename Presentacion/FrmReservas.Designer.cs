#nullable enable
using Guna.UI2.WinForms;

namespace Presentacion;

partial class FrmReservas
{
    private System.ComponentModel.IContainer? components;
    private Label titulo = null!;
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
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        errores = new ErrorProvider(components);
        titulo = new Label();
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
        tabla = new DataGridView();
        resumen = new Label();
        editar = new Guna2Button();
        eliminar = new Guna2Button();
        ((System.ComponentModel.ISupportInitialize)errores).BeginInit();
        ((System.ComponentModel.ISupportInitialize)horas).BeginInit();
        ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
        SuspendLayout();
        // 
        // errores
        // 
        errores.ContainerControl = this;
        // 
        // titulo
        // 
        titulo.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
        titulo.ForeColor = Color.FromArgb(36, 49, 63);
        titulo.Location = new Point(24, 17);
        titulo.Name = "titulo";
        titulo.Size = new Size(390, 44);
        titulo.TabIndex = 0;
        titulo.Text = "Creative Studio";
        // 
        // subtitulo
        // 
        subtitulo.Font = new Font("Segoe UI", 10F);
        subtitulo.ForeColor = Color.FromArgb(84, 98, 110);
        subtitulo.Location = new Point(26, 64);
        subtitulo.Name = "subtitulo";
        subtitulo.Size = new Size(380, 24);
        subtitulo.TabIndex = 1;
        subtitulo.Text = "Administración de reservas";
        // 
        // edicion
        // 
        edicion.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        edicion.ForeColor = Color.FromArgb(36, 49, 63);
        edicion.Location = new Point(24, 108);
        edicion.Name = "edicion";
        edicion.Size = new Size(305, 31);
        edicion.TabIndex = 2;
        edicion.Text = "Nueva reserva";
        // 
        // lblNombre
        // 
        lblNombre.Font = new Font("Segoe UI", 10F);
        lblNombre.ForeColor = Color.FromArgb(84, 98, 110);
        lblNombre.Location = new Point(24, 149);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(305, 21);
        lblNombre.TabIndex = 3;
        lblNombre.Text = "Nombre del cliente";
        // 
        // txtNombre
        // 
        txtNombre.BorderRadius = 6;
        txtNombre.CustomizableEdges = customizableEdges19;
        txtNombre.DefaultText = "";
        txtNombre.Font = new Font("Segoe UI", 9F);
        txtNombre.Location = new Point(24, 172);
        txtNombre.Name = "txtNombre";
        txtNombre.PlaceholderText = "Persona o empresa";
        txtNombre.SelectedText = "";
        txtNombre.ShadowDecoration.CustomizableEdges = customizableEdges20;
        txtNombre.Size = new Size(305, 36);
        txtNombre.TabIndex = 4;
        // 
        // lblCorreo
        // 
        lblCorreo.Font = new Font("Segoe UI", 10F);
        lblCorreo.ForeColor = Color.FromArgb(84, 98, 110);
        lblCorreo.Location = new Point(24, 218);
        lblCorreo.Name = "lblCorreo";
        lblCorreo.Size = new Size(310, 22);
        lblCorreo.TabIndex = 5;
        lblCorreo.Text = "Correo electrónico";
        // 
        // txtCorreo
        // 
        txtCorreo.BorderRadius = 6;
        txtCorreo.CustomizableEdges = customizableEdges21;
        txtCorreo.DefaultText = "";
        txtCorreo.Font = new Font("Segoe UI", 9F);
        txtCorreo.Location = new Point(24, 241);
        txtCorreo.Name = "txtCorreo";
        txtCorreo.PlaceholderText = "cliente@ejemplo.cr";
        txtCorreo.SelectedText = "";
        txtCorreo.ShadowDecoration.CustomizableEdges = customizableEdges22;
        txtCorreo.Size = new Size(305, 36);
        txtCorreo.TabIndex = 6;
        // 
        // lblTipo
        // 
        lblTipo.Font = new Font("Segoe UI", 10F);
        lblTipo.ForeColor = Color.FromArgb(84, 98, 110);
        lblTipo.Location = new Point(24, 288);
        lblTipo.Name = "lblTipo";
        lblTipo.Size = new Size(295, 22);
        lblTipo.TabIndex = 7;
        lblTipo.Text = "Tipo de reserva";
        // 
        // cmbTipo
        // 
        cmbTipo.BackColor = Color.Transparent;
        cmbTipo.BorderRadius = 6;
        cmbTipo.CustomizableEdges = customizableEdges23;
        cmbTipo.DrawMode = DrawMode.OwnerDrawFixed;
        cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTipo.FocusedColor = Color.Empty;
        cmbTipo.Font = new Font("Segoe UI", 10F);
        cmbTipo.ForeColor = Color.FromArgb(68, 88, 112);
        cmbTipo.ItemHeight = 30;
        cmbTipo.Location = new Point(24, 311);
        cmbTipo.Name = "cmbTipo";
        cmbTipo.ShadowDecoration.CustomizableEdges = customizableEdges24;
        cmbTipo.Size = new Size(305, 36);
        cmbTipo.TabIndex = 8;
        // 
        // lblSala
        // 
        lblSala.Font = new Font("Segoe UI", 10F);
        lblSala.ForeColor = Color.FromArgb(84, 98, 110);
        lblSala.Location = new Point(24, 358);
        lblSala.Name = "lblSala";
        lblSala.Size = new Size(295, 22);
        lblSala.TabIndex = 9;
        lblSala.Text = "Sala";
        // 
        // cmbSala
        // 
        cmbSala.BackColor = Color.Transparent;
        cmbSala.BorderRadius = 6;
        cmbSala.CustomizableEdges = customizableEdges25;
        cmbSala.DrawMode = DrawMode.OwnerDrawFixed;
        cmbSala.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbSala.FocusedColor = Color.Empty;
        cmbSala.Font = new Font("Segoe UI", 10F);
        cmbSala.ForeColor = Color.FromArgb(68, 88, 112);
        cmbSala.ItemHeight = 30;
        cmbSala.Location = new Point(24, 381);
        cmbSala.Name = "cmbSala";
        cmbSala.ShadowDecoration.CustomizableEdges = customizableEdges26;
        cmbSala.Size = new Size(305, 36);
        cmbSala.TabIndex = 10;
        // 
        // lblFecha
        // 
        lblFecha.Font = new Font("Segoe UI", 10F);
        lblFecha.ForeColor = Color.FromArgb(84, 98, 110);
        lblFecha.Location = new Point(24, 430);
        lblFecha.Name = "lblFecha";
        lblFecha.Size = new Size(210, 22);
        lblFecha.TabIndex = 11;
        lblFecha.Text = "Fecha y hora";
        // 
        // fecha
        // 
        fecha.CustomFormat = "dd/MM/yyyy  HH:mm";
        fecha.Format = DateTimePickerFormat.Custom;
        fecha.Location = new Point(24, 455);
        fecha.Name = "fecha";
        fecha.ShowUpDown = true;
        fecha.Size = new Size(205, 25);
        fecha.TabIndex = 12;
        // 
        // lblHoras
        // 
        lblHoras.Font = new Font("Segoe UI", 10F);
        lblHoras.ForeColor = Color.FromArgb(84, 98, 110);
        lblHoras.Location = new Point(245, 430);
        lblHoras.Name = "lblHoras";
        lblHoras.Size = new Size(85, 22);
        lblHoras.TabIndex = 13;
        lblHoras.Text = "Horas";
        // 
        // horas
        // 
        horas.Location = new Point(245, 455);
        horas.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
        horas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        horas.Name = "horas";
        horas.Size = new Size(84, 25);
        horas.TabIndex = 14;
        horas.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // detalle
        // 
        detalle.Font = new Font("Segoe UI", 10F);
        detalle.ForeColor = Color.FromArgb(84, 98, 110);
        detalle.Location = new Point(24, 505);
        detalle.Name = "detalle";
        detalle.Size = new Size(330, 23);
        detalle.TabIndex = 15;
        // 
        // importe
        // 
        importe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        importe.ForeColor = Color.FromArgb(36, 49, 63);
        importe.Location = new Point(24, 532);
        importe.Name = "importe";
        importe.Size = new Size(330, 33);
        importe.TabIndex = 16;
        // 
        // guardar
        // 
        guardar.BorderRadius = 6;
        guardar.CustomizableEdges = customizableEdges27;
        guardar.FillColor = Color.FromArgb(22, 99, 103);
        guardar.Font = new Font("Segoe UI", 9F);
        guardar.ForeColor = Color.White;
        guardar.Location = new Point(24, 587);
        guardar.Name = "guardar";
        guardar.ShadowDecoration.CustomizableEdges = customizableEdges28;
        guardar.Size = new Size(158, 36);
        guardar.TabIndex = 17;
        guardar.Text = "Registrar";
        // 
        // nuevo
        // 
        nuevo.BorderRadius = 6;
        nuevo.CustomizableEdges = customizableEdges29;
        nuevo.FillColor = Color.FromArgb(84, 98, 110);
        nuevo.Font = new Font("Segoe UI", 9F);
        nuevo.ForeColor = Color.White;
        nuevo.Location = new Point(192, 587);
        nuevo.Name = "nuevo";
        nuevo.ShadowDecoration.CustomizableEdges = customizableEdges30;
        nuevo.Size = new Size(137, 36);
        nuevo.TabIndex = 18;
        nuevo.Text = "Limpiar";
        // 
        // lista
        // 
        lista.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lista.ForeColor = Color.FromArgb(36, 49, 63);
        lista.Location = new Point(365, 108);
        lista.Name = "lista";
        lista.Size = new Size(400, 36);
        lista.TabIndex = 19;
        lista.Text = "Reservas registradas";
        // 
        // buscar
        // 
        buscar.BorderRadius = 6;
        buscar.CustomizableEdges = customizableEdges31;
        buscar.DefaultText = "";
        buscar.Font = new Font("Segoe UI", 9F);
        buscar.Location = new Point(365, 151);
        buscar.Name = "buscar";
        buscar.PlaceholderText = "Buscar por nombre del cliente";
        buscar.SelectedText = "";
        buscar.ShadowDecoration.CustomizableEdges = customizableEdges32;
        buscar.Size = new Size(320, 36);
        buscar.TabIndex = 20;
        // 
        // tabla
        // 
        tabla.AllowUserToAddRows = false;
        tabla.AllowUserToDeleteRows = false;
        tabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        tabla.BackgroundColor = Color.White;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.FromArgb(36, 66, 72);
        dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
        dataGridViewCellStyle3.ForeColor = Color.White;
        dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        tabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
        tabla.ColumnHeadersHeight = 37;
        dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle4.BackColor = SystemColors.Window;
        dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
        dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(214, 237, 233);
        dataGridViewCellStyle4.SelectionForeColor = Color.Black;
        dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
        tabla.DefaultCellStyle = dataGridViewCellStyle4;
        tabla.EnableHeadersVisualStyles = false;
        tabla.Location = new Point(365, 204);
        tabla.MultiSelect = false;
        tabla.Name = "tabla";
        tabla.ReadOnly = true;
        tabla.RowHeadersVisible = false;
        tabla.RowTemplate.Height = 35;
        tabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        tabla.Size = new Size(696, 347);
        tabla.TabIndex = 21;
        // 
        // resumen
        // 
        resumen.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        resumen.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        resumen.ForeColor = Color.FromArgb(36, 49, 63);
        resumen.Location = new Point(365, 563);
        resumen.Name = "resumen";
        resumen.Size = new Size(666, 28);
        resumen.TabIndex = 22;
        // 
        // editar
        // 
        editar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        editar.BorderRadius = 6;
        editar.CustomizableEdges = customizableEdges33;
        editar.FillColor = Color.FromArgb(22, 99, 103);
        editar.Font = new Font("Segoe UI", 9F);
        editar.ForeColor = Color.White;
        editar.Location = new Point(365, 601);
        editar.Name = "editar";
        editar.ShadowDecoration.CustomizableEdges = customizableEdges34;
        editar.Size = new Size(120, 36);
        editar.TabIndex = 23;
        editar.Text = "Editar";
        // 
        // eliminar
        // 
        eliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        eliminar.BorderRadius = 6;
        eliminar.CustomizableEdges = customizableEdges35;
        eliminar.FillColor = Color.FromArgb(141, 63, 69);
        eliminar.Font = new Font("Segoe UI", 9F);
        eliminar.ForeColor = Color.White;
        eliminar.Location = new Point(495, 601);
        eliminar.Name = "eliminar";
        eliminar.ShadowDecoration.CustomizableEdges = customizableEdges36;
        eliminar.Size = new Size(120, 36);
        eliminar.TabIndex = 24;
        eliminar.Text = "Eliminar";
        // 
        // FrmReservas
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 249, 248);
        ClientSize = new Size(1085, 666);
        Controls.Add(titulo);
        Controls.Add(subtitulo);
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
        Controls.Add(buscar);
        Controls.Add(tabla);
        Controls.Add(resumen);
        Controls.Add(editar);
        Controls.Add(eliminar);
        Font = new Font("Segoe UI", 10F);
        MinimumSize = new Size(1030, 705);
        Name = "FrmReservas";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Creative Studio";
        ((System.ComponentModel.ISupportInitialize)errores).EndInit();
        ((System.ComponentModel.ISupportInitialize)horas).EndInit();
        ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
        ResumeLayout(false);
    }
}
