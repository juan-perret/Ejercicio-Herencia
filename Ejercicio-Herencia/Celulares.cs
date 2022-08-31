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

        public override double CalcularPromocion(int codigoProducto)
        {
            double result = 0;
            if (codigoProducto== producto.CodigoProducto&& SistemaOperativo=="Android" && CalcularGarantia>2)
	        {
                result = producto.PrecioLista * 0.1;
	        }
            return result;
        }
    }
}
