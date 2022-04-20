using System;

namespace Karar_Yapıları5._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Lütfen Sayı1 girişi yapınız : ");
            int sayı1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Lütfen Sayı2 girişi yapınız : ");
            int sayı2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Lütfen Sayı3 girişi yapınız : ");
            int sayı3 = Convert.ToInt32(Console.ReadLine());

            if (sayı1>sayı2&&sayı1>sayı3)
            {
                Console.WriteLine("n buyuk sayı sayı1 :"+ sayı1);
                if (sayı2>sayı3)
                {
                    Console.WriteLine("En kucuk sayı :"+ sayı3);
                }
                else
                {
                    Console.WriteLine("En kucuk sayı :"+ sayı2);
                }



            }
            else if (sayı2>sayı1&&sayı2>sayı3)
            {
                Console.WriteLine("n buyuk sayı sayı1 :"+ sayı2);
                if (sayı1 > sayı3)
                {
                    Console.WriteLine("En kucuk sayı :"+sayı3);
                }
                else
                {
                    Console.WriteLine("En kucuk sayı :"+sayı1);
                }

            }

            else if(sayı3>sayı1&&sayı3>sayı2)
            {
                Console.WriteLine("En buyuk sayı:"+ sayı3);
                if (sayı1>sayı2)
                {
                    Console.WriteLine("En kucuk sayı"+sayı2);
                }

                else 
                {
                    Console.WriteLine("En kucuk sayı"+sayı1);
                }

            }

        }
    }
}
