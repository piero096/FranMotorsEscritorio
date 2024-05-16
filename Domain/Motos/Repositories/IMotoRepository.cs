using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Motos.Repositories
{
    internal interface IMotoRepository
    {
        void CrearMotos(Moto moto, int Id);
        void ActualizarMotos(int Id, Moto moto);
        List<Moto> ListarMotos();
        Task<List<Moto>> ListarMotoPorCliente(int Id);
        Moto ListarMotoPorClienteId(int Id);
        Moto ListarMotoPorId(int Id);
    }
}
