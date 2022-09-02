using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Herencia
{
    internal class FormasPagos
    {
        enum FormasPago : ushort
        {
            efectivo = 1,
            creditoEnTasa = 2,
            tarjetaCredito = 3,
        }
    }
}
