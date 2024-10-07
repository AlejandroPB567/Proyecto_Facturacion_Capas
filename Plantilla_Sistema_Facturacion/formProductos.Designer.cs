namespace Plantilla_Sistema_Facturacion
{
    partial class frmProducts
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
            txtProductName = new MaterialSkin.Controls.MaterialTextBox2();
            txtProductCode = new MaterialSkin.Controls.MaterialTextBox2();
            txtSellPrice = new MaterialSkin.Controls.MaterialTextBox2();
            txtBuyPrice = new MaterialSkin.Controls.MaterialTextBox2();
            txtLinkPic = new MaterialSkin.Controls.MaterialTextBox2();
            txtStockAmount = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            groupBox1 = new GroupBox();
            btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            btnCancelar = new MaterialSkin.Controls.MaterialButton();
            btnModificar = new MaterialSkin.Controls.MaterialButton();
            btnSalir = new MaterialSkin.Controls.MaterialButton();
            btnAgregar = new MaterialSkin.Controls.MaterialButton();
            txtDetails = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            cbCategoria = new MaterialSkin.Controls.MaterialComboBox();
            groupBox2 = new GroupBox();
            btnRecharge = new MaterialSkin.Controls.MaterialButton();
            btnSearch = new MaterialSkin.Controls.MaterialButton();
            dgvProductsList = new DataGridView();
            txtFindProduct = new MaterialSkin.Controls.MaterialTextBox2();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductsList).BeginInit();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.AnimateReadOnly = false;
            txtProductName.BackgroundImageLayout = ImageLayout.None;
            txtProductName.CharacterCasing = CharacterCasing.Normal;
            txtProductName.Depth = 0;
            txtProductName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtProductName.HideSelection = true;
            txtProductName.Hint = "Nombre Producto";
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
            txtProductCode.Hint = "Codigo del Producto";
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
            // txtSellPrice
            // 
            txtSellPrice.AnimateReadOnly = false;
            txtSellPrice.BackgroundImageLayout = ImageLayout.None;
            txtSellPrice.CharacterCasing = CharacterCasing.Normal;
            txtSellPrice.Depth = 0;
            txtSellPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSellPrice.HideSelection = true;
            txtSellPrice.Hint = "Precio de Venta";
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
            txtBuyPrice.Hint = "Precio de Compra";
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
            // txtLinkPic
            // 
            txtLinkPic.AnimateReadOnly = false;
            txtLinkPic.BackgroundImageLayout = ImageLayout.None;
            txtLinkPic.CharacterCasing = CharacterCasing.Normal;
            txtLinkPic.Depth = 0;
            txtLinkPic.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLinkPic.HideSelection = true;
            txtLinkPic.Hint = "Ruta de Imagen";
            txtLinkPic.LeadingIcon = null;
            txtLinkPic.Location = new Point(343, 71);
            txtLinkPic.MaxLength = 32767;
            txtLinkPic.MouseState = MaterialSkin.MouseState.OUT;
            txtLinkPic.Name = "txtLinkPic";
            txtLinkPic.PasswordChar = '\0';
            txtLinkPic.PrefixSuffixText = null;
            txtLinkPic.ReadOnly = false;
            txtLinkPic.RightToLeft = RightToLeft.No;
            txtLinkPic.SelectedText = "";
            txtLinkPic.SelectionLength = 0;
            txtLinkPic.SelectionStart = 0;
            txtLinkPic.ShortcutsEnabled = true;
            txtLinkPic.Size = new Size(250, 48);
            txtLinkPic.TabIndex = 4;
            txtLinkPic.TabStop = false;
            txtLinkPic.TextAlign = HorizontalAlignment.Left;
            txtLinkPic.TrailingIcon = null;
            txtLinkPic.UseSystemPasswordChar = false;
            // 
            // txtStockAmount
            // 
            txtStockAmount.AnimateReadOnly = false;
            txtStockAmount.BackgroundImageLayout = ImageLayout.None;
            txtStockAmount.CharacterCasing = CharacterCasing.Normal;
            txtStockAmount.Depth = 0;
            txtStockAmount.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtStockAmount.HideSelection = true;
            txtStockAmount.Hint = "Cantidad en Stock";
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
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(353, 11);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(205, 19);
            materialLabel1.TabIndex = 6;
            materialLabel1.Text = "Administracion de Productos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnModificar);
            groupBox1.Controls.Add(btnSalir);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(txtDetails);
            groupBox1.Controls.Add(materialLabel2);
            groupBox1.Controls.Add(cbCategoria);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(txtProductCode);
            groupBox1.Controls.Add(txtLinkPic);
            groupBox1.Controls.Add(txtStockAmount);
            groupBox1.Controls.Add(txtSellPrice);
            groupBox1.Controls.Add(txtBuyPrice);
            groupBox1.Location = new Point(6, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(858, 299);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.AutoSize = false;
            btnLimpiar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLimpiar.Depth = 0;
            btnLimpiar.HighEmphasis = true;
            btnLimpiar.Icon = null;
            btnLimpiar.Location = new Point(640, 71);
            btnLimpiar.Margin = new Padding(4, 6, 4, 6);
            btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.NoAccentTextColor = Color.Empty;
            btnLimpiar.Size = new Size(88, 36);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLimpiar.UseAccentColor = false;
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = false;
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.Location = new Point(640, 159);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(88, 36);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Visible = false;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.AutoSize = false;
            btnModificar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnModificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnModificar.Depth = 0;
            btnModificar.HighEmphasis = true;
            btnModificar.Icon = null;
            btnModificar.Location = new Point(640, 111);
            btnModificar.Margin = new Padding(4, 6, 4, 6);
            btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            btnModificar.Name = "btnModificar";
            btnModificar.NoAccentTextColor = Color.Empty;
            btnModificar.Size = new Size(88, 36);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "MODIFICAR";
            btnModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnModificar.UseAccentColor = false;
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Visible = false;
            btnModificar.Click += btnModificar_Click;
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
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.AutoSize = false;
            btnAgregar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAgregar.Depth = 0;
            btnAgregar.HighEmphasis = true;
            btnAgregar.Icon = null;
            btnAgregar.Location = new Point(640, 23);
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
            // txtDetails
            // 
            txtDetails.AnimateReadOnly = false;
            txtDetails.BackgroundImageLayout = ImageLayout.None;
            txtDetails.CharacterCasing = CharacterCasing.Normal;
            txtDetails.Depth = 0;
            txtDetails.HideSelection = true;
            txtDetails.Hint = "Detalles del producto";
            txtDetails.Location = new Point(343, 125);
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
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(343, 33);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(69, 19);
            materialLabel2.TabIndex = 8;
            materialLabel2.Text = "Categoria";
            // 
            // cbCategoria
            // 
            cbCategoria.AutoResize = false;
            cbCategoria.BackColor = Color.FromArgb(255, 255, 255);
            cbCategoria.Depth = 0;
            cbCategoria.DrawMode = DrawMode.OwnerDrawVariable;
            cbCategoria.DropDownHeight = 174;
            cbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategoria.DropDownWidth = 121;
            cbCategoria.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbCategoria.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbCategoria.FormattingEnabled = true;
            cbCategoria.IntegralHeight = false;
            cbCategoria.ItemHeight = 43;
            cbCategoria.Location = new Point(418, 22);
            cbCategoria.MaxDropDownItems = 4;
            cbCategoria.MouseState = MaterialSkin.MouseState.OUT;
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(175, 49);
            cbCategoria.StartIndex = 0;
            cbCategoria.TabIndex = 6;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRecharge);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(dgvProductsList);
            groupBox2.Controls.Add(txtFindProduct);
            groupBox2.Location = new Point(6, 338);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(858, 257);
            groupBox2.TabIndex = 8;
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
            txtFindProduct.Hint = "Buscar Producto";
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
            // frmProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(866, 593);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(materialLabel1);
            FormStyle = FormStyles.StatusAndActionBar_None;
            Name = "frmProducts";
            Padding = new Padding(3, 0, 3, 3);
            Text = "formProductos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 txtProductName;
        private MaterialSkin.Controls.MaterialTextBox2 txtProductCode;
        private MaterialSkin.Controls.MaterialTextBox2 txtSellPrice;
        private MaterialSkin.Controls.MaterialTextBox2 txtBuyPrice;
        private MaterialSkin.Controls.MaterialTextBox2 txtLinkPic;
        private MaterialSkin.Controls.MaterialTextBox2 txtStockAmount;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cbCategoria;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDetails;
        private GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton btnRecharge;
        private MaterialSkin.Controls.MaterialButton btnSearch;
        private DataGridView dgvProductsList;
        private MaterialSkin.Controls.MaterialTextBox2 txtFindProduct;
        private MaterialSkin.Controls.MaterialButton btnSalir;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnModificar;
    }
}