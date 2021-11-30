using System;

namespace listados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese una cantidad");
            int ok = Convert.ToInt32(Console.ReadLine());
            int[] listao;
            listao = new int[ok];
            Console.WriteLine("ingrese un numero");
            int hu = Convert.ToInt32(Console.ReadLine());
            listao[0] = hu;
            for (int i = 1; i < listao.Length + 1; i++)
            {
                int oo = i;
                oo = i * hu;
            Console.WriteLine("su multiplo es:"+oo);
            }
          
        }  
    }
}
