using System;

namespace Mayus
{
    class Program
    {
        static void Main(string[] args)
        {
            char a;
            Console.WriteLine("ingrese una letra ");
            a =Convert.ToChar(Console.ReadLine());
            if (a >= 'a' && a<= 'z')
            {
                Console.WriteLine("minuscula");
            }
            else
            {
                Console.WriteLine("mayuscula");
            }

        }
    }
}
