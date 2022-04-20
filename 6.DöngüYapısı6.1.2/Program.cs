using System;

namespace _6.DöngüYapısı6._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int adet;
            int sayı = 0;
            int enBuyuk1 = 0;
            int enBuyuk2 = 0;
            sayı = enBuyuk1;
            string cvp;

            Console.WriteLine("Lütfen sayı adeti gırısı yapınız:");
            adet = Convert.ToInt32(Console.ReadLine());
            while (adet < 2)
            {
                Console.WriteLine("Lütfen tekrar giriş yapınız: ");
                adet = Convert.ToInt32(Console.ReadLine());
            }
            do
            {
                

                Console.WriteLine("Lütfen sayı gırısı yapınız:");
                sayı = Convert.ToInt32(Console.ReadLine());
                if (sayı > enBuyuk1)
                {
                    enBuyuk2 = enBuyuk1;
                    enBuyuk1 = sayı;
                    if (enBuyuk1 % 5 == 0)
                    {
                        Console.WriteLine(enBuyuk1);
                    }
                }

                Console.WriteLine("devam etmek ıstıyor musunuz? ıstemıyorsanız end yazınız");
                cvp = Console.ReadLine();
                if (cvp == "end")
                {
                    Console.WriteLine("en buyuk sayı:" + " " + enBuyuk1);
                    
                }

                

            } while (cvp != "exit");
        }
    }
}
