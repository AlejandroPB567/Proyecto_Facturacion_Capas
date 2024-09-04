namespace Plantilla_Sistema_Facturacion
{
    partial class frmBillManager
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
            materialComboBox3 = new MaterialSkin.Controls.MaterialComboBox();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            dateTimePicker1 = new DateTimePicker();
            materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            btnExit = new MaterialSkin.Controls.MaterialButton();
            btnClear = new MaterialSkin.Controls.MaterialButton();
            txtClientName = new MaterialSkin.Controls.MaterialTextBox2();
            btnCreateClient = new MaterialSkin.Controls.MaterialButton();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            txtTelNum = new MaterialSkin.Controls.MaterialTextBox2();
            groupBox2 = new GroupBox();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(materialComboBox3);
            groupBox1.Controls.Add(materialLabel1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(materialTextBox21);
            groupBox1.Controls.Add(materialComboBox2);
            groupBox1.Controls.Add(materialComboBox1);
            groupBox1.Controls.Add(btnExit);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(txtClientName);
            groupBox1.Controls.Add(btnCreateClient);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtTelNum);
            groupBox1.Location = new Point(9, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(919, 352);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // materialComboBox3
            // 
            materialComboBox3.AutoResize = false;
            materialComboBox3.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox3.Depth = 0;
            materialComboBox3.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox3.DropDownHeight = 174;
            materialComboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox3.DropDownWidth = 121;
            materialComboBox3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox3.FormattingEnabled = true;
            materialComboBox3.Hint = "Estado Factura";
            materialComboBox3.IntegralHeight = false;
            materialComboBox3.ItemHeight = 43;
            materialComboBox3.Location = new Point(478, 125);
            materialComboBox3.MaxDropDownItems = 4;
            materialComboBox3.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox3.Name = "materialComboBox3";
            materialComboBox3.Size = new Size(167, 49);
            materialComboBox3.StartIndex = 0;
            materialComboBox3.TabIndex = 13;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(478, 70);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(106, 19);
            materialLabel1.TabIndex = 12;
            materialLabel1.Text = "Fecha Registro";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(480, 96);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(106, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // materialTextBox21
            // 
            materialTextBox21.AnimateReadOnly = false;
            materialTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21.HideSelection = true;
            materialTextBox21.Hint = "Total Factura";
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.Location = new Point(58, 288);
            materialTextBox21.MaxLength = 32767;
            materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '\0';
            materialTextBox21.PrefixSuffixText = null;
            materialTextBox21.ReadOnly = false;
            materialTextBox21.RightToLeft = RightToLeft.No;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.Size = new Size(208, 48);
            materialTextBox21.TabIndex = 9;
            materialTextBox21.TabStop = false;
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
            // 
            // materialComboBox2
            // 
            materialComboBox2.AutoResize = false;
            materialComboBox2.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox2.Depth = 0;
            materialComboBox2.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox2.DropDownHeight = 174;
            materialComboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox2.DropDownWidth = 121;
            materialComboBox2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox2.FormattingEnabled = true;
            materialComboBox2.Hint = "Empleado";
            materialComboBox2.IntegralHeight = false;
            materialComboBox2.ItemHeight = 43;
            materialComboBox2.Location = new Point(58, 125);
            materialComboBox2.MaxDropDownItems = 4;
            materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox2.Name = "materialComboBox2";
            materialComboBox2.Size = new Size(328, 49);
            materialComboBox2.StartIndex = 0;
            materialComboBox2.TabIndex = 8;
            // 
            // materialComboBox1
            // 
            materialComboBox1.AutoResize = false;
            materialComboBox1.BackColor = Color.FromArgb(255, 255, 255);
            materialComboBox1.Depth = 0;
            materialComboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            materialComboBox1.DropDownHeight = 174;
            materialComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            materialComboBox1.DropDownWidth = 121;
            materialComboBox1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialComboBox1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialComboBox1.FormattingEnabled = true;
            materialComboBox1.Hint = "Cliente";
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Location = new Point(58, 70);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(328, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 7;
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
            btnExit.Location = new Point(781, 288);
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
            btnClear.Location = new Point(778, 64);
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
            // 
            // txtClientName
            // 
            txtClientName.AnimateReadOnly = false;
            txtClientName.BackgroundImageLayout = ImageLayout.None;
            txtClientName.CharacterCasing = CharacterCasing.Normal;
            txtClientName.Depth = 0;
            txtClientName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtClientName.HideSelection = false;
            txtClientName.Hint = "No Factura";
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
            txtClientName.Size = new Size(250, 48);
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
            btnCreateClient.Location = new Point(778, 22);
            btnCreateClient.Margin = new Padding(4, 6, 4, 6);
            btnCreateClient.MouseState = MaterialSkin.MouseState.HOVER;
            btnCreateClient.Name = "btnCreateClient";
            btnCreateClient.NoAccentTextColor = Color.Empty;
            btnCreateClient.Size = new Size(97, 36);
            btnCreateClient.TabIndex = 3;
            btnCreateClient.Text = "Actualizar";
            btnCreateClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCreateClient.UseAccentColor = false;
            btnCreateClient.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "Total Iva";
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
            txtEmail.Size = new Size(208, 48);
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
            txtTelNum.Hint = "Descuento";
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
            txtTelNum.Size = new Size(208, 48);
            txtTelNum.TabIndex = 3;
            txtTelNum.TabStop = false;
            txtTelNum.TextAlign = HorizontalAlignment.Left;
            txtTelNum.TrailingIcon = null;
            txtTelNum.UseSystemPasswordChar = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(9, 385);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(919, 188);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle Factura";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(352, 15);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(180, 19);
            materialLabel3.TabIndex = 15;
            materialLabel3.Text = "Administrador de Factura";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(899, 160);
            dataGridView1.TabIndex = 0;
            // 
            // frmBillManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 579);
            Controls.Add(materialLabel3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "frmBillManager";
            Padding = new Padding(3, 0, 3, 3);
            Text = "frmBillManager";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private MaterialSkin.Controls.MaterialButton btnClear;
        private MaterialSkin.Controls.MaterialTextBox2 txtClientName;
        private MaterialSkin.Controls.MaterialButton btnCreateClient;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelNum;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
        private DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private DataGridView dataGridView1;
    }
}