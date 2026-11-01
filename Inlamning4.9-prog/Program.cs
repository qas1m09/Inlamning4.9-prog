using System;

namespace Inlamning4._9_prog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många X per grupp?");
            int antalX = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många O per grupp?");
            int antalO = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många O-mönster per rad?");
            int antalOGrupper = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många rader?");
            int antalRader = int.Parse(Console.ReadLine());

            for (int rad = 0; rad < antalRader; rad++)
            {
              
                Console.Write(new string('X', antalX));

               
                for (int grupp = 0; grupp < antalOGrupper; grupp++)
                {
                    Console.Write("-");
                    Console.Write(new string('O', antalO));
                    Console.Write("-");
                    Console.Write(new string('X', antalX));
                }

                Console.WriteLine();
            }

            Console.ReadLine(); 
        }
    }
}