using System;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            double nPulsaciones;

            Console.Write("Escriba su edad : ");
            edad = Int32.Parse(Console.ReadLine());

            nPulsaciones = (220 - edad) / 10;

            Console.WriteLine("El número de pulsaciones es {0}", nPulsaciones);
        }
    }
}
