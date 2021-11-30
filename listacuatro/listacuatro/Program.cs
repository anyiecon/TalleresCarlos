using System;

namespace listacuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de notas");
            int nu = Convert.ToInt32(Console.ReadLine());
            int[] listan;
            listan = new int[nu];
            for (int i = 0; i < listan.Length; i++)
            {
                Console.WriteLine("ingrese la nota");
                int no = Convert.ToInt32(Console.ReadLine());
                listan[0] = no;
            }
                Console.WriteLine("la lisa es:" + Convert.ToString(listan));
        }
    }
}
