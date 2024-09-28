using Capa_LogicaNegocios;
using Newtonsoft.Json;
using System.Data;

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
            if(txtUser.Text != "" &&  txtPassword.Text != string.Empty)
            {
                ValidarUsuario objValidar = new ValidarUsuario();
                objValidar.StrUsuario = txtUser.Text;
                objValidar.StrClave = txtPassword.Text;
                objValidar.ValidateUser();
                if (objValidar.IdEmpleado != 0 )
                {
                    MessageBox.Show("Datos validos");
                    frmPrincipal frm = new frmPrincipal();
                    this.Hide();
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("Datos invalidos");
                    txtPassword.Text = "";
                    txtUser.Text = "";
                    txtUser.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingresa Usuario y contraseña");
            }
        }
        
       

    }
}
