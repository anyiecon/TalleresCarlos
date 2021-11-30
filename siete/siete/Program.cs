using System;

namespace siete
{
    class Program
    {
        static void Main(string[] args)
        {
            float num, may0 = 0, men0 = 1, x = 0;
            int cont = 0;
            float num1, num2, auxi;

            while (cont < 10)
            {
                do
                {
                    Console.Write("Número:");
                    num = float.Parse(Console.ReadLine());

                } while (num == 0);

                if (num > 0)
                    may0 = may0 + num;
                if (num < 0)
                    men0 = men0 * num;

                cont++;
            }
            if (men0 == 1)
                men0 = 0;
            Console.Write("La suma de los números + es {0} y el producto de los - es {1}", may0, men0);
            Console.Write("\n\nNúmero 1:");
            num1 = float.Parse(Console.ReadLine());

            Console.Write("Número 2:");
            num2 = float.Parse(Console.ReadLine());

            auxi = num1;
            num1 = num2;
            num2 = auxi;

            Console.Write("El número 1 ahora es {0} y el número 2 es {1}\n\n", num1, num2);
        }
    }
}
