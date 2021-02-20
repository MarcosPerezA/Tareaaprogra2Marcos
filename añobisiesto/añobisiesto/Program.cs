using System;

namespace añobisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            
            Console.WriteLine("ingrese un año ");
            a = int.Parse(Console.ReadLine());
            

            if (a % 4 == 0)
            {
                Console.WriteLine("Enero:31 Dias");
                Console.WriteLine("Febrero:29 Dias\nMarzo:31 dias\nAbril:30 Dias\nMayo:31 Dias\nJunio:30 Dias");
                Console.WriteLine("Julio:31 Dias\nAgosto:31 Dias\nSeptiembre:30 Dias\nOctubre:31 Dias");
                Console.WriteLine("Noviembre:30 Dias\nDiciembre:31 Dias");
                        
               }
            else
            {
                Console.WriteLine("Enero:31 Dias");
                Console.WriteLine("Febrero:28 Dias\nMarzo:31 dias\nAbril:30 Dias\nMayo:31 Dias\nJunio:30 Dias");
                Console.WriteLine("Julio:31 Dias\nAgosto:31 Dias\nSeptiembre:30 Dias\nOctubre:31 Dias");
                Console.WriteLine("Noviembre:30 Dias\nDiciembre:31 Dias");
            }
        }
    }
}
