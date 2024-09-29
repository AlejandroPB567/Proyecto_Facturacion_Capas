namespace Plantilla_Sistema_Facturacion
{
    partial class FrmRoles
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
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            groupBox1 = new GroupBox();
            dgvClientList = new DataGridView();
            txtRolName = new MaterialSkin.Controls.MaterialTextBox2();
            btnAddRol = new MaterialSkin.Controls.MaterialButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientList).BeginInit();
            SuspendLayout();
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(686, 133);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(64, 36);
            materialButton2.TabIndex = 14;
            materialButton2.Text = "Salir";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(326, 16);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(128, 19);
            materialLabel1.TabIndex = 13;
            materialLabel1.Text = "Rol de Empleados";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvClientList);
            groupBox1.Controls.Add(materialButton2);
            groupBox1.Controls.Add(txtRolName);
            groupBox1.Controls.Add(btnAddRol);
            groupBox1.Controls.Add(materialLabel2);
            groupBox1.Location = new Point(15, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(788, 247);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            // 
            // dgvClientList
            // 
            dgvClientList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientList.Location = new Point(19, 119);
            dgvClientList.Name = "dgvClientList";
            dgvClientList.Size = new Size(428, 128);
            dgvClientList.TabIndex = 15;
            dgvClientList.CellContentClick += dgvClientList_CellContentClick;
            // 
            // txtRolName
            // 
            txtRolName.AnimateReadOnly = false;
            txtRolName.BackgroundImageLayout = ImageLayout.None;
            txtRolName.CharacterCasing = CharacterCasing.Normal;
            txtRolName.Depth = 0;
            txtRolName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRolName.HideSelection = true;
            txtRolName.Hint = "Nombre Rol";
            txtRolName.LeadingIcon = null;
            txtRolName.Location = new Point(19, 19);
            txtRolName.MaxLength = 32767;
            txtRolName.MouseState = MaterialSkin.MouseState.OUT;
            txtRolName.Name = "txtRolName";
            txtRolName.PasswordChar = '\0';
            txtRolName.PrefixSuffixText = null;
            txtRolName.ReadOnly = false;
            txtRolName.RightToLeft = RightToLeft.No;
            txtRolName.SelectedText = "";
            txtRolName.SelectionLength = 0;
            txtRolName.SelectionStart = 0;
            txtRolName.ShortcutsEnabled = true;
            txtRolName.Size = new Size(250, 48);
            txtRolName.TabIndex = 1;
            txtRolName.TabStop = false;
            txtRolName.TextAlign = HorizontalAlignment.Left;
            txtRolName.TrailingIcon = null;
            txtRolName.UseSystemPasswordChar = false;
            // 
            // btnAddRol
            // 
            btnAddRol.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddRol.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddRol.Depth = 0;
            btnAddRol.HighEmphasis = true;
            btnAddRol.Icon = null;
            btnAddRol.Location = new Point(662, 25);
            btnAddRol.Margin = new Padding(4, 6, 4, 6);
            btnAddRol.MouseState = MaterialSkin.MouseState.HOVER;
            btnAddRol.Name = "btnAddRol";
            btnAddRol.NoAccentTextColor = Color.Empty;
            btnAddRol.Size = new Size(88, 36);
            btnAddRol.TabIndex = 7;
            btnAddRol.Text = "Agregar";
            btnAddRol.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddRol.UseAccentColor = false;
            btnAddRol.UseVisualStyleBackColor = true;
            btnAddRol.Click += btnAddRol_Click;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(19, 19);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(21, 19);
            materialLabel2.TabIndex = 0;
            materialLabel2.Text = "     ";
            // 
            // FrmRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialLabel1);
            Controls.Add(groupBox1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "FrmRoles";
            Padding = new Padding(3, 0, 3, 3);
            Text = "FrmRoles";
            Load += FrmRoles_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialTextBox2 txtRolName;
        private MaterialSkin.Controls.MaterialButton btnAddRol;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private DataGridView dgvClientList;
    }
}