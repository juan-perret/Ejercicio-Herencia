using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
    internal class AiresAcondicionados : Productos
    {
        public string TipoAire { get; set; }
        public int Frigorias { get; set; }

        Productos producto = new Productos();
        public override double CalcularPromocion(int codigoProducto)
        {
            double resultado = 0;
            if (codigoProducto== producto.CodigoProducto&& Frigorias=>3200 && CalcularGarantia=>1)
	        {
                resultado= producto.PrecioLista*0.08;
	        }
            return resultado;
        }
    }
}
