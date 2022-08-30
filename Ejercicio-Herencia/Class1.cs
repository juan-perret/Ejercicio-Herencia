using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
    public class Class1
    {
        List<Productos> listaProductos = new List<Productos>();

        public decimal CalcularPromocion(int codProducto)
        {
            foreach (Productos producto in listaProductos)
            {
                List<Productos> listaFiltrada= listaProductos.FindAll(x=>x.CodigoProducto == codProducto);
                if (producto.)
                {

                }
            }
        }
    }
}
