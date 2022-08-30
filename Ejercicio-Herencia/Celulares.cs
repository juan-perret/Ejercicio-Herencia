using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
    internal class Celulares:Productos
    {
        public int VelocidadProcesador { get; set; }
        public int Almacenamiento { get; set; }
        public string SistemaOperativo { get; set; }

        Productos producto = new Productos();
        public override double CalcularPromocion()
        {
            decimal precioConPromocion = 0;
            if (CalcularGarantia() > 2 && SistemaOperativo == "Android")
            {
                precioConPromocion= producto.PrecioLista-(producto.PrecioLista*0.1);
            }
            return precioConPromocion;
        }
    }
}
