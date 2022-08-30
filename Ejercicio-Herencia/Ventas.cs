using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
    internal class Ventas
    {
        public int CodigoFactura { get; set; }
        public int Cuit { get; set; }
        public List<Productos> ProductosVendidos { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal ImporteVenta { get; set; }
        public int FormaDePago { get; set; }

    }
}
