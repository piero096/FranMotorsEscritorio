using Domain.Productos;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FranMotors
{
    public partial class MantenimientosView : UserControl
    {
        private decimal totalTemp;
        public MantenimientosView()
        {
            InitializeComponent();
            CargarProductos();
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

        private void dgDetalleMantenimiento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductoService productoService = new ProductoService();

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgProductos.Rows[e.RowIndex];

                int idProducto = Convert.ToInt32(selectedRow.Cells[0].Value);
                productoService.ActualizarStock(idProducto, 1);

                // Agrega las columnas del DataGridView de productos al DataGridView de detalle si aún no se han agregado
                if (dgDetalleMantenimiento.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn column in dgProductos.Columns)
                    {
                        DataGridViewColumn newColumn = dgDetalleMantenimiento.Columns[dgDetalleMantenimiento.Columns.Add(column.Name, column.HeaderText)];
                        newColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                    // Agrega la columna de botón eliminar
                    DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
                    deleteButtonColumn.HeaderText = "Eliminar";
                    deleteButtonColumn.Name = "Eliminar";
                    deleteButtonColumn.Text = "Eliminar";
                    deleteButtonColumn.UseColumnTextForButtonValue = true;
                    dgDetalleMantenimiento.Columns.Add(deleteButtonColumn);
                }

                // Clona la fila seleccionada y la agrega al DataGridView de detalle
                DataGridViewRow newRow = (DataGridViewRow)selectedRow.Clone();
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    newRow.Cells[cell.ColumnIndex].Value = cell.Value;
                }
                dgDetalleMantenimiento.Rows.Add(newRow);

                // Oculta la tercera columna (índice 2) del DataGridView de detalle
                dgDetalleMantenimiento.Columns[2].Visible = false;

                // Calcula el total de la columna PrecioUnidad
                CalcularTotalPrecioUnidad();
                CargarProductos();
            }
        }




        private void CalcularTotalPrecioUnidad()
        {
            // Inicializa la variable para almacenar la suma
            decimal total = 0;

            // Busca y elimina cualquier fila existente que contenga el total
            foreach (DataGridViewRow row in dgDetalleMantenimiento.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == "Total")
                {
                    dgDetalleMantenimiento.Rows.Remove(row);
                    break; // Sale del bucle ya que se encontró y eliminó la fila del total
                }
            }

            // Recorre todas las filas del DataGridView de detalle para calcular el nuevo total
            foreach (DataGridViewRow row in dgDetalleMantenimiento.Rows)
            {
                // Evita procesar filas eliminadas (por si acaso)
                if (row.IsNewRow)
                {
                    continue;
                }

                // Obtiene el valor de la celda en la columna "PrecioUnidad"
                if (row.Cells[3].Value != null)
                {
                    decimal precioUnidad;
                    if (decimal.TryParse(row.Cells[3].Value.ToString(), out precioUnidad))
                    {
                        // Suma el valor al total
                        total += precioUnidad;
                    }
                }

                
            }

            // Agrega una fila al final con el total de la suma
            DataGridViewRow totalRow = new DataGridViewRow();
            totalRow.CreateCells(dgDetalleMantenimiento);
            totalRow.Cells[1].Value = "Total";
            totalRow.Cells[dgDetalleMantenimiento.Columns[3].Index].Value = total;
            dgDetalleMantenimiento.Rows.Add(totalRow);


            lbPrecioTotal.Text = total.ToString();
            totalTemp = total;


            
            foreach (DataGridViewRow row in dgDetalleMantenimiento.Rows)
            {
                if (row.Cells[1].Value != null && row.Cells[1].Value.ToString() == "Total")
                {
                    totalRow = row;
                    break; // Salir del bucle si se encuentra la fila "Total"
                }
            }


            foreach (DataGridViewCell cell in totalRow.Cells)
            {
                // Verificar si la celda es de la columna "Eliminar"
                if (cell.OwningColumn.Name == "Eliminar")
                {
                    // Ocultar la columna "Eliminar" solo en la fila "Total"
                    cell.OwningColumn.Visible = false;
                    break; // Salir del bucle si se oculta la columna "Eliminar"
                }
            }
        }

        private void tbManoObra_TextChanged(object sender, EventArgs e)
        {
            if (tbManoObra.Text == "")
            {
                lbPrecioTotal.Text = totalTemp.ToString();
            }
        }

        private void tbManoObra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                decimal totalManoObra;


                // Intenta convertir el texto a decimal
                if (decimal.TryParse(tbManoObra.Text, out totalManoObra))
                {
                    // Guarda el valor original de lbPrecioTotal
                    decimal precioTotalOriginal = decimal.Parse(lbPrecioTotal.Text);

                    // Resta el valor de totalManoObra del lbPrecioTotal si es diferente de cero
                    if (totalManoObra != 0)
                    {
                        lbPrecioTotal.Text = (precioTotalOriginal + totalManoObra).ToString(); // Resta en lugar de sumar
                    }

                }

            }
        }

        private void dgDetalleMantenimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica si se hizo clic en una celda que contiene un botón y el índice de fila es válido
            if (e.RowIndex >= 0 && e.ColumnIndex == dgDetalleMantenimiento.Columns["Eliminar"].Index)
            {
                // Obtiene el ID del producto de la fila seleccionada
                DataGridViewRow selectedRow = dgDetalleMantenimiento.Rows[e.RowIndex];
                int idProducto = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                // Elimina la fila del DataGridView
                dgDetalleMantenimiento.Rows.RemoveAt(e.RowIndex);

                // Regresa el stock del producto eliminado
                ProductoService productoService = new ProductoService();
                productoService.RegresarStock(idProducto, 1);

                // Vuelve a calcular el total después de eliminar la fila
                CalcularTotalPrecioUnidad();
                CargarProductos();
            }
        }



        //private void btnCrear_Click(object sender, EventArgs e)
        //{
        //    TextBox nuevoTextBox = new TextBox();

        //    nuevoTextBox.Name = "textBox" + (Controls.OfType<TextBox>().Count() + 1);

        //    nuevoTextBox.Location = new Point(20, 20 + (nuevoTextBox.Height + 5) * Controls.OfType<TextBox>().Count());
        //    nuevoTextBox.Size = new Size(200, 20);

        //    Controls.Add(nuevoTextBox);
        //}
    }
}
