using Common.Models;
using Connection;
using Domain.Motos.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Motos
{
    public class MotoService : IMotoRepository
    {

        private readonly ConnectionContext context;
        public MotoService()
        {
            context = new ConnectionContext();
        }
        public void ActualizarMotos(int Id, Moto moto)
        {
            var mot = context.Moto.Find(Id);
            mot.Id_Cliente = moto.Id_Cliente;
            mot.Marca = moto.Marca;
            mot.Modelo = moto.Modelo;
            mot.Motor = moto.Motor;
            mot.Placa = moto.Placa;
            mot.TarjetaPropiedad = moto.TarjetaPropiedad;

            context.SaveChanges();
        }

        public void CrearMotos(Moto moto, int Id)
        {
            context.Moto.Add(moto);
            context.SaveChanges();
        }

        public List<Moto> ListarMotos()
        {
            var mot =  context.Moto
                .Include(o => o.Cliente)
                .ToList();

            return mot;
        }

        public Task<List<Moto>> ListarMotoPorCliente(int Id)
        {
            throw new NotImplementedException();
        }

        public Moto ListarMotoPorClienteId(int Id)
        {
            throw new NotImplementedException();
        }

        public Moto ListarMotoPorId(int Id)
        {
            return context.Moto.Include(o => o.Cliente).Where(o => o.Id == Id).FirstOrDefault();
        }

        public void EliminarMoto(int id)
        {
            var motoExistente = context.Moto.Find(id);
            context.Moto.Remove(motoExistente);
            context.SaveChanges();

        }
    }
}
