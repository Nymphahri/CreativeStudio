#nullable enable
using Guna.UI2.WinForms;

namespace Presentacion;

partial class FrmReservas
{
    private System.ComponentModel.IContainer? components;
    private Label lblTitulo = null!;
    private Panel encabezado = null!;
    private Label lblBuscar = null!;
    private Label lblSubtitulo = null!;
    private Label lblEdicion = null!;
    private Label lblNombre = null!;
    private Guna2TextBox txtNombre = null!;
    private Label lblCorreo = null!;
    private Guna2TextBox txtCorreo = null!;
    private Label lblTipo = null!;
    private Guna2ComboBox cmbTipo = null!;
    private Label lblSala = null!;
    private Guna2ComboBox cmbSala = null!;
    private Label lblFecha = null!;
    private DateTimePicker dtpFecha = null!;
    private Label lblHoras = null!;
    private NumericUpDown nudHoras = null!;
    private Label lblDetalle = null!;
    private Label lblImporte = null!;
    private Guna2Button btnGuardar = null!;
    private Guna2Button btnNuevo = null!;
    private Label lblLista = null!;
    private Guna2TextBox txtBuscar = null!;
    private DataGridView dgvTabla = null!;
    private Label lblResumen = null!;
    private Guna2Button btnEditar = null!;
    private Guna2Button btnEliminar = null!;
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
        DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
        errores = new ErrorProvider(components);
        lblTitulo = new Label();
        encabezado = new Panel();
        lblSubtitulo = new Label();
        lblEdicion = new Label();
        lblNombre = new Label();
        txtNombre = new Guna2TextBox();
        lblCorreo = new Label();
        txtCorreo = new Guna2TextBox();
        lblTipo = new Label();
        cmbTipo = new Guna2ComboBox();
        lblSala = new Label();
        cmbSala = new Guna2ComboBox();
        lblFecha = new Label();
        dtpFecha = new DateTimePicker();
        lblHoras = new Label();
        nudHoras = new NumericUpDown();
        lblDetalle = new Label();
        lblImporte = new Label();
        btnGuardar = new Guna2Button();
        btnNuevo = new Guna2Button();
        lblLista = new Label();
        txtBuscar = new Guna2TextBox();
        lblBuscar = new Label();
        dgvTabla = new DataGridView();
        lblResumen = new Label();
        btnEditar = new Guna2Button();
        btnEliminar = new Guna2Button();
        ((System.ComponentModel.ISupportInitialize)errores).BeginInit();
        encabezado.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nudHoras).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dgvTabla).BeginInit();
        SuspendLayout();
        // 
        // errores
        // 
        errores.ContainerControl = this;
        // 
        // lblTitulo
        // 
        lblTitulo.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
        lblTitulo.ForeColor = Color.White;
        lblTitulo.Location = new Point(22, 9);
        lblTitulo.Name = "lblTitulo";
        lblTitulo.Size = new Size(390, 44);
        lblTitulo.TabIndex = 0;
        lblTitulo.Text = "Creative Studio";
        // 
        // encabezado
        // 
        encabezado.BackColor = Color.FromArgb(85, 58, 76);
        encabezado.Controls.Add(lblTitulo);
        encabezado.Controls.Add(lblSubtitulo);
        encabezado.Dock = DockStyle.Top;
        encabezado.Location = new Point(0, 0);
        encabezado.Name = "encabezado";
        encabezado.Size = new Size(1085, 88);
        encabezado.TabIndex = 0;
        // 
        // lblSubtitulo
        // 
        lblSubtitulo.Font = new Font("Segoe UI", 10F);
        lblSubtitulo.ForeColor = Color.FromArgb(243, 230, 236);
        lblSubtitulo.Location = new Point(25, 54);
        lblSubtitulo.Name = "lblSubtitulo";
        lblSubtitulo.Size = new Size(380, 24);
        lblSubtitulo.TabIndex = 1;
        lblSubtitulo.Text = "Reservas del estudio";
        // 
        // lblEdicion
        // 
        lblEdicion.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblEdicion.ForeColor = Color.FromArgb(56, 45, 55);
        lblEdicion.Location = new Point(24, 108);
        lblEdicion.Name = "lblEdicion";
        lblEdicion.Size = new Size(305, 31);
        lblEdicion.TabIndex = 1;
        lblEdicion.Text = "Nueva reserva";
        // 
        // lblNombre
        // 
        lblNombre.Font = new Font("Segoe UI", 10F);
        lblNombre.ForeColor = Color.FromArgb(90, 81, 87);
        lblNombre.Location = new Point(24, 149);
        lblNombre.Name = "lblNombre";
        lblNombre.Size = new Size(305, 21);
        lblNombre.TabIndex = 2;
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
        txtNombre.TabIndex = 3;
        // 
        // lblCorreo
        // 
        lblCorreo.Font = new Font("Segoe UI", 10F);
        lblCorreo.ForeColor = Color.FromArgb(90, 81, 87);
        lblCorreo.Location = new Point(24, 218);
        lblCorreo.Name = "lblCorreo";
        lblCorreo.Size = new Size(310, 22);
        lblCorreo.TabIndex = 4;
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
        txtCorreo.TabIndex = 5;
        // 
        // lblTipo
        // 
        lblTipo.Font = new Font("Segoe UI", 10F);
        lblTipo.ForeColor = Color.FromArgb(90, 81, 87);
        lblTipo.Location = new Point(24, 288);
        lblTipo.Name = "lblTipo";
        lblTipo.Size = new Size(295, 22);
        lblTipo.TabIndex = 6;
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
        cmbTipo.TabIndex = 7;
        // 
        // lblSala
        // 
        lblSala.Font = new Font("Segoe UI", 10F);
        lblSala.ForeColor = Color.FromArgb(90, 81, 87);
        lblSala.Location = new Point(24, 358);
        lblSala.Name = "lblSala";
        lblSala.Size = new Size(295, 22);
        lblSala.TabIndex = 8;
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
        cmbSala.TabIndex = 9;
        // 
        // lblFecha
        // 
        lblFecha.Font = new Font("Segoe UI", 10F);
        lblFecha.ForeColor = Color.FromArgb(90, 81, 87);
        lblFecha.Location = new Point(24, 430);
        lblFecha.Name = "lblFecha";
        lblFecha.Size = new Size(210, 22);
        lblFecha.TabIndex = 10;
        lblFecha.Text = "Fecha y hora";
        // 
        // dtpFecha
        // 
        dtpFecha.CustomFormat = "dd/MM/yyyy  HH:mm";
        dtpFecha.Format = DateTimePickerFormat.Custom;
        dtpFecha.Location = new Point(24, 455);
        dtpFecha.Name = "dtpFecha";
        dtpFecha.ShowUpDown = true;
        dtpFecha.Size = new Size(205, 25);
        dtpFecha.TabIndex = 11;
        // 
        // lblHoras
        // 
        lblHoras.Font = new Font("Segoe UI", 10F);
        lblHoras.ForeColor = Color.FromArgb(90, 81, 87);
        lblHoras.Location = new Point(245, 430);
        lblHoras.Name = "lblHoras";
        lblHoras.Size = new Size(85, 22);
        lblHoras.TabIndex = 12;
        lblHoras.Text = "Horas";
        // 
        // nudHoras
        // 
        nudHoras.Location = new Point(245, 455);
        nudHoras.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
        nudHoras.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        nudHoras.Name = "nudHoras";
        nudHoras.Size = new Size(84, 25);
        nudHoras.TabIndex = 13;
        nudHoras.Value = new decimal(new int[] { 1, 0, 0, 0 });
        // 
        // lblDetalle
        // 
        lblDetalle.Font = new Font("Segoe UI", 10F);
        lblDetalle.ForeColor = Color.FromArgb(90, 81, 87);
        lblDetalle.Location = new Point(24, 505);
        lblDetalle.Name = "lblDetalle";
        lblDetalle.Size = new Size(330, 23);
        lblDetalle.TabIndex = 14;
        // 
        // lblImporte
        // 
        lblImporte.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblImporte.ForeColor = Color.FromArgb(56, 45, 55);
        lblImporte.Location = new Point(24, 532);
        lblImporte.Name = "lblImporte";
        lblImporte.Size = new Size(330, 33);
        lblImporte.TabIndex = 15;
        // 
        // btnGuardar
        // 
        btnGuardar.BorderRadius = 6;
        btnGuardar.CustomizableEdges = customizableEdges27;
        btnGuardar.FillColor = Color.FromArgb(111, 68, 96);
        btnGuardar.Font = new Font("Segoe UI", 9F);
        btnGuardar.ForeColor = Color.White;
        btnGuardar.Location = new Point(24, 601);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.ShadowDecoration.CustomizableEdges = customizableEdges28;
        btnGuardar.Size = new Size(158, 36);
        btnGuardar.TabIndex = 16;
        btnGuardar.Text = "Registrar";
        // 
        // btnNuevo
        // 
        btnNuevo.BorderRadius = 6;
        btnNuevo.CustomizableEdges = customizableEdges29;
        btnNuevo.FillColor = Color.FromArgb(238, 232, 235);
        btnNuevo.Font = new Font("Segoe UI", 9F);
        btnNuevo.ForeColor = Color.FromArgb(82, 52, 70);
        btnNuevo.Location = new Point(192, 601);
        btnNuevo.Name = "btnNuevo";
        btnNuevo.ShadowDecoration.CustomizableEdges = customizableEdges30;
        btnNuevo.Size = new Size(137, 36);
        btnNuevo.TabIndex = 17;
        btnNuevo.Text = "Limpiar";
        // 
        // lblLista
        // 
        lblLista.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
        lblLista.ForeColor = Color.FromArgb(56, 45, 55);
        lblLista.Location = new Point(365, 108);
        lblLista.Name = "lblLista";
        lblLista.Size = new Size(400, 36);
        lblLista.TabIndex = 18;
        lblLista.Text = "Reservas registradas";
        // 
        // txtBuscar
        // 
        txtBuscar.BorderRadius = 6;
        txtBuscar.CustomizableEdges = customizableEdges31;
        txtBuscar.DefaultText = "";
        txtBuscar.Font = new Font("Segoe UI", 9F);
        txtBuscar.Location = new Point(470, 149);
        txtBuscar.Name = "txtBuscar";
        txtBuscar.PlaceholderText = "Buscar por nombre del cliente";
        txtBuscar.SelectedText = "";
        txtBuscar.ShadowDecoration.CustomizableEdges = customizableEdges32;
        txtBuscar.Size = new Size(320, 36);
        txtBuscar.TabIndex = 20;
        // 
        // lblBuscar
        // 
        lblBuscar.ForeColor = Color.FromArgb(90, 81, 87);
        lblBuscar.Location = new Point(365, 157);
        lblBuscar.Name = "lblBuscar";
        lblBuscar.Size = new Size(100, 25);
        lblBuscar.TabIndex = 19;
        lblBuscar.Text = "Buscar cliente";
        // 
        // dgvTabla
        // 
        dgvTabla.AllowUserToAddRows = false;
        dgvTabla.AllowUserToDeleteRows = false;
        dataGridViewCellStyle4.BackColor = Color.FromArgb(251, 248, 250);
        dgvTabla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
        dgvTabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvTabla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
        dgvTabla.BackgroundColor = Color.White;
        dgvTabla.BorderStyle = BorderStyle.None;
        dgvTabla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        dgvTabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle5.BackColor = Color.FromArgb(237, 231, 234);
        dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F);
        dataGridViewCellStyle5.ForeColor = Color.FromArgb(72, 49, 64);
        dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(237, 231, 234);
        dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(72, 49, 64);
        dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
        dgvTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
        dgvTabla.ColumnHeadersHeight = 37;
        dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle6.BackColor = SystemColors.Window;
        dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
        dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(234, 218, 229);
        dataGridViewCellStyle6.SelectionForeColor = Color.Black;
        dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
        dgvTabla.DefaultCellStyle = dataGridViewCellStyle6;
        dgvTabla.EnableHeadersVisualStyles = false;
        dgvTabla.GridColor = Color.FromArgb(230, 223, 227);
        dgvTabla.Location = new Point(365, 204);
        dgvTabla.MultiSelect = false;
        dgvTabla.Name = "dgvTabla";
        dgvTabla.ReadOnly = true;
        dgvTabla.RowHeadersVisible = false;
        dgvTabla.RowTemplate.Height = 35;
        dgvTabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvTabla.Size = new Size(696, 347);
        dgvTabla.TabIndex = 21;
        // 
        // lblResumen
        // 
        lblResumen.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblResumen.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblResumen.ForeColor = Color.FromArgb(56, 45, 55);
        lblResumen.Location = new Point(365, 563);
        lblResumen.Name = "lblResumen";
        lblResumen.Size = new Size(666, 28);
        lblResumen.TabIndex = 22;
        // 
        // btnEditar
        // 
        btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnEditar.BorderRadius = 6;
        btnEditar.CustomizableEdges = customizableEdges33;
        btnEditar.FillColor = Color.FromArgb(238, 232, 235);
        btnEditar.Font = new Font("Segoe UI", 9F);
        btnEditar.ForeColor = Color.FromArgb(82, 52, 70);
        btnEditar.Location = new Point(365, 601);
        btnEditar.Name = "btnEditar";
        btnEditar.ShadowDecoration.CustomizableEdges = customizableEdges34;
        btnEditar.Size = new Size(120, 36);
        btnEditar.TabIndex = 23;
        btnEditar.Text = "Editar";
        // 
        // btnEliminar
        // 
        btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnEliminar.BorderRadius = 6;
        btnEliminar.CustomizableEdges = customizableEdges35;
        btnEliminar.FillColor = Color.FromArgb(249, 235, 232);
        btnEliminar.Font = new Font("Segoe UI", 9F);
        btnEliminar.ForeColor = Color.FromArgb(139, 55, 53);
        btnEliminar.Location = new Point(495, 601);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.ShadowDecoration.CustomizableEdges = customizableEdges36;
        btnEliminar.Size = new Size(120, 36);
        btnEliminar.TabIndex = 24;
        btnEliminar.Text = "Eliminar";
        // 
        // FrmReservas
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(251, 249, 247);
        ClientSize = new Size(1085, 666);
        Controls.Add(encabezado);
        Controls.Add(lblEdicion);
        Controls.Add(lblNombre);
        Controls.Add(txtNombre);
        Controls.Add(lblCorreo);
        Controls.Add(txtCorreo);
        Controls.Add(lblTipo);
        Controls.Add(cmbTipo);
        Controls.Add(lblSala);
        Controls.Add(cmbSala);
        Controls.Add(lblFecha);
        Controls.Add(dtpFecha);
        Controls.Add(lblHoras);
        Controls.Add(nudHoras);
        Controls.Add(lblDetalle);
        Controls.Add(lblImporte);
        Controls.Add(btnGuardar);
        Controls.Add(btnNuevo);
        Controls.Add(lblLista);
        Controls.Add(lblBuscar);
        Controls.Add(txtBuscar);
        Controls.Add(dgvTabla);
        Controls.Add(lblResumen);
        Controls.Add(btnEditar);
        Controls.Add(btnEliminar);
        Font = new Font("Segoe UI", 10F);
        MinimumSize = new Size(1030, 705);
        Name = "FrmReservas";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Creative Studio";
        ((System.ComponentModel.ISupportInitialize)errores).EndInit();
        encabezado.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)nudHoras).EndInit();
        ((System.ComponentModel.ISupportInitialize)dgvTabla).EndInit();
        ResumeLayout(false);
    }
}
