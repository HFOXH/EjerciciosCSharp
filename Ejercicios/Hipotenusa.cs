using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Hipotenusa
    {
        public static double CalcularHipotenusa(double c1, double c2) {
            double h = Math.Sqrt(Math.Pow(c1,2) + Math.Pow(c2, 2));
            return h;
        }
    }
}
