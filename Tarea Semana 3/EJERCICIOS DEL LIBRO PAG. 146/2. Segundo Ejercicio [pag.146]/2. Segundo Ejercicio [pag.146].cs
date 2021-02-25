using System;

namespace _2._Segundo_Ejercicio__pag._146_
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, pot, i, resul=1;
            Console.Write("Ingrese el Numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese a que potencia desea elevar el numero: ");
            pot = Convert.ToInt32(Console.ReadLine());
            for (i=1; i <= pot; i++)
            {
                resul = resul * num;
            }
            Console.WriteLine("La potencia de su numero es: " + resul);
        }
    }
}
