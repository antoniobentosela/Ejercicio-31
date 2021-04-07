using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador a = new Sumador();
            
            //llamada al operador explicito.
            int dato = (int)a;

            //dato vale lo mismo que cantidadDeSumas.
            Console.WriteLine(dato);
            Console.ReadLine();

        }
    }
}
