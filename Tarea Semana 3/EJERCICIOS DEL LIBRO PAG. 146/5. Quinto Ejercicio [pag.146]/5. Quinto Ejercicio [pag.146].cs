using System;

namespace _5._Quinto_Ejercicio__pag._146_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numper,i,mayor=0,menor=0;
            Console.Write("Cuantas Edades desea ingresar: ");
            numper = Convert.ToInt32(Console.ReadLine());
            int[] edades= new int[numper + 1];
            for (i = 1; i <= numper; i++)
            {
                Console.Write("Cual es la Edad de la Persona: ");
                edades[i]= Convert.ToInt32(Console.ReadLine());
            }
            mayor = edades[1];
            menor = edades[1];
            for (i = 1; i <= numper; i++)
            {
                if (edades[i] > mayor)
                {
                    mayor = edades[i];
                }
                else if (edades[i] < menor)
                {
                    menor =edades[i];
                }
            }
            
            Console.WriteLine("La edad mayor es: " + mayor);
            Console.WriteLine("La edad menor es: " + menor);
        }
    }
}
