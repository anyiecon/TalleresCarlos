using System;

namespace bienve
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe tu nombre");
            String nom = Console.ReadLine();

            Console.WriteLine("Escribe la ciudad a la que llegaste");
            String ci = Console.ReadLine();

            Console.WriteLine("Hola " + nom+ " bienvenido a " + ci);

            Console.ReadLine();
        }
    }
}
