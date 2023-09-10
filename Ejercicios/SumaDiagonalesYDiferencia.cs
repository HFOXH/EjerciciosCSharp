using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class SumaDiagonalesYDiferencia
    {
        public static int SumarDiagonalIzquierda(int[,] matriz, int tam) {
            int sumatoria = 0;
            for (int i = 0; i < tam; i++) {
                for (int j = 0; j < tam; j++){
                    if (i == j){
                        sumatoria += matriz[i, j];
                    }
                }
            }
            return sumatoria;
        }
        public static int SumarDiagonalDerecha(int[,] matriz, int tam)
        {
            int sumatoria = 0;
            for (int i = 0; i < tam; i++){
                sumatoria += matriz[i, tam - 1 - i];
            }
            return sumatoria;
        }
        public static void ImprimirMatriz(int[,] matriz, int tam) {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" - - - Matriz - - - ");
            for (int i = 0; i < tam; i++){
                for (int j = 0; j < tam; j++){
                    Console.Write("     "+matriz[i, j]);
                }
                Console.WriteLine("");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
