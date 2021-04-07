using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {   
        public static string DecimalBinario(int a)
        {
            string binario = "";

            if (a > 0)
            {
                
                while (a > 0)
                {
                    if (a % 2 == 0)
                    {
                        binario = "0" + binario;
                    }
                    else
                    {
                        binario = "1" + binario;
                    }
                    a = (int)(a / 2);
                }
                Console.WriteLine(binario);
            }
            else
            {
                if (a == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine("Ingrese solo as positivos");
                }
            }

            return binario;

        }

        public static int BinarioDecimal(string binario)
        {
            int numero = 0;
            int digito = 0;
            const int DIVISOR = 10;
           
            int a = Convert.ToInt32(binario);
            

            for (long i = a, j = 0; i > 0; i /= DIVISOR, j++)
            {
                digito = (int)i % DIVISOR;
                if (digito != 1 && digito != 0)
                {
                    return -1;
                }
                numero += digito * (int)Math.Pow(2, j);
            }

            return numero;

        }


    }
}
