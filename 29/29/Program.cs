using System;

namespace _29
{
    class Program
    {
        static void Main(string[] args)
        {
            double cantPer1, cantPer2, cantPer3, cantTot;
            string persona1, persona2, persona3;

            Console.CursorTop = 3;
            Console.Write("Ingrese el nombre de la primera persona: ");
            persona1 = Console.ReadLine();
            Console.Write("Ingrese el monto de su inversión: ");
            cantPer1 = Double.Parse(Console.ReadLine());

            Console.CursorTop = 6;
            Console.Write("Ingrese el nombre de la segunda persona: ");
            persona2 = Console.ReadLine();
            Console.Write("Ingrese el monto de su inversión: ");
            cantPer2 = Double.Parse(Console.ReadLine());

            Console.CursorTop = 9;
            Console.Write("Ingrese el nombre de la tercera persona: ");
            persona3 = Console.ReadLine();
            Console.Write("Ingrese el monto de su inversión: ");
            cantPer3 = Double.Parse(Console.ReadLine());

            cantTot = cantPer1 + cantPer2 + cantPer3;
            double porcentaje = cantTot;

            porcentaje = cantPer1 * 100 / cantTot;
            Console.CursorTop = 12;
            Console.WriteLine("{0} realizó el {1}% de la inversión",
                persona1, Math.Round(porcentaje, 2));

            porcentaje = cantPer2 * 100 / cantTot;
            Console.CursorTop = 14;
            Console.WriteLine("{0} realizó el {1}% de la inversión",
                persona2, Math.Round(porcentaje, 2));

            porcentaje = cantPer3 * 100 / cantTot;
            Console.CursorTop = 16;
            Console.WriteLine("{0} realizó el {1}% de la inversión",
                persona3, Math.Round(porcentaje, 2));

        }
    
    }
}
