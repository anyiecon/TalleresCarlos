using System;

namespace _24
{
    class Program
    {
        static void Main(string[] args)
        {
            double precArt, precVenta;

            Console.Write("\n Ingrese el valor del artículo : ");
            precArt = Double.Parse(Console.ReadLine());

            precVenta = precArt + precArt * 0.30;
            Console.WriteLine("\n Precio a vender con ganancia de 30% : {0:C2}", precVenta);
        }
    }
}
