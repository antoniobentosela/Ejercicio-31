﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    public class Sumador
    {
        private int cantidadDeSumas;

        public Sumador (int cantidadDeSumas)
        {
            this.cantidadDeSumas = cantidadDeSumas;
        }

        public Sumador()
            :this(0)
        {

        }

        public long Sumar(long a, long b)
        {
            cantidadDeSumas++;

            return a + b;
        }

        public string Sumar(string a, string b)
        {
            cantidadDeSumas++;
            string concatenado;

            concatenado = a + b;

            return concatenado;
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadDeSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
           if(s1.cantidadDeSumas == s2.cantidadDeSumas)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadDeSumas + s2.cantidadDeSumas;

        }

    }
}
