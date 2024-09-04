using Newtonsoft.Json;
using System.Data;

namespace Plantilla_Sistema_Facturacion
{
    public partial class frmLogin : Form
    {
        private const string FilePath = "Data/autenticacion.json"; // Ruta al archivo JSON
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
            try
            {
                // Leer el archivo JSON
                if (!File.Exists(FilePath))
                {
                    throw new FileNotFoundException("El archivo de autenticación no se encontró.");
                }

                var json = File.ReadAllText(FilePath);
                var datos = JsonConvert.DeserializeObject<Autenticacion>(json);

                // Obtener las credenciales ingresadas por el usuario
                string usuarioIngresado = txtUser.Text.Trim();
                string contraseñaIngresada = txtPassword.Text.Trim();

                // Verificar las credenciales
                if (usuarioIngresado == datos.usuario && contraseñaIngresada == datos.contraseña)
                {
                    // Credenciales correctas, mostrar el formulario principal
                    frmPrincipal frmppal = new frmPrincipal();
                    this.Hide(); // Ocultar el formulario de inicio de sesión
                    frmppal.Show();
                }
                else
                {
                    // Credenciales incorrectas
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos. Inténtelo de nuevo.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FileNotFoundException ex)
            {
                // Manejar la excepción si el archivo no se encuentra
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Clase para deserializar el archivo JSON
        private class Autenticacion
        {
            public string usuario { get; set; }
            public string contraseña { get; set; }
        }

    }
}
