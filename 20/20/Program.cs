using System;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaPar1, notaPar2, notaPar3, notaExamen,
               notaTrabajo, tParciales, pEx, pNf;
            string nombreAlumno;

            Console.Write("Nombre del alumno : ");
            nombreAlumno = Console.ReadLine();

            Console.WriteLine("\n Ingrese notas Parciales");
            Console.Write("\n Nota No. 1 : ");
            notaPar1 = Double.Parse(Console.ReadLine());

            Console.Write(" Nota No. 2 : ");
            notaPar2 = Double.Parse(Console.ReadLine());

            Console.Write(" Nota No. 3 : ");
            notaPar3 = Double.Parse(Console.ReadLine());

            Console.Write("\n Ingrese nota del examen : ");
            notaExamen = Double.Parse(Console.ReadLine());
            Console.Write(" Ingrese nota del trabajo final : ");
            notaTrabajo = Double.Parse(Console.ReadLine());

            tParciales = ((notaPar1 + notaPar2 + notaPar3) / 3) * 0.55;
            pEx = notaExamen * 0.30;
            pNf = notaTrabajo * 0.15;

            Console.WriteLine("\n Las notas parciales equivalen a      : {0:G2}", tParciales);
            Console.WriteLine(" Las notas del examen equivale a        : {0:G2}", pEx);
            Console.WriteLine(" Las notas del trabajo final equivale a : {0:G2}", pNf);
        }
    }
}
