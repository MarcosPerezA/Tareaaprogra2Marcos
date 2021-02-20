using System;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, rn, re, cons=40;
            Console.WriteLine("Ingrese las horas trabajadas por el empleado ");
            a = int.Parse(Console.ReadLine());
            rn = a * 16;
            re = ((a - 40) * 20) + cons * 16;

            if (a < 40)
            {
                Console.WriteLine("su pago total es de Q" + rn);

            }
            else
            {

                Console.WriteLine("su pago total es de Q" + re);

            }
        }
    }
}
