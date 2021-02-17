using System;

namespace Sexto_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, numero, contador = 0;
            Console.Write("Ingrese el Numero que desea saber si es primo: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero <= 1)
            {
                Console.WriteLine("Su Numero no es Primo");
            }
            else
            {
                for (i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        contador++;
                    }
                }

                if (contador > 2)
                {
                    Console.WriteLine("Su Numero no es Primo");
                }
                else
                {
                    Console.WriteLine("Su Numero es Primo ");
                }
            }
        }
    }
}
