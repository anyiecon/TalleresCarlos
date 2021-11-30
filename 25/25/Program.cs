using System;

namespace _25
{
    class Program
    {
        static void Main(string[] args)
        {
            double capital, ganancia;
            Console.Write("Ingrese el capital para invertir : ");
            capital = Double.Parse(Console.ReadLine());
            ganancia = (capital * 2) / 100; //Cálculo del 2% por un mes.
            Console.WriteLine("Ganancia por 2% interes en un mes: {0:C}", ganancia);
            Console.WriteLine("Capital total en un mes: {0:C}",ganancia + capital);
        }
    }
}
