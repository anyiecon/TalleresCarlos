using System;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            double salAnt, salNuevo;
            string nomObrero;
            Console.Write(" Ingrese el nombre del obrero : ");
            nomObrero = Console.ReadLine();

            Console.Write("\n Escriba su salario anterior : ");
            salAnt = Double.Parse(Console.ReadLine());

            salNuevo = salAnt + salAnt * 0.25;
            Console.WriteLine("\n El nuevo salario a recibir es : {0:C2}", salNuevo);
        }
    }
}
