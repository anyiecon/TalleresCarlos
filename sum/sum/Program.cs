using System;

namespace sum
{
    class Program
    {
        static void Main(string[] args)
        {

            double vCompra, descuento, total;
            Console.Write(" Ingrese el valor de la compra : ");
            vCompra = Double.Parse(Console.ReadLine());
            descuento = vCompra * 0.15;
            total = vCompra - descuento;
            Console.WriteLine(" El valor de descuento es : {0:c2}", descuento);
            Console.WriteLine(" El valor total de la compra es : {0:c2}", total);
        }
    }
}
