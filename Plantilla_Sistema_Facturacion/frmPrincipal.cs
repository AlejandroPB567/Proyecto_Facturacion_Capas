using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Plantilla_Sistema_Facturacion
{
    public partial class frmPrincipal : MaterialForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            frmClient frmCliente = new frmClient();
            OpenForm(frmCliente);
        }

        private void OpenForm(Form formHijo)
        {
            if (this.pnlContainer.Controls.Count > 0)
            {
                this.pnlContainer.Controls.RemoveAt(0);
            }
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.pnlContainer.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProducts frmCliente = new frmProducts();
            OpenForm(frmCliente);
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            frmCategorias frmCategorias = new frmCategorias();
            OpenForm(frmCategorias);
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            frmBillManager frmBillM = new frmBillManager();
            OpenForm(frmBillM);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            FrmInformes frmReports = new FrmInformes();
            OpenForm(frmReports);
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            FrmEmployees frmEmployees = new FrmEmployees();
            OpenForm(frmEmployees);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            FrmRoles frmRoles = new FrmRoles();
            OpenForm(frmRoles);
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            FrmSistemUsers frmSecurity = new FrmSistemUsers();
            OpenForm(frmSecurity);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            FrmHelp frmHelp = new FrmHelp();
            OpenForm(frmHelp);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            FrmInfo frmInfo = new FrmInfo();
            OpenForm(frmInfo);
        }
    }
}
