using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class AdivinarNumero
    {
        public static void adivinanza() {
            //generar numero aleatorio
            int min = 1, max=100, numIntentos = 1;
            Random rnd = new Random();
            int numGenerado = rnd.Next(min, max);
            bool ganador = false;
            
            while (ganador == false) {
                //pedir ingresar el numero
                int num = Convert.ToInt32(Console.ReadLine());
                //comparar
                if (num == numGenerado)
                {
                    Console.WriteLine($"Ganaste! :D, el numero era: {numGenerado}\nGracias por jugar\nNúmero de intentos: {numIntentos}");
                    ganador = true;
                }
                else if (num < numGenerado) {
                    Console.WriteLine($"El numero es mayor");
                    ganador = false;
                }
                else if (num > numGenerado)
                {
                    Console.WriteLine($"El numero es menor");
                    ganador = false;
                }
                numIntentos += 1;
            }
        }
    }
}
