namespace Plantilla_Sistema_Facturacion
{
    partial class FrmSistemUsers
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
            cbEmployees = new MaterialSkin.Controls.MaterialComboBox();
            txtboxUser = new MaterialSkin.Controls.MaterialTextBox2();
            txtboxPass = new MaterialSkin.Controls.MaterialTextBox2();
            panel1 = new Panel();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            btnAddUser = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            dgvEmployee = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // cbEmployees
            // 
            cbEmployees.AutoResize = false;
            cbEmployees.BackColor = Color.FromArgb(255, 255, 255);
            cbEmployees.Depth = 0;
            cbEmployees.DrawMode = DrawMode.OwnerDrawVariable;
            cbEmployees.DropDownHeight = 174;
            cbEmployees.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEmployees.DropDownWidth = 121;
            cbEmployees.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbEmployees.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbEmployees.FormattingEnabled = true;
            cbEmployees.Hint = "Empleado";
            cbEmployees.IntegralHeight = false;
            cbEmployees.ItemHeight = 43;
            cbEmployees.Location = new Point(188, 28);
            cbEmployees.MaxDropDownItems = 4;
            cbEmployees.MouseState = MaterialSkin.MouseState.OUT;
            cbEmployees.Name = "cbEmployees";
            cbEmployees.Size = new Size(398, 49);
            cbEmployees.StartIndex = 0;
            cbEmployees.TabIndex = 0;
            cbEmployees.SelectedIndexChanged += cbEmployees_SelectedIndexChanged;
            // 
            // txtboxUser
            // 
            txtboxUser.AnimateReadOnly = false;
            txtboxUser.BackgroundImageLayout = ImageLayout.None;
            txtboxUser.CharacterCasing = CharacterCasing.Normal;
            txtboxUser.Depth = 0;
            txtboxUser.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtboxUser.HideSelection = true;
            txtboxUser.Hint = "Usuario";
            txtboxUser.LeadingIcon = null;
            txtboxUser.Location = new Point(260, 83);
            txtboxUser.MaxLength = 32767;
            txtboxUser.MouseState = MaterialSkin.MouseState.OUT;
            txtboxUser.Name = "txtboxUser";
            txtboxUser.PasswordChar = '\0';
            txtboxUser.PrefixSuffixText = null;
            txtboxUser.ReadOnly = false;
            txtboxUser.RightToLeft = RightToLeft.No;
            txtboxUser.SelectedText = "";
            txtboxUser.SelectionLength = 0;
            txtboxUser.SelectionStart = 0;
            txtboxUser.ShortcutsEnabled = true;
            txtboxUser.Size = new Size(250, 48);
            txtboxUser.TabIndex = 1;
            txtboxUser.TabStop = false;
            txtboxUser.TextAlign = HorizontalAlignment.Left;
            txtboxUser.TrailingIcon = null;
            txtboxUser.UseSystemPasswordChar = false;
            // 
            // txtboxPass
            // 
            txtboxPass.AnimateReadOnly = false;
            txtboxPass.BackgroundImageLayout = ImageLayout.None;
            txtboxPass.CharacterCasing = CharacterCasing.Normal;
            txtboxPass.Depth = 0;
            txtboxPass.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtboxPass.HideSelection = true;
            txtboxPass.Hint = "Password";
            txtboxPass.LeadingIcon = null;
            txtboxPass.Location = new Point(260, 137);
            txtboxPass.MaxLength = 32767;
            txtboxPass.MouseState = MaterialSkin.MouseState.OUT;
            txtboxPass.Name = "txtboxPass";
            txtboxPass.PasswordChar = '*';
            txtboxPass.PrefixSuffixText = null;
            txtboxPass.ReadOnly = false;
            txtboxPass.RightToLeft = RightToLeft.No;
            txtboxPass.SelectedText = "";
            txtboxPass.SelectionLength = 0;
            txtboxPass.SelectionStart = 0;
            txtboxPass.ShortcutsEnabled = true;
            txtboxPass.Size = new Size(250, 48);
            txtboxPass.TabIndex = 2;
            txtboxPass.TabStop = false;
            txtboxPass.TextAlign = HorizontalAlignment.Left;
            txtboxPass.TrailingIcon = null;
            txtboxPass.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(materialButton2);
            panel1.Controls.Add(btnAddUser);
            panel1.Controls.Add(txtboxUser);
            panel1.Controls.Add(txtboxPass);
            panel1.Controls.Add(cbEmployees);
            panel1.Location = new Point(6, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(788, 217);
            panel1.TabIndex = 3;
            // 
            // materialButton2
            // 
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(667, 160);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(75, 36);
            materialButton2.TabIndex = 4;
            materialButton2.Text = "Salir";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            btnAddUser.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddUser.Depth = 0;
            btnAddUser.HighEmphasis = true;
            btnAddUser.Icon = null;
            btnAddUser.Location = new Point(667, 41);
            btnAddUser.Margin = new Padding(4, 6, 4, 6);
            btnAddUser.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddUser.Name = "btnAddUser";
            btnAddUser.NoAccentTextColor = Color.Empty;
            btnAddUser.Size = new Size(88, 36);
            btnAddUser.TabIndex = 3;
            btnAddUser.Text = "Agregar";
            btnAddUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddUser.UseAccentColor = false;
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(278, 16);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(275, 19);
            materialLabel1.TabIndex = 4;
            materialLabel1.Text = "Administrador de Usuarios del Sistema";
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(20, 283);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.Size = new Size(452, 111);
            dgvEmployee.TabIndex = 5;
            // 
            // FrmSistemUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvEmployee);
            Controls.Add(materialLabel1);
            Controls.Add(panel1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "FrmSistemUsers";
            Padding = new Padding(3, 0, 3, 3);
            Text = "FrmSistemUsers";
            Load += FrmSistemUsers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialComboBox cbEmployees;
        private MaterialSkin.Controls.MaterialTextBox2 txtboxUser;
        private MaterialSkin.Controls.MaterialTextBox2 txtboxPass;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton btnAddUser;
        private DataGridView dgvEmployee;
    }
}