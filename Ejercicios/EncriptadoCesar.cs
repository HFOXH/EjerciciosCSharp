using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Ejercicios
{
    internal class EncriptadoCesar
    {
        public static string Cifrar(string mensajeOriginal, int desplazamiento) {
            char[] msj = mensajeOriginal.ToCharArray();
            char[] msjEnc = new char[msj.Length];
            for (int i = 0; i < msj.Length; i++)
            {
                int letra = (int)msj[i];
                msjEnc[i] = (char)(letra+desplazamiento);
            }
            return string.Join("", msjEnc);
        }
    }
}
