using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class ConversionMoneda
    {
        public static double Convertir(double monto) {
            string[] monedasOrigen = new string[] { "Peso Colombiano" };
            string[] monedasDestino = new string[] { "Dolar Canadiense", "Peso Mexicano" , "Euro" };
            double[] tasaCambio = new double[] { 0.00025, 0.0043, 0.00023 };
            MostrarData(monedasOrigen);
            Console.WriteLine("Selecciona la moneda de origen");
            int opcionOrigen = Convert.ToInt32(Console.ReadLine()) - 1;
            MostrarData(monedasDestino);
            Console.WriteLine("Selecciona la moneda de destino");
            int opcionDestino = Convert.ToInt32(Console.ReadLine()) - 1;
            if (opcionOrigen < 0 || opcionOrigen >= monedasOrigen.Length || opcionDestino < 0 || opcionDestino >= monedasDestino.Length)
            {
                Console.WriteLine("Opción de moneda no válida.");
                return 0;
            }
            double conversion = monto * tasaCambio[opcionDestino];
            Console.WriteLine($"La cantidad equivalente en {monedasDestino[opcionDestino]} es: {conversion}");
            return conversion;

        }
        public static void MostrarData(string[] array) {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {array[i]}");
            }
        }
    }
}
