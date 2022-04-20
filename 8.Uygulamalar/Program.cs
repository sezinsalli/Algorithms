using System;

namespace _8.Uygulamalar
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            BasamakDegerleriniYazdir(number);
            Console.ReadLine();
        }
        private static void BasamakDegerleriniYazdir(int number)
        {
            int birlerBas = number % 10;
            int onlarBas = (number % 100) / 10;
            int yuzlerBas = (number % 1000) / 100;
            int binlerBas = (number % 10000) / 1000;

            int birlerSonuc = birlerBas;
            int onlarSonuc = onlarBas * 10;
            int yuzlerSonuc = yuzlerBas * 100;
            int binlerSonuc = binlerBas * 1000;

            Console.WriteLine($"{birlerBas} x 1 = {birlerSonuc}");
            Console.WriteLine($"{(number % 100) / 10} x 10 = {onlarSonuc}");
            Console.WriteLine($"{(number % 1000) / 100} x 100 = {yuzlerSonuc}");
            Console.WriteLine($"{(number % 10000) / 1000} x 1000 = {binlerSonuc}");

        }
    }
}
