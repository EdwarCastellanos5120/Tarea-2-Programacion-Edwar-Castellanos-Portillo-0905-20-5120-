using System;

namespace _2._Segundo_Ejercicio__pag._110_
{
    class Program
    {
        static void Main(string[] args)
        {
            double op, num, resul;
            Console.WriteLine("**********CONVERTIR RADIANES A GRADOS O GRADOS A RADINES**********");
            Console.WriteLine("******************************MENU********************************");
            Console.WriteLine("1. Ingrese el Numero 1 para convertir radianes a grados");
            Console.WriteLine("2. Ingrese el Numero 2 para convertir grados a radianes");
            Console.Write("Ingrese el numero de la comversion: ");
            op = Convert.ToDouble(Console.ReadLine());
            if (op == 1)
            {
                Console.WriteLine("RADIANES A GRADOS");
                Console.Write("Ingrese la cantidad en Radianes que desea convertir: ");
                num = Convert.ToDouble(Console.ReadLine());
                resul = ((num * 180) / Math.PI);
                Console.WriteLine("Su conversion es: "+resul);   
            }
            else
            {
                if (op == 2)
                {
                    Console.WriteLine("GRADOS A RADIANES");
                    Console.Write("Ingrese la cantidad en Grados que desea convertir: ");
                    num = Convert.ToDouble(Console.ReadLine());
                    resul = ((num * Math.PI) / 180);
                    Console.WriteLine("Su conversion es: " + resul);
                }
                else
                {
                    Console.WriteLine("La opcion no esta disponible");
                }
            }
        }
    }
}
