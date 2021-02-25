using System;

namespace Serie_de_un_Numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, a = 0, b = 1, c = 1,i;
            Console.Write("Ingrese el numero de elementos: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < num; i++)
            {
                c = a + b;
                Console.WriteLine(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
