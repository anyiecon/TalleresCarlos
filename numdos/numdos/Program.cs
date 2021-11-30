using System;

namespace numdos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingrese un segundo numero");
            int y = Convert.ToInt32(Console.ReadLine());

            int resultado = x + y;

            int valoruno = 123;

            if ( resultado > valoruno)
            {
                Console.WriteLine("las suma es " + resultado+ " Has ganado un premio");
            }
            else
            {
                Console.WriteLine("las suma es " + resultado +    " Sigue intentando");
            }
        }
    }
}
