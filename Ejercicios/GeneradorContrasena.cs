using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class GeneradorContrasena
    {
        public static string GenerarContra(int longitud) {
            Random rnd = new Random();
            StringBuilder contrasenaGenerada = new StringBuilder();
            char[] caracteres = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k',
            'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z', '@', '!', '/'
            , '*', '-', '+', '_', '#', '(', ')', '%', '&', '=', '.', ',', '<', '>' };
            for (int i = 0; i < longitud; i++)
                Console.Write(caracteres[rnd.Next(0, caracteres.Length)]);
            Console.Write("\n");
            return contrasenaGenerada.ToString();
        }
        
    }
}
