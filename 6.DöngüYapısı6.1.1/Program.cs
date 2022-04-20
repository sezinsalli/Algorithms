using System;

namespace _6.DöngüYapısı6._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int adet = 10;
            int sayı = 0;
            int enBuyuk1 = 0;
            int enBuyuk2 = 0;
            sayı = enBuyuk1;
            
            do
            {
                Console.WriteLine("Lütfen sayı değişkeni giriniz :");
                for (int i = 0; i < adet; i++)
                {
                    sayı = Convert.ToInt32(Console.ReadLine());
                }
                if (sayı > enBuyuk1)
                {
                    enBuyuk2 = enBuyuk1;
                    enBuyuk1 = sayı;
                    if (enBuyuk1 % 5 == 0)
                    {
                        Console.WriteLine("en buyuk sayı:" + " " + enBuyuk1);
                    }
                }
                Console.WriteLine("end yazarsanız program kapanır.");
                string cvp= Console.ReadLine();
                if (cvp==" ")
                {
                    break;
                }
                adet--;


            } while (adet!=0);








            for (int i = 0; i < adet; i++)
            {
                sayı = Convert.ToInt32(Console.ReadLine());
            }
            if (sayı > enBuyuk1)
            {
                enBuyuk2 = enBuyuk1;
                enBuyuk1 = sayı;
                if (enBuyuk1 % 5 == 0)
                {
                    Console.WriteLine("en buyuk sayı:" + " " + enBuyuk1);
                }
            }
        }
    }
}
