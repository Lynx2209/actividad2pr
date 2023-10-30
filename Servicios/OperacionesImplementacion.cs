using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2pr.__.Servicios
{
    internal class OperacionesImplementacion : OperacionesInterfaz
    {
        ///<sumary>
        ///Metodo que se encargara de la peticion de variables 
        ///<author>251023 - JL </author>
        ///</sumary>
        public int peticionInt()
        {
            Console.WriteLine("Escriba un numero Int: ");
            int numeroInt = Convert.ToInt32(Console.ReadLine());
            return numeroInt;
        }
        public double peticionDouble()
        {
            Console.WriteLine("Escriba un numero Double: ");
            double numeroDouble = Convert.ToDouble(Console.ReadLine());
            return numeroDouble;
        }

        public void operacion(int numeroInt, double numeroDouble)
        {
            throw new NotImplementedException();
        }
    }
}