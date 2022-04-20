using System;

namespace _8._2.palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PALİDROM KELİMELER");

            KontrolPalindrom();
            StringPalindrom();
        }
        static void KontrolPalindrom()
        {
            int number, remind, sum = 0, temp;
            


            Console.Write("Lütfen sayı gırısı yapınız: ");
            number = Convert.ToInt32(Console.ReadLine());
            temp = number;
            while (number > 0)
            {
                remind = number % 10;
                number = number / 10;
                sum = sum * 10 + remind;

            }
            Console.WriteLine("Ters cevrılen sayı: {0} ", sum);

            if (temp == sum)
            {
                Console.WriteLine("Palindorm sayıdır.");
            }
            else
            {
                Console.WriteLine("Palindrom sayı değildir.");
            }
            Console.ReadLine();
            Console.Clear();

        }
        static void StringPalindrom()
        {
            string s, revs = "";
            Console.WriteLine("Lütfen bir kelime giriniz : ");
            s = Console.ReadLine();
            s = s.Trim();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                revs += s[i].ToString();
            }
            if (revs == s)
            {
                Console.WriteLine("Kelime palindrom  Girdiğiniz kelime {0} ve ters cevırılen kelime {1}", s, revs);

            }
            else
            {
                Console.WriteLine("Kelime palindrom değil   Girdiğiniz kelimeg {0} ve  ters cevırılen kelime { 1 }", s, revs);
            }
            Console.ReadKey();
        }



    }
}
