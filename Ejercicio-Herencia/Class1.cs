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

        public int CalcularIndexProducto(int codProducto)
        {
            foreach (Productos producto in listaProductos)
            {
                int index= listaProductos.FindIndex(x=>x.CodigoProducto == codProducto);
            }
            return index;
        }
    }
}
