using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Moneda
    {
        public string monedaOrigen { get; set; }
        public string monedaDestino { get; set; }
        public string codMonedaOrigen { get; set; }
        public string codMonedaDestino { get; set; }
        public double TasaCambio { get; set; }
    }
    internal class ConversionMonedaDinamica
    {

        public static double Convertir(double monto)
        {
            //lista de monedas disponibles
            List<Moneda> monedas = new List<Moneda>
            {
                new Moneda { monedaOrigen = "Peso Colombiano", codMonedaOrigen = "COP", monedaDestino = "Dolar Canadiense", codMonedaDestino ="CAD", TasaCambio = 0.00034},
                new Moneda { monedaOrigen = "Dolar Canadiense", codMonedaOrigen = "CAD", monedaDestino = "Peso Colombiano", codMonedaDestino ="COP", TasaCambio = 2929.19},
                new Moneda { monedaOrigen = "Peso Colombiano", codMonedaOrigen = "COP", monedaDestino = "Euro", codMonedaDestino ="EUR", TasaCambio = 0.00023},
                new Moneda { monedaOrigen = "Euro", codMonedaOrigen = "EUR", monedaDestino = "Peso Colombiano", codMonedaDestino ="COP", TasaCambio = 4259.01},
                new Moneda { monedaOrigen = "Euro", codMonedaOrigen = "EUR", monedaDestino = "Dolar Canadiense", codMonedaDestino ="CAD", TasaCambio = 1.45},
                new Moneda { monedaOrigen = "Dolar Canadiense", codMonedaOrigen = "CAD", monedaDestino = "Euro", codMonedaDestino ="EUR", TasaCambio = 0.69},
                // . . . mas monedas
            };
            Console.WriteLine("= = =Monedas a cambiar = = =");
            for (int i = 0; i < monedas.Count; i++)
            {
                Console.WriteLine($"{i+1}. De {monedas[i].monedaOrigen} a {monedas[i].monedaDestino}");
            }
            int opc;
            do
            {
                Console.WriteLine("Selecciona método a cambiar:");
                if (int.TryParse(Console.ReadLine(), out opc) && opc >= 1 && opc <= monedas.Count)
                    break; 
                else
                    Console.WriteLine("Opción no válida. Ingresa un número válido.");
            } while (true);
            opc = opc - 1;
            //la opcion que selecciona va a ser igual a la posicion de la lista
            double resultado = monto * monedas[opc].TasaCambio;
            Console.WriteLine($"{monto} {monedas[opc].codMonedaOrigen} son {resultado} {monedas[opc].codMonedaDestino}");
            return resultado;
        }
    }
}
