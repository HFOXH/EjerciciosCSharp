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
                //int num;
                //Console.WriteLine("Ingresa el número para saber si es un numero Armstrong: ");
                //num = Convert.ToInt32(Console.ReadLine());
                //bool result = NumeroArmstrong.EsNumeroArmstrong(num);
                //string res = result == true ? "es un numero Armstrong" : "no es un numero Armstrong";
                //Console.WriteLine($"El numero { num } {res}");

                // - - - - Ejercicio Generar números Primos
                //int num;
                //Console.WriteLine("¿Cuantos numeros primos quieres generar?: ");
                //num = Convert.ToInt32(Console.ReadLine());
                //List<int> primos = GenerarNumerosPrimos.GenerarPrimos(num);
                //for (int i = 0; i < num; i++) { 
                //    Console.WriteLine("Numero primo "+(i+1)+": "+primos[i]);
                //}

                // - - - - Ejercicio para contar letras
                //Console.WriteLine("Ingresa el texto correspondiente para contar: ");
                //string txt = Console.ReadLine();
                //int cantidadCaracteres = ContarPalabras.ContarCaracter(txt);
                //int cantidadPalabras = ContarPalabras.ContarPalabra(txt);
                //int cantidadLetras = ContarPalabras.ContarLetra(txt);
                //Console.WriteLine($"Cantidad de caracteres: {cantidadCaracteres}");
                //Console.WriteLine($"Cantidad de palabras: {cantidadPalabras}");
                //Console.WriteLine($"Cantidad de letras: {cantidadLetras}");

                // - - - - Ejercicio de Romano a Arabe
                //Console.WriteLine("Ingresa el numeor Romano: ");
                //string romano = Console.ReadLine();
                //int arabe = ConvertirRomanoAArabe.ConvertirRomanoArabe(romano);
                //Console.WriteLine($"El resultado de la conversión fue: {arabe}");

                // - - - - Ejercicio de calculadora Basica
                //Console.WriteLine("- - - Calculadora Sencilla Menu - - -\n1. Suma\n2. Resta\n3. Multiplicar\n4. Dividir");
                //int opc = Convert.ToInt32(Console.ReadLine());
                //double resultado = CalculadoraBasica.Calcular(opc);
                //Console.WriteLine($"El resultado es: {resultado}");

                // - - - - Ejercicio de validar contraseña
                Console.WriteLine("Validar Contraseña\nEscribe la contrasena:");
                string contrasena = Console.ReadLine();
                bool answer = ValidacionContrasenia.ValidarContrasena(contrasena);
                // - - Finaliza el o repite la ejecucion
                Console.WriteLine("¿Desea realizar otra operación? S/N");
                rta = Console.ReadLine();
                if (rta == "S" || rta == "s") { continuidad = true; }
                else{ Console.WriteLine("Gracias por utilizar el programa\n¡Ten un gran dia! :D"); continuidad = false; }
            }Console.ReadKey();
        }
    }
}
