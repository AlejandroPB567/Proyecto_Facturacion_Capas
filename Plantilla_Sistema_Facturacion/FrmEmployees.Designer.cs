﻿namespace Plantilla_Sistema_Facturacion
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
            dgvProductsList = new DataGridView();
            txtFindProduct = new MaterialSkin.Controls.MaterialTextBox2();
            groupBox1 = new GroupBox();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            txtDetails = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            txtProductName = new MaterialSkin.Controls.MaterialTextBox2();
            txtProductCode = new MaterialSkin.Controls.MaterialTextBox2();
            txtStockAmount = new MaterialSkin.Controls.MaterialTextBox2();
            txtSellPrice = new MaterialSkin.Controls.MaterialTextBox2();
            txtBuyPrice = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            dateTimePicker2 = new DateTimePicker();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            dateTimePicker1 = new DateTimePicker();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductsList).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRecharge);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(dgvProductsList);
            groupBox2.Controls.Add(txtFindProduct);
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
            // 
            // dgvProductsList
            // 
            dgvProductsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductsList.Location = new Point(18, 100);
            dgvProductsList.Name = "dgvProductsList";
            dgvProductsList.Size = new Size(817, 118);
            dgvProductsList.TabIndex = 3;
            // 
            // txtFindProduct
            // 
            txtFindProduct.AnimateReadOnly = false;
            txtFindProduct.BackgroundImageLayout = ImageLayout.None;
            txtFindProduct.CharacterCasing = CharacterCasing.Normal;
            txtFindProduct.Depth = 0;
            txtFindProduct.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFindProduct.HideSelection = true;
            txtFindProduct.Hint = "Buscar Empleado";
            txtFindProduct.LeadingIcon = null;
            txtFindProduct.Location = new Point(32, 22);
            txtFindProduct.MaxLength = 32767;
            txtFindProduct.MouseState = MaterialSkin.MouseState.OUT;
            txtFindProduct.Name = "txtFindProduct";
            txtFindProduct.PasswordChar = '\0';
            txtFindProduct.PrefixSuffixText = null;
            txtFindProduct.ReadOnly = false;
            txtFindProduct.RightToLeft = RightToLeft.No;
            txtFindProduct.SelectedText = "";
            txtFindProduct.SelectionLength = 0;
            txtFindProduct.SelectionStart = 0;
            txtFindProduct.ShortcutsEnabled = true;
            txtFindProduct.Size = new Size(520, 48);
            txtFindProduct.TabIndex = 2;
            txtFindProduct.TabStop = false;
            txtFindProduct.TextAlign = HorizontalAlignment.Left;
            txtFindProduct.TrailingIcon = null;
            txtFindProduct.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(materialLabel2);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(materialLabel3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(materialButton2);
            groupBox1.Controls.Add(materialButton1);
            groupBox1.Controls.Add(txtDetails);
            groupBox1.Controls.Add(materialComboBox1);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(txtProductCode);
            groupBox1.Controls.Add(txtStockAmount);
            groupBox1.Controls.Add(txtSellPrice);
            groupBox1.Controls.Add(txtBuyPrice);
            groupBox1.Location = new Point(6, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(858, 299);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(640, 233);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(64, 36);
            materialButton2.TabIndex = 10;
            materialButton2.Text = "Salir";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(640, 179);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(88, 36);
            materialButton1.TabIndex = 6;
            materialButton1.Text = "Agregar";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            // 
            // txtDetails
            // 
            txtDetails.AnimateReadOnly = false;
            txtDetails.BackgroundImageLayout = ImageLayout.None;
            txtDetails.CharacterCasing = CharacterCasing.Normal;
            txtDetails.Depth = 0;
            txtDetails.HideSelection = true;
            txtDetails.Hint = "Detalles Adicionales";
            txtDetails.Location = new Point(332, 125);
            txtDetails.MaxLength = 32767;
            txtDetails.MouseState = MaterialSkin.MouseState.OUT;
            txtDetails.Name = "txtDetails";
            txtDetails.PasswordChar = '\0';
            txtDetails.ReadOnly = false;
            txtDetails.ScrollBars = ScrollBars.None;
            txtDetails.SelectedText = "";
            txtDetails.SelectionLength = 0;
            txtDetails.SelectionStart = 0;
            txtDetails.ShortcutsEnabled = true;
            txtDetails.Size = new Size(250, 156);
            txtDetails.TabIndex = 9;
            txtDetails.TabStop = false;
            txtDetails.TextAlign = HorizontalAlignment.Left;
            txtDetails.UseSystemPasswordChar = false;
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
            materialComboBox1.Hint = "Rol de Empleado";
            materialComboBox1.IntegralHeight = false;
            materialComboBox1.ItemHeight = 43;
            materialComboBox1.Location = new Point(332, 21);
            materialComboBox1.MaxDropDownItems = 4;
            materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialComboBox1.Name = "materialComboBox1";
            materialComboBox1.Size = new Size(175, 49);
            materialComboBox1.StartIndex = 0;
            materialComboBox1.TabIndex = 6;
            // 
            // txtProductName
            // 
            txtProductName.AnimateReadOnly = false;
            txtProductName.BackgroundImageLayout = ImageLayout.None;
            txtProductName.CharacterCasing = CharacterCasing.Normal;
            txtProductName.Depth = 0;
            txtProductName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtProductName.HideSelection = true;
            txtProductName.Hint = "Nombre Empleado";
            txtProductName.LeadingIcon = null;
            txtProductName.Location = new Point(18, 22);
            txtProductName.MaxLength = 32767;
            txtProductName.MouseState = MaterialSkin.MouseState.OUT;
            txtProductName.Name = "txtProductName";
            txtProductName.PasswordChar = '\0';
            txtProductName.PrefixSuffixText = null;
            txtProductName.ReadOnly = false;
            txtProductName.RightToLeft = RightToLeft.No;
            txtProductName.SelectedText = "";
            txtProductName.SelectionLength = 0;
            txtProductName.SelectionStart = 0;
            txtProductName.ShortcutsEnabled = true;
            txtProductName.Size = new Size(250, 48);
            txtProductName.TabIndex = 0;
            txtProductName.TabStop = false;
            txtProductName.TextAlign = HorizontalAlignment.Left;
            txtProductName.TrailingIcon = null;
            txtProductName.UseSystemPasswordChar = false;
            // 
            // txtProductCode
            // 
            txtProductCode.AnimateReadOnly = false;
            txtProductCode.BackgroundImageLayout = ImageLayout.None;
            txtProductCode.CharacterCasing = CharacterCasing.Normal;
            txtProductCode.Depth = 0;
            txtProductCode.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtProductCode.HideSelection = true;
            txtProductCode.Hint = "Documento";
            txtProductCode.LeadingIcon = null;
            txtProductCode.Location = new Point(18, 76);
            txtProductCode.MaxLength = 32767;
            txtProductCode.MouseState = MaterialSkin.MouseState.OUT;
            txtProductCode.Name = "txtProductCode";
            txtProductCode.PasswordChar = '\0';
            txtProductCode.PrefixSuffixText = null;
            txtProductCode.ReadOnly = false;
            txtProductCode.RightToLeft = RightToLeft.No;
            txtProductCode.SelectedText = "";
            txtProductCode.SelectionLength = 0;
            txtProductCode.SelectionStart = 0;
            txtProductCode.ShortcutsEnabled = true;
            txtProductCode.Size = new Size(250, 48);
            txtProductCode.TabIndex = 1;
            txtProductCode.TabStop = false;
            txtProductCode.TextAlign = HorizontalAlignment.Left;
            txtProductCode.TrailingIcon = null;
            txtProductCode.UseSystemPasswordChar = false;
            // 
            // txtStockAmount
            // 
            txtStockAmount.AnimateReadOnly = false;
            txtStockAmount.BackgroundImageLayout = ImageLayout.None;
            txtStockAmount.CharacterCasing = CharacterCasing.Normal;
            txtStockAmount.Depth = 0;
            txtStockAmount.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtStockAmount.HideSelection = true;
            txtStockAmount.Hint = "E-mail";
            txtStockAmount.LeadingIcon = null;
            txtStockAmount.Location = new Point(18, 233);
            txtStockAmount.MaxLength = 32767;
            txtStockAmount.MouseState = MaterialSkin.MouseState.OUT;
            txtStockAmount.Name = "txtStockAmount";
            txtStockAmount.PasswordChar = '\0';
            txtStockAmount.PrefixSuffixText = null;
            txtStockAmount.ReadOnly = false;
            txtStockAmount.RightToLeft = RightToLeft.No;
            txtStockAmount.SelectedText = "";
            txtStockAmount.SelectionLength = 0;
            txtStockAmount.SelectionStart = 0;
            txtStockAmount.ShortcutsEnabled = true;
            txtStockAmount.Size = new Size(250, 48);
            txtStockAmount.TabIndex = 5;
            txtStockAmount.TabStop = false;
            txtStockAmount.TextAlign = HorizontalAlignment.Left;
            txtStockAmount.TrailingIcon = null;
            txtStockAmount.UseSystemPasswordChar = false;
            // 
            // txtSellPrice
            // 
            txtSellPrice.AnimateReadOnly = false;
            txtSellPrice.BackgroundImageLayout = ImageLayout.None;
            txtSellPrice.CharacterCasing = CharacterCasing.Normal;
            txtSellPrice.Depth = 0;
            txtSellPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSellPrice.HideSelection = true;
            txtSellPrice.Hint = "Telefono";
            txtSellPrice.LeadingIcon = null;
            txtSellPrice.Location = new Point(18, 179);
            txtSellPrice.MaxLength = 32767;
            txtSellPrice.MouseState = MaterialSkin.MouseState.OUT;
            txtSellPrice.Name = "txtSellPrice";
            txtSellPrice.PasswordChar = '\0';
            txtSellPrice.PrefixSuffixText = null;
            txtSellPrice.ReadOnly = false;
            txtSellPrice.RightToLeft = RightToLeft.No;
            txtSellPrice.SelectedText = "";
            txtSellPrice.SelectionLength = 0;
            txtSellPrice.SelectionStart = 0;
            txtSellPrice.ShortcutsEnabled = true;
            txtSellPrice.Size = new Size(250, 48);
            txtSellPrice.TabIndex = 2;
            txtSellPrice.TabStop = false;
            txtSellPrice.TextAlign = HorizontalAlignment.Left;
            txtSellPrice.TrailingIcon = null;
            txtSellPrice.UseSystemPasswordChar = false;
            // 
            // txtBuyPrice
            // 
            txtBuyPrice.AnimateReadOnly = false;
            txtBuyPrice.BackgroundImageLayout = ImageLayout.None;
            txtBuyPrice.CharacterCasing = CharacterCasing.Normal;
            txtBuyPrice.Depth = 0;
            txtBuyPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBuyPrice.HideSelection = true;
            txtBuyPrice.Hint = "Direccion";
            txtBuyPrice.LeadingIcon = null;
            txtBuyPrice.Location = new Point(18, 125);
            txtBuyPrice.MaxLength = 32767;
            txtBuyPrice.MouseState = MaterialSkin.MouseState.OUT;
            txtBuyPrice.Name = "txtBuyPrice";
            txtBuyPrice.PasswordChar = '\0';
            txtBuyPrice.PrefixSuffixText = null;
            txtBuyPrice.ReadOnly = false;
            txtBuyPrice.RightToLeft = RightToLeft.No;
            txtBuyPrice.SelectedText = "";
            txtBuyPrice.SelectionLength = 0;
            txtBuyPrice.SelectionStart = 0;
            txtBuyPrice.ShortcutsEnabled = true;
            txtBuyPrice.Size = new Size(250, 48);
            txtBuyPrice.TabIndex = 3;
            txtBuyPrice.TabStop = false;
            txtBuyPrice.TextAlign = HorizontalAlignment.Left;
            txtBuyPrice.TrailingIcon = null;
            txtBuyPrice.UseSystemPasswordChar = false;
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
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(741, 102);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(106, 23);
            dateTimePicker2.TabIndex = 17;
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
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(603, 102);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(106, 23);
            dateTimePicker1.TabIndex = 15;
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
            ((System.ComponentModel.ISupportInitialize)dgvProductsList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton btnRecharge;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private DataGridView dgvProductsList;
        private MaterialSkin.Controls.MaterialTextBox2 txtFindProduct;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDetails;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialTextBox2 txtProductName;
        private MaterialSkin.Controls.MaterialTextBox2 txtProductCode;
        private MaterialSkin.Controls.MaterialTextBox2 txtStockAmount;
        private MaterialSkin.Controls.MaterialTextBox2 txtSellPrice;
        private MaterialSkin.Controls.MaterialTextBox2 txtBuyPrice;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private DateTimePicker dateTimePicker2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private DateTimePicker dateTimePicker1;
    }
}