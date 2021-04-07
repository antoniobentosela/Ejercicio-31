using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            char respuesta = 's';

            while(respuesta == 's'){

                Console.WriteLine("Continuar? S/N");
                if(!ValidarRespuesta(Convert.ToChar(Console.ReadLine())) == true)
                {
                    respuesta = 'n';
                }
            }
        }

        public static bool ValidarRespuesta(char valor)
        {
            if(valor == 's')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
