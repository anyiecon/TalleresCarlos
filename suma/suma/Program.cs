using System;

namespace suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, suma = 0 ;

            Console.Write("Número:");
            num = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
                suma = suma + i;

            Console.Write("La suma de los números que anteceden a el {0} es {1}\n\n", num, suma);
        }
    }
}
