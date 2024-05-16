using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using FranMotors;

namespace GUI_MODERNISTA
{
    public partial class VistaPrincipalView : Form
    {
        public VistaPrincipalView()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            Rectangle workingArea = Screen.GetWorkingArea(this);

            this.MaximumSize = new Size(workingArea.Width, workingArea.Height);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btninicio_Click(null, e);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = true;
        }

        private void btnrptventa_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new UsersView());
            btnUsuarios.BackColor = Color.Red;
            btnClientes.BackColor = Color.Transparent;
            btnMotos.BackColor = Color.Transparent;
            btnMantenimiento.BackColor = Color.Transparent;
            btnProductos.BackColor = Color.Transparent;
        }

        private void btnrptcompra_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btnrptpagos_Click(object sender, EventArgs e)
        {
            SubmenuReportes.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            UserControl fh = formhija as UserControl;

            fh.Dock = DockStyle.Fill;

            this.panelContenedor.Controls.Add(fh);

            fh.Show();

        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ProductosView());
            btnProductos.BackColor = Color.Red;
            btnMantenimiento.BackColor = Color.Transparent;
            btnMotos.BackColor = Color.Transparent;
            btnClientes.BackColor = Color.Transparent;
            btnUsuarios.BackColor = Color.Transparent;
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new InicioView());
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new MantenimientosView());
            btnMantenimiento.BackColor = Color.Red;
            btnClientes.BackColor = Color.Transparent;
            btnMotos.BackColor = Color.Transparent;
            btnProductos.BackColor = Color.Transparent;
            btnUsuarios.BackColor = Color.Transparent;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new ClientesView());
            btnClientes.BackColor = Color.Red;
            btnMotos.BackColor = Color.Transparent;
            btnMantenimiento.BackColor = Color.Transparent;
            btnProductos.BackColor = Color.Transparent;
            btnUsuarios.BackColor = Color.Transparent;
        }

        private void btnMotos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new MotosView());
            btnMotos.BackColor = Color.Red;
            btnClientes.BackColor = Color.Transparent;
            btnMantenimiento.BackColor = Color.Transparent;
            btnProductos.BackColor = Color.Transparent;
            btnUsuarios.BackColor = Color.Transparent;
        }

        private void btnClientes_MouseLeave(object sender, EventArgs e)
        {
        }
    }
}
