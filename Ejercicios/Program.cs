﻿using System;
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
                //Console.WriteLine("Validar Contraseña\nEscribe la contrasena:");
                //string contrasena = Console.ReadLine();
                //ValidacionContrasenia.ValidarContrasena(contrasena);

                // - - - - Ejercicio de Fibonacci
                //Console.WriteLine("Ingrese la cantidad de números de la secuencia de Fibonacci que desea generar:");
                //int n = int.Parse(Console.ReadLine());
                //Console.WriteLine($"Los primeros {n} números de la secuencia de Fibonacci son:");
                //GenerarSecuenciaFibonacci.Fibonacci(n);

                // - - - - Ejercicio de Cesar
                //Console.WriteLine("Ingrese un mensaje para encriptar:");
                //string mensajeOriginal = Console.ReadLine();
                //Console.WriteLine("Ingrese el número de desplazamiento:");
                //int desplazamiento = int.Parse(Console.ReadLine());
                //string mensajeCifrado = EncriptadoCesar.Cifrar(mensajeOriginal, desplazamiento);
                //Console.WriteLine($"Mensaje Cifrado: {mensajeCifrado}");

                // - - - - Ejercicio de Generador de contraseñas
                //Console.WriteLine("---Generador de Contraseñas----\nIngresa la longitud:");
                //int longitud = Convert.ToInt32(Console.ReadLine());
                //GeneradorContrasena.GenerarContra(longitud);

                // - - - - Ejercicio de suma de Diagonales y Diferencia
                //Console.WriteLine("Ingresa el tamaño de la matriz");
                //int tam = Convert.ToInt32(Console.ReadLine());
                //int[,] matriz = new int[tam, tam];
                //int numero;
                //for (int i = 0; i < tam; i++) {
                //    for (int j = 0; j < tam; j++)
                //    {
                //        Console.WriteLine($"Ingrese el elemento de la posicion [{i},{j}]: ");
                //        numero = Convert.ToInt32(Console.ReadLine());
                //        matriz[i, j] = numero;
                //    }
                //}

                //int rDiagonalI = SumaDiagonalesYDiferencia.SumarDiagonalIzquierda(matriz,tam);
                //int rDiagonalD = SumaDiagonalesYDiferencia.SumarDiagonalDerecha(matriz,tam);

                //SumaDiagonalesYDiferencia.ImprimirMatriz(matriz, tam);
                //Console.WriteLine($"El resultado de la Diagonal izquierda es: {rDiagonalI}\nEl resultado de la Diagonal derecha es: {rDiagonalD}\nDiferencia: {rDiagonalI-rDiagonalD}");

                // - - - - Adivina el numero
                //Console.WriteLine("- - - Juevo de adivinar el número - - -\nIngresa el número:");
                //AdivinarNumero.adivinanza();

                // - - - - Calcular la hipotenusa
                //Console.WriteLine("valor de cateto 1: ");
                //double c1 = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("valor de cateto 2: ");
                //double c2 = Convert.ToInt32(Console.ReadLine());
                //double resultado = Hipotenusa.CalcularHipotenusa(c1, c2);
                //Console.WriteLine("La hipotenusa es " + resultado);

                // - - - - Conversion de moneda <--- sencilla
                //Console.WriteLine("Ingresa el monto a convertir:");
                //double monto = Convert.ToDouble(Console.ReadLine());
                //ConversionMoneda.Convertir(monto);

                // - - - - Conversion de moneda <--- dinamica >:D
                Console.WriteLine("Ingresa el monto a convertir:");
                double monto = Convert.ToDouble(Console.ReadLine());
                ConversionMonedaDinamica.Convertir(monto);

                // - - Finaliza el o repite la ejecucion
                Console.WriteLine("¿Desea realizar otra operación? S/N");
                rta = Console.ReadLine();
                if (rta == "S" || rta == "s") { continuidad = true; Console.Clear(); }
                else{ Console.WriteLine("Gracias por utilizar el programa\n¡Ten un gran dia! :D"); continuidad = false; }
            }Console.ReadKey();
        }
    }
}
