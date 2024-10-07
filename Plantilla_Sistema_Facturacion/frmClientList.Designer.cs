namespace Plantilla_Sistema_Facturacion
{
    partial class frmClient
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
            groupBox1 = new GroupBox();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            btnModificar = new MaterialSkin.Controls.MaterialButton();
            btnExit = new MaterialSkin.Controls.MaterialButton();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            txtClientName = new MaterialSkin.Controls.MaterialTextBox2();
            btnCreateClient = new MaterialSkin.Controls.MaterialButton();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            txtTelNum = new MaterialSkin.Controls.MaterialTextBox2();
            txtAddress = new MaterialSkin.Controls.MaterialTextBox2();
            txtClientId = new MaterialSkin.Controls.MaterialTextBox2();
            groupBox2 = new GroupBox();
            btnRecharge = new MaterialSkin.Controls.MaterialButton();
            btnSearch = new MaterialSkin.Controls.MaterialButton();
            dgvClientList = new DataGridView();
            txtFindClient = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientList).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(txtClientName);
            groupBox1.Controls.Add(btnCreateClient);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTelNum);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtClientId);
            groupBox1.Location = new Point(6, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(785, 332);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = false;
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.ForeColor = SystemColors.ControlDark;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(602, 192);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(97, 36);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnModificar
            // 
            btnModificar.AutoSize = false;
            btnModificar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnModificar.Depth = 0;
            btnModificar.ForeColor = SystemColors.ControlDark;
            btnModificar.HighEmphasis = true;
            btnModificar.Icon = null;
            btnModificar.Location = new Point(602, 128);
            btnModificar.Margin = new Padding(4, 6, 4, 6);
            btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            btnModificar.Name = "btnModificar";
            btnModificar.NoAccentTextColor = Color.Empty;
            btnModificar.Size = new Size(97, 36);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "MODIFICAR";
            btnModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnModificar.UseAccentColor = false;
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Visible = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnExit
            // 
            btnExit.AutoSize = false;
            btnExit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExit.Depth = 0;
            btnExit.ForeColor = SystemColors.ControlDark;
            btnExit.HighEmphasis = true;
            btnExit.Icon = null;
            btnExit.Location = new Point(602, 258);
            btnExit.Margin = new Padding(4, 6, 4, 6);
            btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            btnExit.Name = "btnExit";
            btnExit.NoAccentTextColor = Color.Empty;
            btnExit.Size = new Size(94, 36);
            btnExit.TabIndex = 5;
            btnExit.Text = "Salir";
            btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExit.UseAccentColor = false;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.AutoSize = false;
            btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnClear.Depth = 0;
            btnClear.ForeColor = SystemColors.ControlDark;
            btnClear.HighEmphasis = true;
            btnClear.Icon = null;
            btnClear.Location = new Point(602, 70);
            btnClear.Margin = new Padding(4, 6, 4, 6);
            btnClear.MouseState = MaterialSkin.MouseState.HOVER;
            btnClear.Name = "btnClear";
            btnClear.NoAccentTextColor = Color.Empty;
            btnClear.Size = new Size(97, 36);
            btnClear.TabIndex = 6;
            btnClear.Text = "Limpiar";
            btnClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnClear.UseAccentColor = false;
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtClientName
            // 
            txtClientName.AnimateReadOnly = false;
            txtClientName.BackgroundImageLayout = ImageLayout.None;
            txtClientName.CharacterCasing = CharacterCasing.Normal;
            txtClientName.Depth = 0;
            txtClientName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtClientName.HideSelection = true;
            txtClientName.Hint = "Nombre Cliente";
            txtClientName.LeadingIcon = null;
            txtClientName.Location = new Point(58, 22);
            txtClientName.MaxLength = 32767;
            txtClientName.MouseState = MaterialSkin.MouseState.OUT;
            txtClientName.Name = "txtClientName";
            txtClientName.PasswordChar = '\0';
            txtClientName.PrefixSuffixText = null;
            txtClientName.ReadOnly = false;
            txtClientName.RightToLeft = RightToLeft.No;
            txtClientName.SelectedText = "";
            txtClientName.SelectionLength = 0;
            txtClientName.SelectionStart = 0;
            txtClientName.ShortcutsEnabled = true;
            txtClientName.Size = new Size(520, 48);
            txtClientName.TabIndex = 5;
            txtClientName.TabStop = false;
            txtClientName.TextAlign = HorizontalAlignment.Left;
            txtClientName.TrailingIcon = null;
            txtClientName.UseSystemPasswordChar = false;
            // 
            // btnCreateClient
            // 
            btnCreateClient.AutoSize = false;
            btnCreateClient.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCreateClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCreateClient.Depth = 0;
            btnCreateClient.ForeColor = SystemColors.ControlDark;
            btnCreateClient.HighEmphasis = true;
            btnCreateClient.Icon = null;
            btnCreateClient.Location = new Point(602, 22);
            btnCreateClient.Margin = new Padding(4, 6, 4, 6);
            btnCreateClient.MouseState = MaterialSkin.MouseState.HOVER;
            btnCreateClient.Name = "btnCreateClient";
            btnCreateClient.NoAccentTextColor = Color.Empty;
            btnCreateClient.Size = new Size(97, 36);
            btnCreateClient.TabIndex = 3;
            btnCreateClient.Text = "Agregar";
            btnCreateClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCreateClient.UseAccentColor = false;
            btnCreateClient.UseVisualStyleBackColor = true;
            btnCreateClient.Click += btnCreateClient_Click;
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
            txtEmail.Location = new Point(58, 234);
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
            txtEmail.Size = new Size(520, 48);
            txtEmail.TabIndex = 4;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtTelNum
            // 
            txtTelNum.AnimateReadOnly = false;
            txtTelNum.BackgroundImageLayout = ImageLayout.None;
            txtTelNum.CharacterCasing = CharacterCasing.Normal;
            txtTelNum.Depth = 0;
            txtTelNum.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelNum.HideSelection = true;
            txtTelNum.Hint = "Telefono";
            txtTelNum.LeadingIcon = null;
            txtTelNum.Location = new Point(58, 180);
            txtTelNum.MaxLength = 32767;
            txtTelNum.MouseState = MaterialSkin.MouseState.OUT;
            txtTelNum.Name = "txtTelNum";
            txtTelNum.PasswordChar = '\0';
            txtTelNum.PrefixSuffixText = null;
            txtTelNum.ReadOnly = false;
            txtTelNum.RightToLeft = RightToLeft.No;
            txtTelNum.SelectedText = "";
            txtTelNum.SelectionLength = 0;
            txtTelNum.SelectionStart = 0;
            txtTelNum.ShortcutsEnabled = true;
            txtTelNum.Size = new Size(250, 48);
            txtTelNum.TabIndex = 3;
            txtTelNum.TabStop = false;
            txtTelNum.TextAlign = HorizontalAlignment.Left;
            txtTelNum.TrailingIcon = null;
            txtTelNum.UseSystemPasswordChar = false;
            // 
            // txtAddress
            // 
            txtAddress.AnimateReadOnly = false;
            txtAddress.BackgroundImageLayout = ImageLayout.None;
            txtAddress.CharacterCasing = CharacterCasing.Normal;
            txtAddress.Depth = 0;
            txtAddress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddress.HideSelection = true;
            txtAddress.Hint = "Direccion";
            txtAddress.LeadingIcon = null;
            txtAddress.Location = new Point(58, 128);
            txtAddress.Margin = new Padding(1);
            txtAddress.MaxLength = 32767;
            txtAddress.MouseState = MaterialSkin.MouseState.OUT;
            txtAddress.Name = "txtAddress";
            txtAddress.PasswordChar = '\0';
            txtAddress.PrefixSuffixText = null;
            txtAddress.ReadOnly = false;
            txtAddress.RightToLeft = RightToLeft.No;
            txtAddress.SelectedText = "";
            txtAddress.SelectionLength = 0;
            txtAddress.SelectionStart = 0;
            txtAddress.ShortcutsEnabled = true;
            txtAddress.Size = new Size(520, 48);
            txtAddress.TabIndex = 1;
            txtAddress.TabStop = false;
            txtAddress.TextAlign = HorizontalAlignment.Left;
            txtAddress.TrailingIcon = null;
            txtAddress.UseSystemPasswordChar = false;
            // 
            // txtClientId
            // 
            txtClientId.AnimateReadOnly = false;
            txtClientId.BackgroundImageLayout = ImageLayout.None;
            txtClientId.CharacterCasing = CharacterCasing.Normal;
            txtClientId.Depth = 0;
            txtClientId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtClientId.HideSelection = true;
            txtClientId.Hint = "Documento";
            txtClientId.LeadingIcon = null;
            txtClientId.Location = new Point(58, 76);
            txtClientId.MaxLength = 32767;
            txtClientId.MouseState = MaterialSkin.MouseState.OUT;
            txtClientId.Name = "txtClientId";
            txtClientId.PasswordChar = '\0';
            txtClientId.PrefixSuffixText = null;
            txtClientId.ReadOnly = false;
            txtClientId.RightToLeft = RightToLeft.No;
            txtClientId.SelectedText = "";
            txtClientId.SelectionLength = 0;
            txtClientId.SelectionStart = 0;
            txtClientId.ShortcutsEnabled = true;
            txtClientId.Size = new Size(250, 48);
            txtClientId.TabIndex = 0;
            txtClientId.TabStop = false;
            txtClientId.TextAlign = HorizontalAlignment.Left;
            txtClientId.TrailingIcon = null;
            txtClientId.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRecharge);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(dgvClientList);
            groupBox2.Controls.Add(txtFindClient);
            groupBox2.Location = new Point(6, 370);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(785, 215);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // btnRecharge
            // 
            btnRecharge.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRecharge.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRecharge.Depth = 0;
            btnRecharge.HighEmphasis = true;
            btnRecharge.Icon = null;
            btnRecharge.Location = new Point(471, 34);
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
            btnSearch.Location = new Point(376, 34);
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
            // dgvClientList
            // 
            dgvClientList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientList.Location = new Point(32, 79);
            dgvClientList.Name = "dgvClientList";
            dgvClientList.Size = new Size(667, 118);
            dgvClientList.TabIndex = 3;
            // 
            // txtFindClient
            // 
            txtFindClient.AnimateReadOnly = false;
            txtFindClient.BackgroundImageLayout = ImageLayout.None;
            txtFindClient.CharacterCasing = CharacterCasing.Normal;
            txtFindClient.Depth = 0;
            txtFindClient.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFindClient.HideSelection = true;
            txtFindClient.Hint = "Buscar Cliente";
            txtFindClient.LeadingIcon = null;
            txtFindClient.Location = new Point(32, 22);
            txtFindClient.MaxLength = 32767;
            txtFindClient.MouseState = MaterialSkin.MouseState.OUT;
            txtFindClient.Name = "txtFindClient";
            txtFindClient.PasswordChar = '\0';
            txtFindClient.PrefixSuffixText = null;
            txtFindClient.ReadOnly = false;
            txtFindClient.RightToLeft = RightToLeft.No;
            txtFindClient.SelectedText = "";
            txtFindClient.SelectionLength = 0;
            txtFindClient.SelectionStart = 0;
            txtFindClient.ShortcutsEnabled = true;
            txtFindClient.Size = new Size(276, 48);
            txtFindClient.TabIndex = 2;
            txtFindClient.TabStop = false;
            txtFindClient.TextAlign = HorizontalAlignment.Left;
            txtFindClient.TrailingIcon = null;
            txtFindClient.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(281, 10);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(189, 19);
            materialLabel1.TabIndex = 2;
            materialLabel1.Text = "Administracion de Clientes";
            // 
            // frmClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(794, 585);
            Controls.Add(materialLabel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "frmClient";
            Padding = new Padding(3, 0, 3, 3);
            Text = "frmClientList";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialTextBox2 txtClientName;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelNum;
        private MaterialSkin.Controls.MaterialTextBox2 txtAddress;
        private MaterialSkin.Controls.MaterialTextBox2 txtClientId;
        private MaterialSkin.Controls.MaterialTextBox2 txtFindClient;
        private DataGridView dgvClientList;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private MaterialSkin.Controls.MaterialButton btnCreateClient;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private MaterialSkin.Controls.MaterialButton btnRecharge;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnModificar;
    }
}