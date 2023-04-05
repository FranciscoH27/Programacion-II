using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta
{
    internal class Cuenta
    {
        public string titular { get; set; }
        public float cantidad { get; set; }

        //Constructor--- Al declarar como propiedades titular/cantidades, hace falta el constructor?(Entiendo que el constructor funciona como setter).Gracias :)
        public Cuenta(string titular, float cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string GetTitular(string titular)
        {
            return titular;
        }

        public float GetFloat(float cantidad)
        {
            return cantidad;
        }

        static public string IngresarNombre()
        {
            string nombre;
            Console.WriteLine("ingrese el nombre del titular de la cuenta:");
            do
            {
                nombre = Console.ReadLine();
            } while (Validaciones.ValidarString(nombre) == false);
            return nombre;
        }
        static public string IngresarApellido()
        {
            string apellido;
            Console.WriteLine("ingrese el apellido del titular de la cuenta:");
            do
            {
                apellido = Console.ReadLine();
            } while (Validaciones.ValidarString(apellido) == false);
            return apellido;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("-------------------");
            sb.AppendLine($"Titular:{titular}");
            sb.AppendLine($"Cantidad:{cantidad}");
            sb.AppendLine("-------------------");
            return sb.ToString();
        }
        public static float IngresarDinero(float ingreso,float cantidad)
        {
            if (ingreso > 0)
            {
                return cantidad = cantidad + ingreso;
            }
            else
            {
                Console.WriteLine("El numero ingresado no es valido");
                return  cantidad;
            }

        }

        public static float RetirarDinero(float retiro,float cantidad)
        {
            if (retiro > 0)
            {
                return cantidad - retiro;
            }
            else
            {
                Console.WriteLine("El numero ingresado no es valido");
                return cantidad;
            }
        }
    }
}
