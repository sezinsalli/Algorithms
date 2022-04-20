using System;

namespace _5.KararYapıları5._3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A kenarının açısı:");
            int açıA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("B kenarının açısı");
            int açıB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("C kenarının açısı");
            int açıC = Convert.ToInt32(Console.ReadLine());

            
            if (açıA+ açıC == 90 || açıA + açıB == 90 || açıB+açıC==90)
            {
                Console.WriteLine("Dik çüçgendir.");
            }
            else
            {
                Console.WriteLine("Dik üçgen değildir.");
            }
        }
    }
}
