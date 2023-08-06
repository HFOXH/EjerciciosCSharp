using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class SumaMatrices
    {
        public static int[,] SumarMatrices(int[,] matrizA, int[,] matrizB)
        {
            int filas = matrizA.GetLength(0);
            int columnas = matrizA.GetLength(1);

            if (filas != matrizB.GetLength(0) || columnas != matrizB.GetLength(1))
            {
                throw new ArgumentException("Las matrices deben tener las mismas dimensiones.");
            }
            int[,] MatrizC = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    MatrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }

            return MatrizC;
        }
    }
}
