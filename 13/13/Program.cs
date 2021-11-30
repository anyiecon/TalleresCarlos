using System;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            double nPresion, nVolumen, nTemperatura, masa;

            Console.Write("Ingrese la presión     : ");
            nPresion = Double.Parse(Console.ReadLine());

            Console.Write("Ingrese el volumen     : ");
            nVolumen = Double.Parse(Console.ReadLine());

            Console.Write("Ingrese la temperatura : ");
            nTemperatura = Double.Parse(Console.ReadLine());

            masa = (nPresion * nVolumen) / (0.37 * (nTemperatura + 460));

            Console.WriteLine("La masa es = {0}", masa);

        }
    }
}
