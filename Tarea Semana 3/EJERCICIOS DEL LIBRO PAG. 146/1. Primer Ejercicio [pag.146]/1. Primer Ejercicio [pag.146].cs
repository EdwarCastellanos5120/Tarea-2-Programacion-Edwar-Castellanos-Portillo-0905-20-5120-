using System;

namespace _1._Primer_Ejercicio__pag._146_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,i,res;
            Console.Write("Ingrese el Numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Su table es la siguiente: ");
            for (i = 1; i <= 10; i++)
            {
                res = num * i;
                Console.WriteLine(i+ "x"+ num+ "=" + res);
            }
        }
    }
}
