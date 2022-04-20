using System;

namespace _5.KararYapıları5._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sayı1 gırınız ");

            int sayı1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Lütfen sayı2 gırınız ");

            int sayı2 = Convert.ToInt32(Console.ReadLine());

            if (sayı1>sayı2 && sayı1%sayı1==0)
            {
                Console.WriteLine("Tam katıdır.");
            }
            else if (sayı2 > sayı1 && sayı2 % sayı1 == 0)
            {
                Console.WriteLine("Tam katıdır.");
            }
            else
            {
                Console.WriteLine("Tam  katı değildir.");
            }

        }
    }
}
