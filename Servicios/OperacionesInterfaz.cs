using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2pr.__.Servicios
{
    internal interface OperacionesInterfaz
    {
        public int peticionInt();

        public double peticionDouble();
        void operacion(int numeroInt, double numeroDouble);
    }
}

