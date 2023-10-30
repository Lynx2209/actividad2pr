using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2pr.__.Servicios
{
    internal interface MenuInterfaz
    {
        double peticionDouble();
        int peticionInt();

        internal interface OperacionesInterfaz
        {
            internal interface operacionInterfaz
            {
                public void operacion(int numInt, double numDouble);
            }
        }
    }
}

