using Common.Models;
using Domain.Clientes;
using Domain.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace FranMotors
{
    public partial class ProductosView : UserControl
    {
        public ProductosView()
        {
            InitializeComponent();
            CargarProductos();
            EstadoBotones();
        }

        private void Limpiar()
        {
            IdProducto.Text = "IdProducto";
            tbNombreProducto.Text = "";
            tbStock.Text = "";
            tbPrecio.Text = "";
        }

        private void CargarProductos()
        {
            ProductoService productoService = new ProductoService();

            var productos = productoService.ObtenerTodosLosProductos();

            dgProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgProductos.Dock = DockStyle.Fill;

            dgProductos.DataSource = productos;

            dgProductos.Columns[0].Visible = false;
        }

        private void CargarDatosProducto(int Id)
        {
            ProductoService producto = new ProductoService();

            var prod = producto.ObtenerProductoPorId(Id);


            if (prod != null)
            {
                IdProducto.Text = (prod.Id).ToString();
                tbNombreProducto.Text = prod.Nombre;
                tbStock.Text = prod.Stock.ToString();
                tbPrecio.Text = prod.PrecioUnidad.ToString();
            }
        }

        private void EstadoBotones()
        {
            if (IdProducto.Text == "IdProducto")
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (tbNombreProducto.Text == "" || tbStock.Text == "" || tbPrecio.Text == "")
            {
                MessageBox.Show("Hay campos vacios, por favor verificar");
            }
            else
            {

                try
                {
                    ProductoService productoService = new ProductoService();

                    Producto prod = new Producto();

                    prod.Nombre = tbNombreProducto.Text.Trim();
                    prod.Stock = int.Parse(tbStock.Text);
                    prod.PrecioUnidad = decimal.Parse(tbPrecio.Text);
                    productoService.CrearProducto(prod);

                    MessageBox.Show("Producto registrado correctamente!!");

                    Limpiar();
                    CargarProductos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar datos {ex.Message}");
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                ProductoService productoService = new ProductoService();

                Producto producto = new Producto()
                {
                    Id = int.Parse(IdProducto.Text),
                    Nombre = tbNombreProducto.Text,
                    Stock = int.Parse(tbStock.Text),
                    PrecioUnidad = decimal.Parse(tbPrecio.Text),
                };

                if (producto != null)
                {
                    productoService.ActualizarProducto(int.Parse(IdProducto.Text), producto);
                    MessageBox.Show("Datos del producto editados correctamente!!");
                    Limpiar();
                    CargarProductos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron editar los datos del producto...");
            }
        }

        private void dgProductos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView != null && dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                Producto producto = selectedRow.DataBoundItem as Producto;

                if (producto != null)
                {
                    CargarDatosProducto(producto.Id);
                    EstadoBotones();
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ProductoService productoService = new ProductoService();

            //Guid idIncidencia = Guid.Parse(TbIdIncidencia.Text);

            if (IdProducto.Text != "IdProducto")
            {
                productoService.EliminarProducto(int.Parse(IdProducto.Text));
                MessageBox.Show("´Producto eliminado!!");
                Limpiar();
                CargarProductos();
            }
            else
            {
                MessageBox.Show("Seleccione un Producto a eliminar...");
            }
        }
    }
}
