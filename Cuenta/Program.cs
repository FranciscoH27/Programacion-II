namespace Cuenta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mi idea principal era dejar solo llamado a funciones pero al menos por ahora no sabia como manipular datos del obejeto ya inicializado(primerCuenta),dentro de un metodo (Perdon si las dudas son medio tontas :c )
            
            string nombre;
            string apellido;
            nombre = Cuenta.IngresarNombre();
            apellido = Cuenta.IngresarApellido();
            string titular = nombre + apellido;// Se que esta mal de esta forma pero no sabia realmente como ingresar el espacio entre Nombre y Apellido
            Cuenta primerCuenta = new Cuenta(titular,5000);
           Console.WriteLine(primerCuenta);
            int opcion = 0;
            float monto;
            do
            {
                Console.WriteLine("Ingrese 1 si desea ingresar dinero\n" +
                "Ingrese 2 si desea retirar dinero\n" +
                "Ingrese 3 si desea mostrar los datos de la cuenta\n"+
                "Ingrese 4 si no desea realizar nada\n" + "Opcion:");
                int.TryParse(Console.ReadLine(), out opcion);
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese cuanto desea ingresar:");
                        float.TryParse(Console.ReadLine(), out monto);
                        primerCuenta.cantidad = Cuenta.IngresarDinero(monto, primerCuenta.cantidad);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese cuanto desea retirar:");
                        float.TryParse(Console.ReadLine(), out monto);
                       primerCuenta.cantidad = Cuenta.RetirarDinero(monto,primerCuenta.cantidad);
                        break;
                   case 3:
                        Console.WriteLine(primerCuenta);
                        break;
                    case 4:
                        Console.WriteLine("Usted salio del gestor de cuenta.");
                        break;

                }
            } while (opcion != 4);

        }
    }
}