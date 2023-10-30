using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2pr.__.Servicios
{
    internal class MenuImplementacion
    {
        internal class OperacionesImplementacion : OperacionesInterfaz
        {


            public void operacion(int numInt, double numDouble)
            {
                ///<sumary>
                ///Metodo que se encargara del calculo
                ///<author>251023 - awb</author>
                ///</sumary>
                double multiplicacion = numDouble;
                int i;
                for (i = 0; i <= numInt; i++)
                {
                    multiplicacion = multiplicacion * numDouble;
                    Console.WriteLine(multiplicacion);
                }
                //double operacion = Math.Pow(numDouble, numInt);
                //Console.WriteLine("La operacion da como resultado: " + operacion);
            }

            public double peticionDouble()
            {
                throw new NotImplementedException();
            }

            public int peticionInt()
            {
                throw new NotImplementedException();
            }
        }
    }

}
}
