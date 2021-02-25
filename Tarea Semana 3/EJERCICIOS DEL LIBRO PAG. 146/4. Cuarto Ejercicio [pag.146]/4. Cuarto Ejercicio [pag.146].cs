using System;

namespace _4._Cuarto_Ejercicio__pag._146_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2, i, contador = 0;
            while (num <= 1000)
            {
                for (i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        contador++;
                    }
                }
                if (contador == 2)
                {
                    Console.WriteLine("El siguiente numero es primo: " + num);
                }
                contador = 0;
                num++;
            }
        }
    }
}
