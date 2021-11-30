using System;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                decimal num;
                Console.Write("Escriba un numero : ");
                num = Decimal.Parse(Console.ReadLine());

                Console.WriteLine("El valor absoluto de |{0}| es {1}",
                    num, Math.Abs(num));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
