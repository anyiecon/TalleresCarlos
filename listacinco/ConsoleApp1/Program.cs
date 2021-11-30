using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de notas");
            int nu = Convert.ToInt32(Console.ReadLine());
            int[] listan;
            listan = new int[nu];
            int suma=0;
            for(int i=0; i<listan.Length; i++)
            {
                Console.WriteLine("ingrese la nota");
                int np = Convert.ToInt32(Console.ReadLine());
                listan[0] = np;
                suma = suma + np;
            
            }
            double promedio = suma/nu;
            Console.WriteLine("el prmedio es: "+ promedio);

            
        }
    }
}
