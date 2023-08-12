using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class CalculadoraBasica
    {
        public static double Calcular(int opc) {
            double result=0, num1, num2;
            Console.WriteLine("Digita el primer número: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digita el segundo número: ");
            num2 = Convert.ToDouble(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    result = num1 + num2;
                    break;
                case 2:
                    result = num1 - num2;
                    break;
                case 3:
                    result = num1 * num2;
                    break;
                case 4:
                    if (num2 == 0)
                        Console.WriteLine("No se puede dividir sobre 0");
                    else
                        result = num1 / num2;
                    break;
                default:
                        Console.WriteLine("¡Opcion no valida!");
                    break;
            }
            return result;
        }
    }
}
