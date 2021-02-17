using System;

namespace Quinto_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            char dia;
            Console.WriteLine(".........MENU..........");
            Console.WriteLine(" Dia Lunes............1");
            Console.WriteLine(" Dia Martes...........2");
            Console.WriteLine(" Dia Miercoles........3");
            Console.WriteLine(" Dia Jueves...........4");
            Console.WriteLine(" Dia Viernes..........5");
            Console.WriteLine(" Dia Sabado...........6");
            Console.WriteLine(" Dia Domingo..........7");
            Console.Write("Ingrese el Dia de la Semana: ");
            dia = Convert.ToChar(Console.ReadLine());
            switch (dia)
            {
                case '1':
                    Console.WriteLine("El Dia Lunes es Dia Laboral");
                    break;

                case '2':
                    Console.WriteLine("El Dia Martes es Dia Laboral");
                    break;

                case '3':
                    Console.WriteLine("El Dia Miercoles es Dia Laboral");
                    break;

                case '4':
                    Console.WriteLine("El Dia Jueves es Dia Laboral");
                    break;

                case '5':
                    Console.WriteLine("El Dia Viernes es Dia Laboral");
                    break;

                case '6':
                    Console.WriteLine("El Dia Sabado No es Dia Laboral");
                    break;

                case '7':
                    Console.WriteLine("El Dia Domingo  No es Dia Laboral");
                    break;

                default:
                    Console.WriteLine("La opcion ingresada no existe");
                    break;

            }

        }
    }
}
