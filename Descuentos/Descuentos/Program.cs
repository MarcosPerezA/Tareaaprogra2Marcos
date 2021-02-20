using System;

namespace Descuentos
{
    class Program
    {
        static void Main(string[] args)
        {
            double cant, desc, tot;
            Console.WriteLine("Ingrese la cantidad total gastada; ");
           cant= double.Parse(Console.ReadLine());
            desc = cant * 0.20;
            tot = cant - desc;

            if (cant > 300)
            {
                Console.WriteLine("Su total a pagar es de Q " + tot);

            }
            else
            {
                Console.WriteLine("Su total a pagar es de Q " + cant);
            }

        }
    }
}
