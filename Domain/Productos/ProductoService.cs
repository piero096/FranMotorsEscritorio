using Common.Models;
using Connection;
using Domain.Productos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Productos
{
    public class ProductoService : IProductoRepository
    {
        private readonly ConnectionContext context;
        public ProductoService()
        {
            context = new ConnectionContext();
        }
        public void ActualizarProducto(int idProducto, Producto producto)
        {
            var produc = context.Producto.Find(idProducto);
            produc.Nombre = producto.Nombre;
            produc.Stock = producto.Stock;
            produc.PrecioUnidad = producto.PrecioUnidad;

            context.SaveChanges();
        }

        public void CrearProducto(Producto producto)
        {
            context.Producto.Add(producto);
            context.SaveChanges();
        }

        public void EliminarProducto(int id)
        {
            var productoExistente = context.Producto.Find(id);
            context.Producto.Remove(productoExistente);
            context.SaveChanges();
        }

        public Producto ObtenerProducto(string dato)
        {
            return context.Producto
                .Where(o => o.Nombre.Equals(dato)  )
                .FirstOrDefault();
        }

        public Producto ObtenerProductoPorId(int id)
        {
            return context.Producto
                .Where(o => o.Id == id).FirstOrDefault();
        }

        public List<Producto> ObtenerTodosLosProductos()
        {
            return context.Producto.ToList();
        }

        public void ActualizarStock(int Id, int cantidad)
        {
            var producto = context.Producto.Find(Id);
            producto.Stock -= cantidad;
            context.SaveChanges();
        }

        public void RegresarStock(int Id, int cantidad)
        {
            var producto = context.Producto.Find(Id);
            producto.Stock += cantidad;
            context.SaveChanges();
        }
    }
}
