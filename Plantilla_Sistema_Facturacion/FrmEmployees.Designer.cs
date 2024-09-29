namespace Plantilla_Sistema_Facturacion
{
    partial class FrmEmployees
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            btnRecharge = new MaterialSkin.Controls.MaterialButton();
            btnSearch = new MaterialSkin.Controls.MaterialButton();
            dgvEmpleados = new DataGridView();
            txtFindEmpleado = new MaterialSkin.Controls.MaterialTextBox2();
            groupBox1 = new GroupBox();
            btnModificar = new MaterialSkin.Controls.MaterialButton();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            dtFechaRetiro = new DateTimePicker();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            dtFechaInicio = new DateTimePicker();
            btnSalir = new MaterialSkin.Controls.MaterialButton();
            btnAgregar = new MaterialSkin.Controls.MaterialButton();
            txtDetalles = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            cbRolEmpleado = new MaterialSkin.Controls.MaterialComboBox();
            txtNomEmpleado = new MaterialSkin.Controls.MaterialTextBox2();
            txtDocEmpleado = new MaterialSkin.Controls.MaterialTextBox2();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            txtTelefono = new MaterialSkin.Controls.MaterialTextBox2();
            txtDireccion = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRecharge);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(dgvEmpleados);
            groupBox2.Controls.Add(txtFindEmpleado);
            groupBox2.Location = new Point(6, 335);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(858, 257);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // btnRecharge
            // 
            btnRecharge.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRecharge.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRecharge.Depth = 0;
            btnRecharge.HighEmphasis = true;
            btnRecharge.Icon = null;
            btnRecharge.Location = new Point(701, 25);
            btnRecharge.Margin = new Padding(4, 6, 4, 6);
            btnRecharge.MouseState = MaterialSkin.MouseState.HOVER;
            btnRecharge.Name = "btnRecharge";
            btnRecharge.NoAccentTextColor = Color.Empty;
            btnRecharge.Size = new Size(96, 36);
            btnRecharge.TabIndex = 5;
            btnRecharge.Text = "Recargar";
            btnRecharge.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRecharge.UseAccentColor = false;
            btnRecharge.UseVisualStyleBackColor = true;
            btnRecharge.Click += btnRecharge_Click;
            // 
            // btnSearch
            // 
            btnSearch.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSearch.Depth = 0;
            btnSearch.HighEmphasis = true;
            btnSearch.Icon = null;
            btnSearch.Location = new Point(575, 25);
            btnSearch.Margin = new Padding(4, 6, 4, 6);
            btnSearch.MouseState = MaterialSkin.MouseState.HOVER;
            btnSearch.Name = "btnSearch";
            btnSearch.NoAccentTextColor = Color.Empty;
            btnSearch.Size = new Size(77, 36);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Buscar";
            btnSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSearch.UseAccentColor = false;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(18, 100);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.Size = new Size(817, 118);
            dgvEmpleados.TabIndex = 3;
            // 
            // txtFindEmpleado
            // 
            txtFindEmpleado.AnimateReadOnly = false;
            txtFindEmpleado.BackgroundImageLayout = ImageLayout.None;
            txtFindEmpleado.CharacterCasing = CharacterCasing.Normal;
            txtFindEmpleado.Depth = 0;
            txtFindEmpleado.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFindEmpleado.HideSelection = true;
            txtFindEmpleado.Hint = "Buscar Empleado";
            txtFindEmpleado.LeadingIcon = null;
            txtFindEmpleado.Location = new Point(32, 22);
            txtFindEmpleado.MaxLength = 32767;
            txtFindEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            txtFindEmpleado.Name = "txtFindEmpleado";
            txtFindEmpleado.PasswordChar = '\0';
            txtFindEmpleado.PrefixSuffixText = null;
            txtFindEmpleado.ReadOnly = false;
            txtFindEmpleado.RightToLeft = RightToLeft.No;
            txtFindEmpleado.SelectedText = "";
            txtFindEmpleado.SelectionLength = 0;
            txtFindEmpleado.SelectionStart = 0;
            txtFindEmpleado.ShortcutsEnabled = true;
            txtFindEmpleado.Size = new Size(520, 48);
            txtFindEmpleado.TabIndex = 2;
            txtFindEmpleado.TabStop = false;
            txtFindEmpleado.TextAlign = HorizontalAlignment.Left;
            txtFindEmpleado.TrailingIcon = null;
            txtFindEmpleado.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(materialLabel2);
            groupBox1.Controls.Add(dtFechaRetiro);
            groupBox1.Controls.Add(materialLabel3);
            groupBox1.Controls.Add(dtFechaInicio);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtDetalles);
            groupBox1.Controls.Add(cbRolEmpleado);
            groupBox1.Controls.Add(txtNomEmpleado);
            groupBox1.Controls.Add(txtDocEmpleado);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(txtDireccion);
            groupBox1.Location = new Point(6, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(858, 299);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // btnModificar
            // 
            btnModificar.AutoSize = false;
            btnModificar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnModificar.Depth = 0;
            btnModificar.HighEmphasis = true;
            btnModificar.Icon = null;
            btnModificar.Location = new Point(747, 179);
            btnModificar.Margin = new Padding(4, 6, 4, 6);
            btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            btnModificar.Name = "btnModificar";
            btnModificar.NoAccentTextColor = Color.Empty;
            btnModificar.Size = new Size(88, 36);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "Modificar";
            btnModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnModificar.UseAccentColor = false;
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Visible = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = false;
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(747, 227);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(88, 36);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(739, 76);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(83, 19);
            materialLabel2.TabIndex = 18;
            materialLabel2.Text = "Fecha Final";
            // 
            // dtFechaRetiro
            // 
            dtFechaRetiro.Format = DateTimePickerFormat.Short;
            dtFechaRetiro.Location = new Point(741, 102);
            dtFechaRetiro.Name = "dtFechaRetiro";
            dtFechaRetiro.Size = new Size(106, 23);
            dtFechaRetiro.TabIndex = 17;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(601, 76);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(86, 19);
            materialLabel3.TabIndex = 16;
            materialLabel3.Text = "Fecha Inicio";
            // 
            // dtFechaInicio
            // 
            dtFechaInicio.Format = DateTimePickerFormat.Short;
            dtFechaInicio.Location = new Point(603, 102);
            dtFechaInicio.Name = "dtFechaInicio";
            dtFechaInicio.Size = new Size(106, 23);
            dtFechaInicio.TabIndex = 15;
            // 
            // btnSalir
            // 
            btnSalir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalir.Depth = 0;
            btnSalir.HighEmphasis = true;
            btnSalir.Icon = null;
            btnSalir.Location = new Point(640, 233);
            btnSalir.Margin = new Padding(4, 6, 4, 6);
            btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            btnSalir.Name = "btnSalir";
            btnSalir.NoAccentTextColor = Color.Empty;
            btnSalir.Size = new Size(64, 36);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalir.UseAccentColor = false;
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregar.Depth = 0;
            btnAgregar.HighEmphasis = true;
            btnAgregar.Icon = null;
            btnAgregar.Location = new Point(640, 179);
            btnAgregar.Margin = new Padding(4, 6, 4, 6);
            btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            btnAgregar.Name = "btnAgregar";
            btnAgregar.NoAccentTextColor = Color.Empty;
            btnAgregar.Size = new Size(88, 36);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAgregar.UseAccentColor = false;
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtDetalles
            // 
            txtDetalles.AnimateReadOnly = false;
            txtDetalles.BackgroundImageLayout = ImageLayout.None;
            txtDetalles.CharacterCasing = CharacterCasing.Normal;
            txtDetalles.Depth = 0;
            txtDetalles.HideSelection = true;
            txtDetalles.Hint = "Detalles Adicionales";
            txtDetalles.Location = new Point(332, 125);
            txtDetalles.MaxLength = 32767;
            txtDetalles.MouseState = MaterialSkin.MouseState.OUT;
            txtDetalles.Name = "txtDetalles";
            txtDetalles.PasswordChar = '\0';
            txtDetalles.ReadOnly = false;
            txtDetalles.ScrollBars = ScrollBars.None;
            txtDetalles.SelectedText = "";
            txtDetalles.SelectionLength = 0;
            txtDetalles.SelectionStart = 0;
            txtDetalles.ShortcutsEnabled = true;
            txtDetalles.Size = new Size(250, 156);
            txtDetalles.TabIndex = 9;
            txtDetalles.TabStop = false;
            txtDetalles.TextAlign = HorizontalAlignment.Left;
            txtDetalles.UseSystemPasswordChar = false;
            // 
            // cbRolEmpleado
            // 
            cbRolEmpleado.AutoResize = false;
            cbRolEmpleado.BackColor = Color.FromArgb(255, 255, 255);
            cbRolEmpleado.Depth = 0;
            cbRolEmpleado.DrawMode = DrawMode.OwnerDrawVariable;
            cbRolEmpleado.DropDownHeight = 174;
            cbRolEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRolEmpleado.DropDownWidth = 121;
            cbRolEmpleado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbRolEmpleado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbRolEmpleado.FormattingEnabled = true;
            cbRolEmpleado.Hint = "Rol de Empleado";
            cbRolEmpleado.IntegralHeight = false;
            cbRolEmpleado.ItemHeight = 43;
            cbRolEmpleado.Location = new Point(332, 21);
            cbRolEmpleado.MaxDropDownItems = 4;
            cbRolEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            cbRolEmpleado.Name = "cbRolEmpleado";
            cbRolEmpleado.Size = new Size(175, 49);
            cbRolEmpleado.StartIndex = 0;
            cbRolEmpleado.TabIndex = 6;
            // 
            // txtNomEmpleado
            // 
            txtNomEmpleado.AnimateReadOnly = false;
            txtNomEmpleado.BackgroundImageLayout = ImageLayout.None;
            txtNomEmpleado.CharacterCasing = CharacterCasing.Normal;
            txtNomEmpleado.Depth = 0;
            txtNomEmpleado.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNomEmpleado.HideSelection = true;
            txtNomEmpleado.Hint = "Nombre Empleado";
            txtNomEmpleado.LeadingIcon = null;
            txtNomEmpleado.Location = new Point(18, 22);
            txtNomEmpleado.MaxLength = 32767;
            txtNomEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            txtNomEmpleado.Name = "txtNomEmpleado";
            txtNomEmpleado.PasswordChar = '\0';
            txtNomEmpleado.PrefixSuffixText = null;
            txtNomEmpleado.ReadOnly = false;
            txtNomEmpleado.RightToLeft = RightToLeft.No;
            txtNomEmpleado.SelectedText = "";
            txtNomEmpleado.SelectionLength = 0;
            txtNomEmpleado.SelectionStart = 0;
            txtNomEmpleado.ShortcutsEnabled = true;
            txtNomEmpleado.Size = new Size(250, 48);
            txtNomEmpleado.TabIndex = 0;
            txtNomEmpleado.TabStop = false;
            txtNomEmpleado.TextAlign = HorizontalAlignment.Left;
            txtNomEmpleado.TrailingIcon = null;
            txtNomEmpleado.UseSystemPasswordChar = false;
            // 
            // txtDocEmpleado
            // 
            txtDocEmpleado.AnimateReadOnly = false;
            txtDocEmpleado.BackgroundImageLayout = ImageLayout.None;
            txtDocEmpleado.CharacterCasing = CharacterCasing.Normal;
            txtDocEmpleado.Depth = 0;
            txtDocEmpleado.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDocEmpleado.HideSelection = true;
            txtDocEmpleado.Hint = "Documento";
            txtDocEmpleado.LeadingIcon = null;
            txtDocEmpleado.Location = new Point(18, 76);
            txtDocEmpleado.MaxLength = 32767;
            txtDocEmpleado.MouseState = MaterialSkin.MouseState.OUT;
            txtDocEmpleado.Name = "txtDocEmpleado";
            txtDocEmpleado.PasswordChar = '\0';
            txtDocEmpleado.PrefixSuffixText = null;
            txtDocEmpleado.ReadOnly = false;
            txtDocEmpleado.RightToLeft = RightToLeft.No;
            txtDocEmpleado.SelectedText = "";
            txtDocEmpleado.SelectionLength = 0;
            txtDocEmpleado.SelectionStart = 0;
            txtDocEmpleado.ShortcutsEnabled = true;
            txtDocEmpleado.Size = new Size(250, 48);
            txtDocEmpleado.TabIndex = 1;
            txtDocEmpleado.TabStop = false;
            txtDocEmpleado.TextAlign = HorizontalAlignment.Left;
            txtDocEmpleado.TrailingIcon = null;
            txtDocEmpleado.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "E-mail";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(18, 233);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(250, 48);
            txtEmail.TabIndex = 5;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            txtTelefono.AnimateReadOnly = false;
            txtTelefono.BackgroundImageLayout = ImageLayout.None;
            txtTelefono.CharacterCasing = CharacterCasing.Normal;
            txtTelefono.Depth = 0;
            txtTelefono.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefono.HideSelection = true;
            txtTelefono.Hint = "Telefono";
            txtTelefono.LeadingIcon = null;
            txtTelefono.Location = new Point(18, 179);
            txtTelefono.MaxLength = 32767;
            txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PasswordChar = '\0';
            txtTelefono.PrefixSuffixText = null;
            txtTelefono.ReadOnly = false;
            txtTelefono.RightToLeft = RightToLeft.No;
            txtTelefono.SelectedText = "";
            txtTelefono.SelectionLength = 0;
            txtTelefono.SelectionStart = 0;
            txtTelefono.ShortcutsEnabled = true;
            txtTelefono.Size = new Size(250, 48);
            txtTelefono.TabIndex = 2;
            txtTelefono.TabStop = false;
            txtTelefono.TextAlign = HorizontalAlignment.Left;
            txtTelefono.TrailingIcon = null;
            txtTelefono.UseSystemPasswordChar = false;
            // 
            // txtDireccion
            // 
            txtDireccion.AnimateReadOnly = false;
            txtDireccion.BackgroundImageLayout = ImageLayout.None;
            txtDireccion.CharacterCasing = CharacterCasing.Normal;
            txtDireccion.Depth = 0;
            txtDireccion.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDireccion.HideSelection = true;
            txtDireccion.Hint = "Direccion";
            txtDireccion.LeadingIcon = null;
            txtDireccion.Location = new Point(18, 125);
            txtDireccion.MaxLength = 32767;
            txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.PasswordChar = '\0';
            txtDireccion.PrefixSuffixText = null;
            txtDireccion.ReadOnly = false;
            txtDireccion.RightToLeft = RightToLeft.No;
            txtDireccion.SelectedText = "";
            txtDireccion.SelectionLength = 0;
            txtDireccion.SelectionStart = 0;
            txtDireccion.ShortcutsEnabled = true;
            txtDireccion.Size = new Size(250, 48);
            txtDireccion.TabIndex = 3;
            txtDireccion.TabStop = false;
            txtDireccion.TextAlign = HorizontalAlignment.Left;
            txtDireccion.TrailingIcon = null;
            txtDireccion.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(353, 8);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(212, 19);
            materialLabel1.TabIndex = 9;
            materialLabel1.Text = "Administracion de Empleados";
            // 
            // FrmEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 633);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(materialLabel1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "FrmEmployees";
            Padding = new Padding(3, 0, 3, 3);
            Text = "FrmEmployees";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton btnRecharge;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private DataGridView dgvEmpleados;
        private MaterialSkin.Controls.MaterialTextBox2 txtFindEmpleado;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDetalles;
        private MaterialSkin.Controls.MaterialComboBox cbRolEmpleado;
        private MaterialSkin.Controls.MaterialTextBox2 txtNomEmpleado;
        private MaterialSkin.Controls.MaterialTextBox2 txtDocEmpleado;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox2 txtDireccion;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private DateTimePicker dtFechaRetiro;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private DateTimePicker dtFechaInicio;
        private MaterialSkin.Controls.MaterialButton btnModificar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
    }
}