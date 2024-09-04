namespace Plantilla_Sistema_Facturacion
{
    partial class frmCategorias
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
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            txtCatName = new MaterialSkin.Controls.MaterialTextBox2();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCatName);
            groupBox1.Controls.Add(materialButton1);
            groupBox1.Controls.Add(materialLabel2);
            groupBox1.Location = new Point(6, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(788, 175);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
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
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(317, 44);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(174, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Categorias de Productos";
            // 
            // txtCatName
            // 
            txtCatName.AnimateReadOnly = false;
            txtCatName.BackgroundImageLayout = ImageLayout.None;
            txtCatName.CharacterCasing = CharacterCasing.Normal;
            txtCatName.Depth = 0;
            txtCatName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCatName.HideSelection = true;
            txtCatName.Hint = "Nombre Categoria";
            txtCatName.LeadingIcon = null;
            txtCatName.Location = new Point(19, 53);
            txtCatName.MaxLength = 32767;
            txtCatName.MouseState = MaterialSkin.MouseState.OUT;
            txtCatName.Name = "txtCatName";
            txtCatName.PasswordChar = '\0';
            txtCatName.PrefixSuffixText = null;
            txtCatName.ReadOnly = false;
            txtCatName.RightToLeft = RightToLeft.No;
            txtCatName.SelectedText = "";
            txtCatName.SelectionLength = 0;
            txtCatName.SelectionStart = 0;
            txtCatName.ShortcutsEnabled = true;
            txtCatName.Size = new Size(250, 48);
            txtCatName.TabIndex = 1;
            txtCatName.TabStop = false;
            txtCatName.TextAlign = HorizontalAlignment.Left;
            txtCatName.TrailingIcon = null;
            txtCatName.UseSystemPasswordChar = false;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(381, 65);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(88, 36);
            materialButton1.TabIndex = 7;
            materialButton1.Text = "Agregar";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(706, 288);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(64, 36);
            materialButton2.TabIndex = 11;
            materialButton2.Text = "Salir";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(materialButton2);
            Controls.Add(materialLabel1);
            Controls.Add(groupBox1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "frmCategorias";
            Padding = new Padding(3, 0, 3, 3);
            Text = "frmCategorias";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtCatName;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}