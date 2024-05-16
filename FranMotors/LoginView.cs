using Domain.Users.Authentication;
using GUI_MODERNISTA;
//using Presentacion;

namespace FranMotors
{
    public partial class LoginView : Form
    {

        private ProgressBar loadingForm;
        public LoginView()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private async void btnIniciarSesion_Click(object sender, EventArgs e)
        {

            loadingForm = new ProgressBar();
            loadingForm.Show();

            bool authenticationResult = await Loged();

            loadingForm.Close();

            if (authenticationResult)
            {
                VistaPrincipalView vistaPrincipal = new VistaPrincipalView();
                this.Hide();
                vistaPrincipal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<bool> Loged()
        {
            int totalSteps = 100; 
            int totalProcessTimeMs = totalSteps * 20; 

            int progressBarDelay = totalProcessTimeMs / totalSteps;

            int progress = 0;

            for (int i = 0; i <= totalSteps; i++)
            {
                loadingForm.UpdateProgress(progress);
                progress++;

                await Task.Delay(progressBarDelay);
            }

            bool isAuthenticated = AuthUser.Login(tbUsuario.Text, tbPassword.Text);

            loadingForm.UpdateProgress(100);

            return isAuthenticated;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
