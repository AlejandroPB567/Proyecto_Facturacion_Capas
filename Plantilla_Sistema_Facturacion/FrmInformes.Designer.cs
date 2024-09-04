namespace Plantilla_Sistema_Facturacion
{
    partial class FrmInformes
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
            materialRadioButton3 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            dateTimePicker2 = new DateTimePicker();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            dateTimePicker1 = new DateTimePicker();
            materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            btnExit = new MaterialSkin.Controls.MaterialButton();
            btnCreateClient = new MaterialSkin.Controls.MaterialButton();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(materialRadioButton3);
            groupBox1.Controls.Add(materialRadioButton2);
            groupBox1.Controls.Add(materialRadioButton1);
            groupBox1.Controls.Add(materialLabel2);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(materialLabel1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(materialComboBox2);
            groupBox1.Controls.Add(materialComboBox1);
            groupBox1.Location = new Point(20, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(917, 211);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // materialRadioButton3
            // 
            materialRadioButton3.AutoSize = true;
            materialRadioButton3.Depth = 0;
            materialRadioButton3.Location = new Point(278, 163);
            materialRadioButton3.Margin = new Padding(0);
            materialRadioButton3.MouseLocation = new Point(-1, -1);
            materialRadioButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton3.Name = "materialRadioButton3";
            materialRadioButton3.Ripple = true;
            materialRadioButton3.Size = new Size(72, 37);
            materialRadioButton3.TabIndex = 17;
            materialRadioButton3.TabStop = true;
            materialRadioButton3.Text = "Excel";
            materialRadioButton3.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton2
            // 
            materialRadioButton2.AutoSize = true;
            materialRadioButton2.Depth = 0;
            materialRadioButton2.Location = new Point(187, 163);
            materialRadioButton2.Margin = new Padding(0);
            materialRadioButton2.MouseLocation = new Point(-1, -1);
            materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton2.Name = "materialRadioButton2";
            materialRadioButton2.Ripple = true;
            materialRadioButton2.Size = new Size(65, 37);
            materialRadioButton2.TabIndex = 16;
            materialRadioButton2.TabStop = true;
            materialRadioButton2.Text = "PDF";
            materialRadioButton2.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton1
            // 
            materialRadioButton1.AutoSize = true;
            materialRadioButton1.Depth = 0;
            materialRadioButton1.Location = new Point(38, 163);
            materialRadioButton1.Margin = new Padding(0);
            materialRadioButton1.MouseLocation = new Point(-1, -1);
            materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialRadioButton1.Name = "materialRadioButton1";
            materialRadioButton1.Ripple = true;
            materialRadioButton1.Size = new Size(116, 37);
            materialRadioButton1.TabIndex = 15;
            materialRadioButton1.TabStop = true;
            materialRadioButton1.Text = "En Pantalla";
            materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(410, 96);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(83, 19);
            materialLabel2.TabIndex = 14;
            materialLabel2.Text = "Fecha Final";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(412, 122);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(106, 23);
            dateTimePicker2.TabIndex = 13;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(112, 96);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(86, 19);
            materialLabel1.TabIndex = 12;
            materialLabel1.Text = "Fecha Inicio";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(114, 122);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(106, 23);
            dateTimePicker1.TabIndex = 10;
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
            materialComboBox2.Hint = "Ordenar por:";
            materialComboBox2.IntegralHeight = false;
            materialComboBox2.ItemHeight = 43;
            materialComboBox2.Location = new Point(371, 22);
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
            materialComboBox1.Hint = "Seleccione Informe";
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Location = new Point(6, 22);
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
            btnExit.Location = new Point(766, 265);
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
            // btnCreateClient
            // 
            btnCreateClient.AutoSize = false;
            btnCreateClient.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCreateClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCreateClient.Depth = 0;
            btnCreateClient.ForeColor = SystemColors.ControlDark;
            btnCreateClient.HighEmphasis = true;
            btnCreateClient.Icon = null;
            btnCreateClient.Location = new Point(245, 265);
            btnCreateClient.Margin = new Padding(4, 6, 4, 6);
            btnCreateClient.MouseState = MaterialSkin.MouseState.HOVER;
            btnCreateClient.Name = "btnCreateClient";
            btnCreateClient.NoAccentTextColor = Color.Empty;
            btnCreateClient.Size = new Size(143, 36);
            btnCreateClient.TabIndex = 3;
            btnCreateClient.Text = "Generar Informe";
            btnCreateClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCreateClient.UseAccentColor = false;
            btnCreateClient.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(336, 23);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(241, 19);
            materialLabel3.TabIndex = 3;
            materialLabel3.Text = "Generador de Informes de Factura";
            // 
            // FrmInformes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 589);
            Controls.Add(materialLabel3);
            Controls.Add(groupBox1);
            Controls.Add(btnCreateClient);
            Controls.Add(btnExit);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "FrmInformes";
            Padding = new Padding(3, 0, 3, 3);
            Text = "FrmInformes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private DateTimePicker dateTimePicker2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private DateTimePicker dateTimePicker1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialButton btnExit;
        private MaterialSkin.Controls.MaterialButton btnCreateClient;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton3;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}