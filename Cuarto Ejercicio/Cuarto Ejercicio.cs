using System;

namespace Cuarto_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio;
            Console.Write("Ingrese el Año: ");
            anio = Convert.ToInt16(Console.ReadLine());
            if (anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0)
            {
                Console.WriteLine("El anio es Bisiesto posee 366 Dias");
                Console.WriteLine("El Mes de Febrero tendra 29 Dias");
            }
            else
            {
                Console.WriteLine("El anio no es Bisiesto posee 365 Dias");
                Console.WriteLine("El Mes de Febrero tendra 28 Dias");
            }
        }
    }
}
