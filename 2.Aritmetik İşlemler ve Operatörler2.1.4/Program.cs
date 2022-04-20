using System;

namespace _2.Aritmetik_İşlemler_ve_Operatörler2._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lütfen sayı1 girişi yapınız :");
            int sayı1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("lütfen sayı2 girişi yapınız :");
            int sayı2 = Convert.ToInt32(Console.ReadLine());
            while (sayı2==0)
            {
                Console.WriteLine("lütfen 0 girişi yapmayınız :");
                sayı2 = Convert.ToInt32(Console.ReadLine());

            }
            int bölüm = sayı1/sayı2;
            Console.WriteLine("Bölüm :" +bölüm);


        }
    }
}
