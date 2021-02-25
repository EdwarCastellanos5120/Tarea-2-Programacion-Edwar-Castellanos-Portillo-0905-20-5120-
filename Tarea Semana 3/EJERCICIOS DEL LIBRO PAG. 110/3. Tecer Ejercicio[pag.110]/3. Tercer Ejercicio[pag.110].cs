using System;

namespace _3._Tecer_Ejercicio_pag._110_
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            double pro,impu=0;
            Console.WriteLine("******IMPUESTO DE UN PRODUCTO******");
            Console.WriteLine("*****************MENU**************");
            Console.WriteLine("Medicina..........................1");
            Console.WriteLine("Otro Producto............... .....2");
            Console.Write("Ingrese el numero del producto: ");
            op = Convert.ToInt16(Console.ReadLine());
            if (op == 1)
            {
                Console.Write("Ingrese el Precio del Producto: ");
                pro = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Su Producto es Medicina y tiene un impuesto del 0%");
                Console.WriteLine("La impuesto a pagar es: " + impu);
            }
            else if (op == 2)
            {
                Console.Write("Ingrese el Precio del Producto: ");
                pro = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Su Producto tiene un impuesto del 12%");
                impu = pro * 0.12;
                Console.WriteLine("El impuesto a pagar es: " + impu);
            }
            else
            {
                Console.WriteLine("La opcion no se encuentra disponible");

            }
        }
    }
}
