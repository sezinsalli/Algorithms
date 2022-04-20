using System;
using System.Collections.Generic;

namespace _6.DöngüYapısı6._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string cvp;
            List<int> karesi = new List<int>();
            List<int> küpü = new List<int>();
            do
            {
                Console.WriteLine("LÜtfen sayı1 gırısı yapınız :");
                int sayı1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Lütfen sayı2 gırısı yapınız :");
                int sayı2 = Convert.ToInt32(Console.ReadLine());

                if (sayı1>sayı2)
                {
                   
                    for (int i = sayı2; i <= sayı1; i++)
                    {
                       int sayı= i * i;
                        karesi.Add(sayı);
                    }
                    for (int i = sayı2; i <= sayı1; i++)
                    {
                        int sayı = i * i*i;
                        küpü.Add(sayı);
                    }

                }
                else
                {
                    for (int i = sayı1; i <= sayı2; i++)
                    {
                        int sayı = i * i;
                        karesi.Add(sayı);

                    }
                    for (int i = sayı1; i <= sayı2; i++)
                    {
                        int sayı = i * i*i;
                        küpü.Add(sayı);

                    }

                }
                Console.WriteLine("Sayıların karesi:");
                foreach (var item in karesi)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Sayıların küpü:");
                foreach (var item in küpü)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("Programın bıtmesını ıstıyorsanız end yazınız");
                cvp = Console.ReadLine();

            } while (cvp !="end");
        }
    }
}
