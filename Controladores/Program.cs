using Actividad2pr.__.Servicios;


namespace Actividad2pr.__.controladores
{
    class program
    {
        public static void Main(string[] args)
        {
            ///<sumary>
            ///Creacion de objetos y y variables
            ///<author>251023 - awb</author>
            ///</sumary>
            OperacionesInterfaz MI = new OperacionesImplementacion();
            double numeroDouble = MI.peticionDouble();
            int numeroInt = MI.peticionInt();
            OperacionesInterfaz oi = new OperacionesImplementacion();
            oi.operacion(numeroInt, numeroDouble);
        }
    }
}




