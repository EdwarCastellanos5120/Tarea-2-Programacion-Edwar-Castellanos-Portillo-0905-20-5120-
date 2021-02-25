using System;

namespace _5._Quinto_Ejercicio_pag._110_
{
    class Program
    {
        static void Main(string[] args)
        {
            char op;
            double ladotri,basetri,altri,petri,artri,ladocua,pericua,arcua,canpo,lapo,apopo,pepo,apo;
            Console.WriteLine("*************AREA Y PERIMETRO DE POLIGONOS REGULARES************");
            Console.WriteLine("*************************MENU PRINCIPAL*************************");
            Console.WriteLine("Triangulo Equilatero..........................................1");
            Console.WriteLine("Cuadrado......................................................2");
            Console.WriteLine("Polignos Regulares de 5,6,7,8,9,10 Lados......................3");
            Console.Write("Ingrese el numero de la opcion que desea usar: ");
            op = Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '1':
                    Console.WriteLine("");
                    Console.Write("Ingrese la longitud de un lado de los triangulo: ");
                    ladotri = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la longitud de la base del triangulo: ");
                    basetri = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la longitud de la altura deñ triangulo: ");
                    altri = Convert.ToDouble(Console.ReadLine());
                    petri = (ladotri * 3);
                    artri = ((basetri * altri) / 2);
                    Console.WriteLine("El Perimetro del triangulo es: " + petri);
                    Console.WriteLine("El Area del triangulo es: " + artri);
                    break;

                case '2':
                    Console.WriteLine("");
                    Console.Write("Ingrese la longitud de un lado del Cuadradado: ");
                    ladocua = Convert.ToDouble(Console.ReadLine());
                    pericua = (ladocua * 4);
                    arcua = (ladocua * ladocua);
                    Console.WriteLine("El Perimetro del Cuadrado es: " + pericua);
                    Console.WriteLine("El Area del Cuadrado es: " + arcua);
                    break;

                case '3':
                    Console.WriteLine("");
                    Console.Write("Ingrese la catidad de lados que tiene su Poligono: ");
                    canpo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la longitud de un lado de su Poligono: ");
                    lapo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el apotema de su Poligono: ");
                    apopo = Convert.ToDouble(Console.ReadLine());
                    pepo = (canpo * lapo);
                    apo = ((pepo * apopo) / 2);
                    Console.WriteLine("El Perimetro del Poligono es: " + pepo);
                    Console.WriteLine("El Area del Poligono es: " + apo);
                    break;

            }
        }
    }
}
