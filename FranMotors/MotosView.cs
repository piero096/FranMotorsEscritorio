using Common.Models;
using Domain.Clientes;
using Domain.Motos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FranMotors
{
    public partial class MotosView : UserControl
    {
        public MotosView()
        {
            InitializeComponent();
            CargarMotos();
            EstadoBotones();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbTarjetaPropiedad_TextChanged(object sender, EventArgs e)
        {

        }

        private void EstadoBotones()
        {
            if (IdMoto.Text == "IdMoto")
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

        private void CargarMotos()
        {
            MotoService motoService = new MotoService();

            var motos = motoService.ListarMotos();

            dgMotos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgMotos.Dock = DockStyle.Fill;

            // Limpiar filas existentes antes de agregar nuevas
            dgMotos.Rows.Clear();

            foreach (var item in motos)
            {
                dgMotos.Rows.Add(new object[] {
                item.Id,
                item.Id_Cliente,
                item.Marca,
                item.Modelo,
                item.Motor,
                item.Placa,
                item.TarjetaPropiedad,
                item.Cliente.Nombres + " " + item.Cliente.Apellidos,
        });
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (lbNombreCliente.Text == "NOMBRE DE CLIENTE" || tbMarca.Text == "" || tbModelo.Text == "" || tbMotor.Text == "" || tbPlaca.Text == ""
                || tbTarjetaPropiedad.Text == "")
            {
                MessageBox.Show("Hay campos vacios, por favor verificar");
            }
            else
            {
                try
                {
                    MotoService moto = new MotoService();


                    Moto mot = new Moto()
                    {
                        Id_Cliente = int.Parse(IdCliente.Text),
                        Marca = tbMarca.Text,
                        Modelo = tbModelo.Text,
                        Motor = tbMotor.Text,
                        Placa = tbPlaca.Text,
                        TarjetaPropiedad = tbTarjetaPropiedad.Text,
                    };

                    moto.CrearMotos(mot, int.Parse(IdCliente.Text));

                    CargarMotos();

                    Limpiar();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void Limpiar()
        {
            IdCliente.Text = "IdCliente";
            IdMoto.Text = "IdMoto";
            tbMarca.Text = "";
            tbModelo.Text = "";
            tbMotor.Text = "";
            tbPlaca.Text = "";
            tbTarjetaPropiedad.Text = "";
            EstadoBotones();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            ClienteService cliente = new ClienteService();
            MotoService moto = new MotoService();
            var id = cliente.ObtenerCliente(tbBuscar.Text);

            if (id != null)
            {
                IdCliente.Text = id.Id.ToString();
                lbNombreCliente.Text = $"{id.Nombres} {id.Apellidos}";

                //var mem = await membre.ListarMembresiaPorCliente(id.Id);
                //dgMembresias.ItemsSource = mem;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (lbNombreCliente.Text == "NOMBRE DE CLIENTE" || tbMarca.Text == "" || tbModelo.Text == "" || tbMotor.Text == "" || tbPlaca.Text == ""
                || tbTarjetaPropiedad.Text == "")
            {
                MessageBox.Show("Hay campos vacios, por favor verificar");
            }
            else
            {
                try
                {
                    MotoService moto = new MotoService();


                    Moto mot = new Moto()
                    {
                        Id_Cliente = int.Parse(IdCliente.Text),
                        Marca = tbMarca.Text,
                        Modelo = tbModelo.Text,
                        Motor = tbMotor.Text,
                        Placa = tbPlaca.Text,
                        TarjetaPropiedad = tbTarjetaPropiedad.Text,
                    };

                    moto.ActualizarMotos(int.Parse(IdMoto.Text), mot);
                    MessageBox.Show("Motocicleta actualizada exitosamente!!");

                    Limpiar();

                    CargarMotos();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }



        private void dgMotos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView != null && dataGridView.SelectedCells.Count > 0)
            {
                int columnIndex = dataGridView.SelectedCells[0].ColumnIndex;
                int rowIndex = dataGridView.SelectedCells[0].RowIndex;

                var cellValue = dataGridView.Rows[rowIndex].Cells[columnIndex].Value;
                if (cellValue != null && int.TryParse(cellValue.ToString(), out int id))
                {
                    CargarDatosMoto(id);
                    EstadoBotones();
                }
            }
        }

        private void CargarDatosMoto(int Id)
        {
            MotoService mot = new MotoService();

            var moto = mot.ListarMotoPorId(Id);


            if (moto != null)
            {
                IdMoto.Text = moto.Id.ToString();
                IdCliente.Text = moto.Cliente.Id.ToString();
                lbNombreCliente.Text = $"{moto.Cliente.Nombres} {moto.Cliente.Apellidos}";
                tbMarca.Text = moto.Marca;
                tbModelo.Text = moto.Modelo;
                tbMotor.Text = moto.Motor;
                tbPlaca.Text = moto.Placa;
                tbTarjetaPropiedad.Text = moto.TarjetaPropiedad;

            }

        }

        private void dgMotos_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MotoService motoService = new MotoService();


            if (IdMoto.Text != "IdMoto")
            {
                motoService.EliminarMoto(int.Parse(IdMoto.Text));
                MessageBox.Show("Motocicleta eliminada!!");

                CargarMotos();


                Limpiar();
            }
            else
            {
                MessageBox.Show("Seleccione una Moto a eliminar...");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
            
            EstadoBotones();
        }
    }
}
