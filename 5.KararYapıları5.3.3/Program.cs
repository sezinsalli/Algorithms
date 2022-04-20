using System;

namespace _5.KararYapıları5._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kenar1:");
            int kenar1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kenar2:");
            int kenar2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kenar3:");
            int kenar3 = Convert.ToInt32(Console.ReadLine());
            
            if (kenar1*kenar1+kenar2*kenar2==kenar3*kenar3)
            {
                Console.WriteLine("Dik üçgen çizilir");
            }
            else if (kenar2*kenar2+kenar3*kenar3==kenar1*kenar1)
            {
                Console.WriteLine("Dik üçgen çizilir");
            }
            else if (kenar1*kenar1+kenar3*kenar3==kenar2*kenar2)
            {
                Console.WriteLine("Dik üçgen çizilir");
            }


        }
    }
}
