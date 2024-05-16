using Common.Models;
using Connection;
using Domain.Clientes.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Clientes
{
    public class ClienteService : IClienteRepository
    {
        private readonly ConnectionContext context;
        public ClienteService()
        {
            context = new ConnectionContext();
        }
        public void ActualizarCliente(int idCliente, Cliente cliente)
        {
            var clie = context.Cliente.Find(idCliente);
            clie.Nombres = cliente.Nombres;
            clie.Apellidos = cliente.Apellidos;
            clie.Documento = cliente.Documento;
            clie.Telefono = cliente.Telefono;
            clie.Email = cliente.Email;

            context.SaveChanges();
        }

        public void CrearCliente(Cliente cliente)
        {
            context.Cliente.Add(cliente);
            context.SaveChanges();
        }

        public void EliminarCliente(int id)
        {
            var clienteExistente = context.Cliente.Find(id);
            context.Cliente.Remove(clienteExistente);
            context.SaveChanges();
        }

        public  List<Cliente> ObtenerTodosLosClientes()
        {
            return context.Cliente.ToList();
        }

        public Cliente ObtenerClientePorId(int id)
        {
            return context.Cliente
                .Where(o => o.Id == id).FirstOrDefault();
        }

        public Cliente ObtenerCliente(string dato)
        {
            return context.Cliente
                .Where(o => o.Nombres.Equals(dato) || o.Apellidos.Contains(dato) || o.Documento.Equals(dato) ||o.Telefono.Equals(dato))
                .FirstOrDefault();


        }
    }
}
