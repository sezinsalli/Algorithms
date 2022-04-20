using System;

namespace _5.KararYapıları5._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kenar1:");
            double kenara = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kenar2:");
            double kenarb = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Kenar3:");
            double kenarc = Convert.ToDouble(Console.ReadLine());

            
            if (Math.Abs(kenara - kenarb) < kenarc && kenarc<kenara+kenarb)
            {
                Console.WriteLine("Üçgen çizilir");
            }
            else if (Math.Abs(kenarb - kenarc)<kenara&&kenara<kenarb+kenarc)
            {
                Console.WriteLine("Üçgen çizilir");
            }
            else if (Math.Abs(kenara - kenarc)<kenarb&&kenarb<kenara+kenarc)
            {
                Console.WriteLine("Üçgen çizilir");
            }
            else
            {
                Console.WriteLine("Üçgen çizilemez");
            }
        }
    }
}
