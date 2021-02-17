using System;

namespace Segundo_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero, resultado,oferta;
            Console.WriteLine("Bienvenido a MegaPlaza");
            Console.Write("\n");
            Console.Write("Ingrese la cantidad total de su compra: ");
            numero = Convert.ToDouble(Console.ReadLine());
            if (numero >= 300)
            {
                resultado = numero * 0.2;
                oferta = numero - resultado;
                Console.WriteLine("El 20% a descontar a su compra es: Q" + resultado);
                Console.WriteLine("La cantidad a pagar por su compra con el 20% es un total de: Q" + oferta);
            }
            else
            {
                Console.WriteLine("La cantidad a pagar por su compra que no aplica el descuento es un total de: Q" + numero);
            }
        }
    }
}
