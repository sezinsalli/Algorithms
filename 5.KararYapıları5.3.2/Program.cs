using System;

namespace _5.KararYapıları5._3._2
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

            int toplam = açıA + açıB + açıC;
            if (toplam==180)
            {
                Console.WriteLine("Üçgen çizilir" + "a açısı:" + açıA + "b açısı:" + açıB + "c açısı" + açıC);
            }
            else
            {
                Console.WriteLine("Üçgen çizilemez");
            }


        }
    }
}
