using Common.Models;
using Domain.Clientes;
using Domain.Users;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Core;
using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using User = Common.Models.User;

namespace FranMotors
{
    public partial class UsersView : UserControl
    {
        public UsersView()
        {
            InitializeComponent();
            CargarUsuarios();
            EstadoBotones();

            cbPuesto.SelectedIndex = 0;
            cbPuesto.DropDownStyle = ComboBoxStyle.DropDownList;

            // Deshabilita solo el primer ítem (el texto "Seleccionar")
            cbPuesto.Enabled = true; // Habilita el ComboBox


            cbEstado.SelectedIndex = 0;
            cbEstado.DropDownStyle = ComboBoxStyle.DropDownList;

            // Deshabilita solo el primer ítem (el texto "Seleccionar")
            cbEstado.Enabled = true; // Habilita el ComboBox
        }

        private void UsersView_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            idUsuario.Text = "IdUsuario";
            tbNombreUsuario.Text = "";
            tbContrasena.Text = "";
            tbNombres.Text = "";
            tbApellidos.Text = "";
            tbCorreo.Text = "";
            cbPuesto.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
            EstadoBotones();
        }

        private void EstadoBotones()
        {
            if (idUsuario.Text == "IdUsuario")
            {
                btnActualizar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            else
            {
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void CargarUsuarios()
        {
            UserService userService = new UserService();

            var usuarios = userService.ObtenerTodosLosUsuarios();

            dgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgUsuarios.Dock = DockStyle.Fill;

            dgUsuarios.DataSource = usuarios;

            dgUsuarios.Columns[0].Visible = false;

            dgUsuarios.CellFormatting += (sender, e) =>
            {
                if (e.Value != null && e.Value is bool)
                {
                    if ((bool)e.Value)
                    {
                        e.Value = "Activo";
                    }
                    else
                    {
                        e.Value = "Inactivo";
                    }
                    e.FormattingApplied = true;
                }
            };
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombreUsuario.Text == "" || tbContrasena.Text == "" || tbNombres.Text == "" || tbApellidos.Text == "" || tbCorreo.Text == "" ||
                (cbPuesto.SelectedItem != null && cbPuesto.SelectedItem.ToString() == "Seleccionar") || (cbEstado.SelectedItem != null && cbEstado.SelectedItem.ToString() == "Seleccionar"))
            {
                MessageBox.Show("Hay campos vacios, por favor verificar");
            }
            else
            {
                try
                {
                    UserService userService = new UserService();

                    Common.Models.User user = new Common.Models.User();

                    user.LoginName = tbNombreUsuario.Text.Trim();
                    user.Password = tbContrasena.Text.Trim();
                    user.Name = tbNombres.Text.Trim();
                    user.LastName = tbApellidos.Text.Trim();
                    user.Email = tbCorreo.Text.Trim();
                    user.Position = cbPuesto.SelectedItem.ToString();
                    user.Estado = (cbEstado.SelectedItem.ToString() == "Activo") ? true : false;

                    userService.CrearUsuario(user);

                    MessageBox.Show("Usuario registrado correctamente!!");

                    CargarUsuarios();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo registrar usuario {ex.Message}");
                }
            }
        }

        private void dgUsuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView != null && dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                User user = selectedRow.DataBoundItem as User;

                if (user != null)
                {
                    CargarDatosUsuarios(user.Id);
                    EstadoBotones();
                }
            }
        }

        private void CargarDatosUsuarios(int Id)
        {
            UserService usuario = new UserService();

            var usu = usuario.ObtenerUsuarioPorId(Id);


            if (usu != null)
            {
                idUsuario.Text = (usu.Id).ToString();
                tbNombreUsuario.Text = usu.LoginName;
                tbContrasena.Text = usu.Password;
                tbNombres.Text = usu.Name;
                tbApellidos.Text = usu.LastName;
                tbCorreo.Text = usu.Email;

                if (usu.Position != null)
                {
                    cbPuesto.SelectedItem = usu.Position;
                }

                if (usu.Estado != null)
                {
                    cbEstado.SelectedItem = usu.Estado.Value ? "Activo" : "Inactivo";
                }

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                UserService userService = new UserService();

                User user = new User()
                {
                    Id = int.Parse(idUsuario.Text),
                    LoginName = tbNombreUsuario.Text,
                    Password = tbContrasena.Text,
                    Name = tbNombres.Text,
                    LastName = tbApellidos.Text,
                    Email = tbCorreo.Text,
                    Position = cbPuesto.SelectedItem.ToString(),
                    Estado = (cbEstado.SelectedItem.ToString() == "Activo") ? true : false
                };

                if (user != null)
                {
                    userService.ActualizarUsuario(int.Parse(idUsuario.Text), user);
                    MessageBox.Show("Datos del Uusuario editados correctamente!!");
                    Limpiar();
                    CargarUsuarios();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron editar los datos del cliente...");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService();

            //Guid idIncidencia = Guid.Parse(TbIdIncidencia.Text);

            if (idUsuario.Text != "IdUsuario")
            {
                userService.EliminarUsuario(int.Parse(idUsuario.Text));
                MessageBox.Show("Usuario eliminado!!");
                Limpiar();
                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Seleccione un Usuario a eliminar...");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            idUsuario.Text = "IdUsuario";
            Limpiar();
            EstadoBotones();
        }
    }
}
