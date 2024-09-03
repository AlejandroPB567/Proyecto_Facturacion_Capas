namespace Plantilla_Sistema_Facturacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmppal = new FrmPrincipal();
            this.Hide(); // Ocultamos el formulario login
            frmPrincipal.Show();
        }
    }
}
