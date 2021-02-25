using System;

namespace _4._Cuarto_Ejercicio_pag._110_
{
    class Program
    {
        static void Main(string[] args)
        {
            char dia;
            Console.Write("Ingrese un numero del 1 al 7 : ");
            dia = Convert.ToChar(Console.ReadLine());
            switch (dia)
            {
                case '1':
                    Console.WriteLine("Dia Lunes");
                    break;

                case '2':
                    Console.WriteLine("Dia Martes");
                    break;

                case '3':
                    Console.WriteLine("Dia Miercoles");
                    break;

                case '4':
                    Console.WriteLine("Dia Jueves");
                    break;

                case '5':
                    Console.WriteLine("Dia Viernes");
                    break;

                case '6':
                    Console.WriteLine("Dia Sabado");
                    break;

                case '7':
                    Console.WriteLine("Dia Domingo");
                    break;

                default:
                    Console.WriteLine("El dia ingresado no existe");
                    break;

            }

        }
    }
}
