using System;

namespace Factorial_de_un_Numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, fact = 1;
            Console.Write("Ingrese el Numero :");
            num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                fact = 0;
            }
            else if (num == 0)
            {
                fact = 1;
            }
            else
            {
                for (i = 1; i <= num; i++)
                {
                    fact = fact * i;
                }
            }
            Console.WriteLine("El factorial del numero " + num + " es: " + fact);
        }
    }
}
