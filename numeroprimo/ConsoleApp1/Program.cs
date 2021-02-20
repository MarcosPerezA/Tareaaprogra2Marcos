using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, a, cont;
            cont = 0;


            Console.WriteLine("INGRESE UN NUMERO ");
            num = int.Parse(Console.ReadLine());

            for (a = 1; a <= num; a++)
            {
                if (num % a == 0)
                {
                    cont = cont + 1;
                }
            }

            if
                (cont > 2)
            {


                Console.WriteLine("No es un numero primo ");
            }
            else if (num < 2)
            {
                Console.WriteLine("No es un numero primo ");
            }
            else
            {
                Console.WriteLine("Es un Numero Primo ");
            }
            Console.ReadLine();
        }
    }
}