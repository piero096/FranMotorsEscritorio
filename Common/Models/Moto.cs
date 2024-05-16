using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Moto
    {
        public int Id { get; set; }
        public int Id_Cliente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Motor {  get; set; }
        public string Placa { get; set; }
        public string TarjetaPropiedad { get; set; }
        public Cliente Cliente { get; set; }
    }
}
