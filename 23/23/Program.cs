using System;

namespace _23
{
    class Program
    {
        static void Main(string[] args)
        {
            double montoPresupuesto, areaGineco, areaTrauma, areaPedia;
            Console.Write("Ingrese el presupuesto anual para el hospital: ");
            montoPresupuesto = Double.Parse(Console.ReadLine());
            Console.WriteLine("El monto de presupuesto para Ginecología es de   {0:C2}",
                areaGineco = montoPresupuesto * 0.40);
            Console.WriteLine("El monto de presupuesto para Traumatología es de {0:C2}",
                areaTrauma = montoPresupuesto * 0.30);
            Console.WriteLine("El monto de presupuesto para Pedriatría es de    {0:C2}",
                areaPedia = montoPresupuesto * 0.30);
        }
    }
}
