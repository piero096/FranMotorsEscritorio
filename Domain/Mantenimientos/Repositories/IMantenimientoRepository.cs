using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mantenimientos.Repositories
{
    internal interface IMantenimientoRepository
    {
        void CrearMantenimiento(Mantenimiento mantenimiento);
        List<Mantenimiento> ObtenerTodosLosManteniminetos();
        void ActualizarManenimiento(int IdMantenimiento, Mantenimiento mantenimineto);
        void EliminarMantenimiento(int id);
        Cliente ObtenerMantenimiento(string dato);
    }
}
