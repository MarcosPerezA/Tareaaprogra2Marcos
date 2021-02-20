using System;

namespace Dia_Laboral
{
    class Program
    {
        static void Main(string[] args)
        {
            int d;
            Console.WriteLine("eliga el dia:\n " +
               "1. Lunes\n" +
               "2. Martes\n" +
               "3. Miercoles\n" +
               "4. Jueves\n" +
               "5. Viernes\n" +
               "6. Sabado\n" +
               "7. Domingo\n");
            d = int.Parse(Console.ReadLine());
            int ds = d;

            switch (ds)
            {
                case 1:
                    Console.WriteLine(" es un Día laboral");
                    break;
                case 2:
                    Console.WriteLine(" es un Día laboral");
                    break;
                case 3:
                    Console.WriteLine("es un Día laboral");
                    break;
                case 4:
                    Console.WriteLine("es un Día laboral");
                    break;
                case 5:
                    Console.WriteLine("es un Día laboral");
                    break;
                case 6:
                    Console.WriteLine("No es un día laboral");
                    break;
                case 7:
                    Console.WriteLine("No es un día laboral");
                    break;
            }
        }
    }
}
