using System;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int anioActual, anioNacimiento, edad;
            string nombre;
            Console.Write("Ingrese el nombre de la persona: ");
            nombre = Console.ReadLine();
            Console.Write("¿En qué año estámos?: ");
            anioActual = Int32.Parse(Console.ReadLine());
            Console.Write("¿Cuál es el año de nacimiento?: ");
            anioNacimiento = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0} tiene {1} años de edad", nombre,
                edad = anioActual - anioNacimiento);
        }
    }
}
