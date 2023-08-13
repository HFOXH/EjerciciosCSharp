using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    internal class ValidacionContrasenia
    {
        public static bool ValidarContrasena(string contrasena)
        {
            bool tieneMayuscula = false;
            bool tieneMinuscula = false;
            bool tieneNumero = false;
            bool tieneEspecial = false;

            //Debe tener al menos 8 caracteres de longitud.
            if (contrasena.Length < 8)
            {
                Console.WriteLine("La contraseña debe tener más de 8 caracteres");
                return false;
            }
            //Debe tener al menos un caracter en mayuscula, minuscula, numerico y uno especial
            foreach (char caracter in contrasena)
            {
                if (char.IsUpper(caracter))
                    tieneMayuscula = true;
                else if (char.IsLower(caracter))
                    tieneMinuscula = true;
                else if (char.IsNumber(caracter))
                    tieneNumero = true;
                else if (char.IsSymbol(caracter) || char.IsPunctuation(caracter))
                    tieneEspecial = true;
            }

            //Color rojo en caso de que este mal
            Console.ForegroundColor = ConsoleColor.Red;

            if (!tieneMayuscula)
                Console.WriteLine("La contraseña debe tener al menos una letra mayúscula");
            if (!tieneMinuscula)
                Console.WriteLine("La contraseña debe tener al menos una letra minúscula");
            if (!tieneNumero)
                Console.WriteLine("La contraseña debe tener al menos un número");
            if (!tieneEspecial)
                Console.WriteLine("La contraseña debe tener al menos un carácter especial");

            if (!tieneMayuscula || !tieneMinuscula || !tieneNumero || !tieneEspecial)
                Console.WriteLine("Contraseña Invalida!");
            else {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Contraseña Valida!");
            }
            Console.ForegroundColor = ConsoleColor.White;
            return true;
        }
    }
}
