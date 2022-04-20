using System;

namespace _5.Karar_yapısı_5._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bır sayı gırınız ");

            int sayı1 = Convert.ToInt32(Console.ReadLine());

            if (sayı1%2==0)
            {
                Console.WriteLine("Sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Sayı tektir.");
            }

        }
    }
}
