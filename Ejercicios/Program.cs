using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuidad=true;
            string rta;
            while (continuidad == true) { 
                // - - - - Ejercicio de sumar matrices
                //int[,] matrizA = { { 1, 2 }, { 3, 4 } };
                //int[,] matrizB = { { 5, 6 }, { 7, 8 } };

                //int[,] resultadoMatrices = SumaMatrices.SumarMatrices(matrizA, matrizB);

                // - - - - Ejercicio de Factorial
                //int num;
                //Console.WriteLine("Ingresa el número para calcular el factoriaL: ");
                //num = Convert.ToInt32(Console.ReadLine());
                //int resultado1 = Factorial.CalcularFactorial(num);
                //Console.WriteLine("El resultado del factorial es: "+resultado1);

                // - - - - Ejercicio Numero Primo
                //int num;
                //Console.WriteLine("Ingresa el número para saber si es primo: ");
                //num = Convert.ToInt32(Console.ReadLine());
                //bool result = NumeroPrimo.EsPrimo(num);
                //string res = result == true ? "es un numero Primo" : "no es un numero Primo";
                //Console.WriteLine($"El numero { num } {res}");

                // - - - - Ejercicio Numero Armstrong
                int num;
                Console.WriteLine("Ingresa el número para saber si es un numero Armstrong: ");
                num = Convert.ToInt32(Console.ReadLine());
                bool result = NumeroArmstrong.EsNumeroArmstrong(num);
                string res = result == true ? "es un numero Armstrong" : "no es un numero Armstrong";
                Console.WriteLine($"El numero { num } {res}");

                // - - Finaliza el o repite la ejecucion
                Console.WriteLine("¿Desea realizar otra operación? S/N");
                rta = Console.ReadLine();
                if (rta == "S" || rta == "s") { continuidad = true; }
                else{ Console.WriteLine("Gracias por utilizar el programa\n¡Ten un gran dia! :D"); continuidad = false; }
            }Console.ReadKey();
        }
    }
}
