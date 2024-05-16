using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Productos.Repositories
{
    internal interface IProductoRepository
    {
        void CrearProducto(Producto producto);
        List<Producto> ObtenerTodosLosProductos();
        void ActualizarProducto(int idProducto, Producto producto);
        void RegresarStock(int Id, int cantidad);
        void EliminarProducto(int id);
        Producto ObtenerProductoPorId(int id);
        Producto ObtenerProducto(string dato);
    }
}
