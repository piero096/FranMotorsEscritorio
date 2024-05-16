using Common.Models;
using Domain.Mantenimientos.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mantenimientos
{
    public class MantenimientoService : IMantenimientoRepository
    {
        public void ActualizarManenimiento(int IdMantenimiento, Mantenimiento mantenimineto)
        {
            throw new NotImplementedException();
        }

        public void CrearMantenimiento(Mantenimiento mantenimiento)
        {
            throw new NotImplementedException();
        }

        public void EliminarMantenimiento(int id)
        {
            throw new NotImplementedException();
        }

        public Cliente ObtenerMantenimiento(string dato)
        {
            throw new NotImplementedException();
        }

        public List<Mantenimiento> ObtenerTodosLosManteniminetos()
        {
            throw new NotImplementedException();
        }
    }
}
