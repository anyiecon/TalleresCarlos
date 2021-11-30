using System;

namespace numros
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, impar =0;

            for (i = 0; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0}", i);
                    impar++;
                }
            }

            Console.WriteLine("\n\n");
        }
    }
}
