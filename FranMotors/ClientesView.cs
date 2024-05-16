using Common.Models;
using Domain.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace FranMotors
{
    public partial class ClientesView : UserControl
    {
        public ClientesView()
        {
            InitializeComponent();
            CargarClientes();
            EstadoBotones();
        }

        private void EstadoBotones()
        {
            if (idCliente.Text == "IdCliente")
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



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClientesView_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text == "" || tbApellidos.Text == "" || tbDocumento.Text == "" || tbCorreo.Text == "" || tbTelefono.Text == "")
            {
                MessageBox.Show("Hay campos vacios, por favor verificar");
            }
            else
            {

                try
                {
                    ClienteService cliService = new ClienteService();

                    Cliente clie = new Cliente();

                    clie.Nombres = tbNombre.Text.Trim();
                    clie.Apellidos = tbApellidos.Text.Trim();
                    clie.Documento = tbDocumento.Text.Trim();
                    clie.Email = tbCorreo.Text.Trim();
                    clie.Telefono = tbTelefono.Text.Trim();
                    cliService.CrearCliente(clie);

                    MessageBox.Show("Cliente registrado correctamente!!");

                    Limpiar();
                    CargarClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar datos {ex.Message}");
                }
            }
        }

        private void Limpiar()
        {
            tbNombre.Text = "";
            tbApellidos.Text = "";
            tbDocumento.Text = "";
            tbCorreo.Text = "";
            tbTelefono.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteService clienteService = new ClienteService();

                Cliente cliente = new Cliente()
                {
                    Id = int.Parse(idCliente.Text),
                    Nombres = tbNombre.Text,
                    Apellidos = tbApellidos.Text,
                    Documento = tbDocumento.Text,
                    Email = tbCorreo.Text,
                    Telefono = tbTelefono.Text,
                };

                if (cliente != null)
                {
                    clienteService.ActualizarCliente(int.Parse(idCliente.Text), cliente);
                    MessageBox.Show("Datos del cliente editados correctamente!!");
                    Limpiar();
                    CargarClientes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron editar los datos del cliente...");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClienteService clienteService = new ClienteService();

            //Guid idIncidencia = Guid.Parse(TbIdIncidencia.Text);

            if (idCliente.Text != "IdCliente")
            {
                clienteService.EliminarCliente(int.Parse(idCliente.Text));
                MessageBox.Show("Cliente eliminado!!");
                Limpiar();
                CargarClientes();
            }
            else
            {
                MessageBox.Show("Seleccione un Cliente a eliminar...");
            }
        }

        private void CargarClientes()
        {
            ClienteService clienteService = new ClienteService();

            var clientes = clienteService.ObtenerTodosLosClientes();

            dgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgClientes.Dock = DockStyle.Fill;

            dgClientes.DataSource = clientes;

            dgClientes.Columns[0].Visible = false;

        }

        private void dgClientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView != null && dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                Cliente cliente = selectedRow.DataBoundItem as Cliente;

                if (cliente != null)
                {
                    CargarDatosCliente(cliente.Id);
                    EstadoBotones();
                }
            }
        }

        private void CargarDatosCliente(int Id)
        {
            ClienteService cliente = new ClienteService();

            var cli = cliente.ObtenerClientePorId(Id);


            if (cli != null)
            {
                idCliente.Text = (cli.Id).ToString();
                tbNombre.Text = cli.Nombres;
                tbApellidos.Text = cli.Apellidos;
                tbDocumento.Text = cli.Documento;
                tbCorreo.Text = cli.Email;
                tbTelefono.Text = cli.Telefono;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            idCliente.Text = "IdCliente";
            EstadoBotones();
        }



        //private void dgClientes_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        //{

        //}

        //private void dgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}
    }
}
