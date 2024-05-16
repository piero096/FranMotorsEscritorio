using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class Mantenimiento
    {
        public int id {  get; set; }
        public int Id_Moto { get; set; }
        public int Id_Producto { get; set; }
        public string MotivoIngreso { get; set; }
        public string DetalleReparacion { get; set; }
        public decimal PrecioManoObra { get; set; }
        public decimal PrecioTotal {  get; set; }
        public DateTime FechaMantenimiento { get; set; }
        public Moto moto { get; set; }
        public Producto producto { get; set; }
    }
}
