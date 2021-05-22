using System;

namespace Flujo_de_datos___C2_Ej16
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio;
            double preciofinal;
            const double IVA = 21;

            Console.WriteLine("Introduce el precio:");
            precio = Convert.ToDouble(Console.ReadLine());
            preciofinal = precio*(1+IVA/100);
            Console.WriteLine("El PRECIO con IVA ES " + preciofinal);
        }
    }
}
