using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cuenta
{
    internal class Validaciones
    {
        public static bool ValidarString(string cadena)
        {
            if(Regex.IsMatch(cadena, @"^[a-zA-Z]+$"))
            {
                return true;
            }
            else
            {
                Console.WriteLine("El texto no puede contar con numeros, ingreselo nuevamente");
                return false;

            }
        }
    }
}
