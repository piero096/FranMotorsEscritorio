using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Clientes.Repositories
{
    internal interface IClienteRepository
    {
        void CrearCliente(Cliente cliente);
        List<Cliente> ObtenerTodosLosClientes();
        void ActualizarCliente(int idCliente, Cliente cliente);
        void EliminarCliente(int id);
        Cliente ObtenerClientePorId(int id);
        Cliente ObtenerCliente(string dato);

    }
}
