using System;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            double nVarones, nMujeres, nTotal, pVarones, pMujeres;
            Console.Write("Escriba la cantidad de varones: ");
            nVarones = Double.Parse(Console.ReadLine());
            Console.Write("Escriba la cantidad de mujeres: ");
            nMujeres = Double.Parse(Console.ReadLine());
            nTotal = nVarones + nMujeres;
            pVarones = nVarones * 100 / nTotal; 
            pMujeres = nMujeres * 100 / nTotal; 
            Console.WriteLine("De {0} estudiantes, un {1}% son varones y un {2}% mujeres",
                nTotal, Math.Round(pVarones, 0), Math.Round(pMujeres, 0));
        }
    }
}
