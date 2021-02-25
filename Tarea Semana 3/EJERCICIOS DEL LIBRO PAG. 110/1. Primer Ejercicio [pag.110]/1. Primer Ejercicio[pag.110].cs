using System;

namespace _1._Primer_Ejercicio__pag._110_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resul;
            Console.Write("Ingrese el Numero: ");
            num = Convert.ToInt16(Console.ReadLine());
            resul = num % 2;
            if (resul == 0)
            {
                Console.WriteLine("El Numero Ingresado es Par");
            }
            else
            {
                Console.WriteLine("El Numero Ingresado es Impar");
            }            
        }
    }
}
