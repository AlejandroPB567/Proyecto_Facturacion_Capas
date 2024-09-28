namespace Plantilla_Sistema_Facturacion
{
    partial class frmPrincipal
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
            pnlPrincipal = new Panel();
            pnlContainer = new Panel();
            panel1 = new Panel();
            tabControlMenu = new MaterialSkin.Controls.MaterialTabControl();
            principal = new TabPage();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            tables = new TabPage();
            pictureBox2 = new PictureBox();
            btnClients = new Button();
            btnProducts = new Button();
            btnCategories = new Button();
            billing = new TabPage();
            btnBills = new Button();
            btnReports = new Button();
            pictureBox3 = new PictureBox();
            security = new TabPage();
            btnSecurity = new Button();
            btnRoles = new Button();
            btnEmployees = new Button();
            pictureBox5 = new PictureBox();
            helph = new TabPage();
            btnInfo = new Button();
            btnHelp = new Button();
            pictureBox4 = new PictureBox();
            tabSelectorMenu = new MaterialSkin.Controls.MaterialTabSelector();
            pnlPrincipal.SuspendLayout();
            panel1.SuspendLayout();
            tabControlMenu.SuspendLayout();
            principal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            billing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            security.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            helph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Controls.Add(pnlContainer);
            pnlPrincipal.Controls.Add(panel1);
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Location = new Point(3, 64);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(1194, 583);
            pnlPrincipal.TabIndex = 0;
            // 
            // pnlContainer
            // 
            pnlContainer.AutoScroll = true;
            pnlContainer.AutoSize = true;
            pnlContainer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(200, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(994, 583);
            pnlContainer.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(tabControlMenu);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 583);
            panel1.TabIndex = 0;
            // 
            // tabControlMenu
            // 
            tabControlMenu.Controls.Add(principal);
            tabControlMenu.Controls.Add(tables);
            tabControlMenu.Controls.Add(billing);
            tabControlMenu.Controls.Add(security);
            tabControlMenu.Controls.Add(helph);
            tabControlMenu.Depth = 0;
            tabControlMenu.Dock = DockStyle.Fill;
            tabControlMenu.Location = new Point(0, 0);
            tabControlMenu.MouseState = MaterialSkin.MouseState.HOVER;
            tabControlMenu.Multiline = true;
            tabControlMenu.Name = "tabControlMenu";
            tabControlMenu.SelectedIndex = 0;
            tabControlMenu.Size = new Size(200, 583);
            tabControlMenu.TabIndex = 0;
            // 
            // principal
            // 
            principal.BackColor = Color.LightSteelBlue;
            principal.Controls.Add(btnLogout);
            principal.Controls.Add(pictureBox1);
            principal.Location = new Point(4, 44);
            principal.Name = "principal";
            principal.Padding = new Padding(3);
            principal.Size = new Size(192, 535);
            principal.TabIndex = 0;
            principal.Text = "Principal";
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderColor = Color.White;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseDownBackColor = Color.White;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
///            btnLogout.Image = Properties.Resources.sign_out_alt;
            btnLogout.Location = new Point(0, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(192, 43);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "     Salir";
            btnLogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
 //           pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(3, 421);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(186, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tables
            // 
            tables.BackColor = Color.LightSteelBlue;
            tables.Controls.Add(pictureBox2);
            tables.Controls.Add(btnClients);
            tables.Controls.Add(btnProducts);
            tables.Controls.Add(btnCategories);
            tables.Location = new Point(4, 44);
            tables.Name = "tables";
            tables.Padding = new Padding(3);
            tables.Size = new Size(192, 535);
            tables.TabIndex = 1;
            tables.Text = "Tablas";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Bottom;
//            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(3, 421);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(186, 111);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // btnClients
            // 
            btnClients.FlatAppearance.BorderColor = Color.White;
            btnClients.FlatAppearance.BorderSize = 0;
            btnClients.FlatAppearance.MouseDownBackColor = Color.White;
            btnClients.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
            btnClients.FlatStyle = FlatStyle.Flat;
            btnClients.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            btnClients.Image = Properties.Resources.target_audience;
            btnClients.Location = new Point(0, 0);
            btnClients.Name = "btnClients";
            btnClients.Size = new Size(192, 43);
            btnClients.TabIndex = 5;
            btnClients.Text = "Clientes";
            btnClients.TextAlign = ContentAlignment.MiddleLeft;
            btnClients.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClients.UseVisualStyleBackColor = true;
            btnClients.Click += btnClients_Click;
            // 
            // btnProducts
            // 
            btnProducts.FlatAppearance.BorderColor = Color.White;
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatAppearance.MouseDownBackColor = Color.White;
            btnProducts.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
 //           btnProducts.Image = Properties.Resources.box_open;
            btnProducts.Location = new Point(0, 40);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(192, 43);
            btnProducts.TabIndex = 4;
            btnProducts.Text = "Productos";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnCategories
            // 
            btnCategories.FlatAppearance.BorderColor = Color.White;
            btnCategories.FlatAppearance.BorderSize = 0;
            btnCategories.FlatAppearance.MouseDownBackColor = Color.White;
            btnCategories.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
 //           btnCategories.Image = Properties.Resources.category;
            btnCategories.Location = new Point(1, 89);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(192, 43);
            btnCategories.TabIndex = 3;
            btnCategories.Text = "Categorias";
            btnCategories.TextAlign = ContentAlignment.MiddleLeft;
            btnCategories.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // billing
            // 
            billing.BackColor = Color.LightSteelBlue;
            billing.Controls.Add(btnBills);
            billing.Controls.Add(btnReports);
            billing.Controls.Add(pictureBox3);
            billing.Location = new Point(4, 44);
            billing.Name = "billing";
            billing.Size = new Size(192, 535);
            billing.TabIndex = 2;
            billing.Text = "Facturacion";
            // 
            // btnBills
            // 
            btnBills.FlatAppearance.BorderColor = Color.White;
            btnBills.FlatAppearance.BorderSize = 0;
            btnBills.FlatAppearance.MouseDownBackColor = Color.White;
            btnBills.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
            btnBills.FlatStyle = FlatStyle.Flat;
            btnBills.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
 //           btnBills.Image = Properties.Resources.receipt;
            btnBills.Location = new Point(-1, 0);
            btnBills.Name = "btnBills";
            btnBills.Size = new Size(192, 43);
            btnBills.TabIndex = 7;
            btnBills.Text = "Facturas";
            btnBills.TextAlign = ContentAlignment.MiddleLeft;
            btnBills.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBills.UseVisualStyleBackColor = true;
            btnBills.Click += btnBills_Click;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderColor = Color.White;
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatAppearance.MouseDownBackColor = Color.White;
            btnReports.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            btnReports.Image = Properties.Resources.file_medical_alt;
            btnReports.Location = new Point(1, 49);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(192, 43);
            btnReports.TabIndex = 6;
            btnReports.Text = "Informes";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = true;
            btnReports.Click += btnReports_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Bottom;
  //          pictureBox3.Image = Properties.Resources.logo;
            pictureBox3.Location = new Point(0, 424);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(192, 111);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // security
            // 
            security.BackColor = Color.LightSteelBlue;
            security.Controls.Add(btnSecurity);
            security.Controls.Add(btnRoles);
            security.Controls.Add(btnEmployees);
            security.Controls.Add(pictureBox5);
            security.Location = new Point(4, 44);
            security.Name = "security";
            security.Size = new Size(192, 535);
            security.TabIndex = 4;
            security.Text = "Seguridad";
            // 
            // btnSecurity
            // 
            btnSecurity.FlatAppearance.BorderColor = Color.White;
            btnSecurity.FlatAppearance.BorderSize = 0;
            btnSecurity.FlatAppearance.MouseDownBackColor = Color.White;
            btnSecurity.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
            btnSecurity.FlatStyle = FlatStyle.Flat;
            btnSecurity.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
  //          btnSecurity.Image = Properties.Resources.shield_keyhole;
            btnSecurity.Location = new Point(0, 98);
            btnSecurity.Name = "btnSecurity";
            btnSecurity.Size = new Size(192, 43);
            btnSecurity.TabIndex = 8;
            btnSecurity.Text = "Seguridad";
            btnSecurity.TextAlign = ContentAlignment.MiddleLeft;
            btnSecurity.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSecurity.UseVisualStyleBackColor = true;
            btnSecurity.Click += btnSecurity_Click;
            // 
            // btnRoles
            // 
            btnRoles.FlatAppearance.BorderColor = Color.White;
            btnRoles.FlatAppearance.BorderSize = 0;
            btnRoles.FlatAppearance.MouseDownBackColor = Color.White;
            btnRoles.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
            btnRoles.FlatStyle = FlatStyle.Flat;
            btnRoles.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
 //           btnRoles.Image = Properties.Resources.dice_d8;
            btnRoles.Location = new Point(0, 49);
            btnRoles.Name = "btnRoles";
            btnRoles.Size = new Size(192, 43);
            btnRoles.TabIndex = 7;
            btnRoles.Text = "Roles";
            btnRoles.TextAlign = ContentAlignment.MiddleLeft;
            btnRoles.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRoles.UseVisualStyleBackColor = true;
            btnRoles.Click += btnRoles_Click;
            // 
            // btnEmployees
            // 
            btnEmployees.FlatAppearance.BorderColor = Color.White;
            btnEmployees.FlatAppearance.BorderSize = 0;
            btnEmployees.FlatAppearance.MouseDownBackColor = Color.White;
            btnEmployees.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
            btnEmployees.FlatStyle = FlatStyle.Flat;
            btnEmployees.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
 //           btnEmployees.Image = Properties.Resources.employees_woman_man;
            btnEmployees.Location = new Point(0, 0);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(192, 43);
            btnEmployees.TabIndex = 6;
            btnEmployees.Text = "Empleados";
            btnEmployees.TextAlign = ContentAlignment.MiddleLeft;
            btnEmployees.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Bottom;
//            pictureBox5.Image = Properties.Resources.logo;
            pictureBox5.Location = new Point(0, 424);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(192, 111);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            // 
            // helph
            // 
            helph.BackColor = Color.LightSteelBlue;
            helph.Controls.Add(btnInfo);
            helph.Controls.Add(btnHelp);
            helph.Controls.Add(pictureBox4);
            helph.Location = new Point(4, 44);
            helph.Name = "helph";
            helph.Size = new Size(192, 535);
            helph.TabIndex = 3;
            helph.Text = "Ayuda";
            // 
            // btnInfo
            // 
            btnInfo.FlatAppearance.BorderColor = Color.White;
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatAppearance.MouseDownBackColor = Color.White;
            btnInfo.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            btnInfo.Image = Properties.Resources.info;
            btnInfo.Location = new Point(0, 52);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(192, 43);
            btnInfo.TabIndex = 7;
            btnInfo.Text = "Informacion";
            btnInfo.TextAlign = ContentAlignment.MiddleLeft;
            btnInfo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnHelp
            // 
            btnHelp.FlatAppearance.BorderColor = Color.White;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatAppearance.MouseDownBackColor = Color.White;
            btnHelp.FlatAppearance.MouseOverBackColor = Color.DarkTurquoise;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
//            btnHelp.Image = Properties.Resources.interrogation;
            btnHelp.Location = new Point(-1, 3);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(192, 43);
            btnHelp.TabIndex = 6;
            btnHelp.Text = "Ayuda";
            btnHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnHelp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Bottom;
  //          pictureBox4.Image = Properties.Resources.logo;
            pictureBox4.Location = new Point(0, 424);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(192, 111);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // tabSelectorMenu
            // 
            tabSelectorMenu.BaseTabControl = tabControlMenu;
            tabSelectorMenu.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            tabSelectorMenu.Depth = 0;
            tabSelectorMenu.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            tabSelectorMenu.Location = new Point(264, 27);
            tabSelectorMenu.MouseState = MaterialSkin.MouseState.HOVER;
            tabSelectorMenu.Name = "tabSelectorMenu";
            tabSelectorMenu.Size = new Size(827, 31);
            tabSelectorMenu.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            AutoScroll = true;
            ClientSize = new Size(1200, 650);
            Controls.Add(tabSelectorMenu);
            Controls.Add(pnlPrincipal);
            ForeColor = Color.Black;
            Name = "frmPrincipal";
            Sizable = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Sistema De Facturacion";
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            panel1.ResumeLayout(false);
            tabControlMenu.ResumeLayout(false);
            principal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tables.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            billing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            security.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            helph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialTabControl tabControlMenu;
        private TabPage principal;
        private TabPage tables;
        private TabPage billing;
        private TabPage security;
        private TabPage helph;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorMenu;
        private PictureBox pictureBox1;
        private Button btnLogout;
        private Button btnClients;
        private Button btnProducts;
        private Button btnCategories;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Button btnBills;
        private Button btnReports;
        private Button btnRoles;
        private Button btnEmployees;
        private Button btnInfo;
        private Button btnHelp;
        private Button btnSecurity;
        private Panel pnlContainer;
    }
}