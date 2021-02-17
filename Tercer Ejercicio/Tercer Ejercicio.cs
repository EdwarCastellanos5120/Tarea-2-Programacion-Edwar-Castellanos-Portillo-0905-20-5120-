using System;

namespace Tercer_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, horas_extras, pago;
            Console.Write("Ingrese el Numero de Horas que trabajo el Obrero: ");
            horas = Convert.ToInt16(Console.ReadLine());
            if (horas > 40)
            {
                horas_extras = horas - 40;
                pago = ((40 * 16) + (horas_extras * 16));
                Console.WriteLine("La Cantidad a pagar al Obrero junto con sus horas extras es: Q" + pago);
            }
            else
            {
                pago = horas * 16;
                Console.WriteLine("La Cantidad a pagar al Obrero es: Q" + pago);
            }
        }
    }
}
