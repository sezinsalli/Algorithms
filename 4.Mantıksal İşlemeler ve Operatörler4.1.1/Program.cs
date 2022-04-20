using System;

namespace _4.Mantıksal_İşlemeler_ve_Operatörler4._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı1 gırınız: ");
            int sayı1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayı2 gırınız: ");
            int sayı2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sayı3 gırınız: ");
            int sayı3 = Convert.ToInt32(Console.ReadLine());

            bool isEqual = sayı1 == sayı2 && sayı3 == sayı2;
            bool isSmaller = sayı1 < sayı2 && sayı1 < sayı3;
            bool isGreater = sayı1 > sayı2 && sayı1 > sayı3;

            Console.WriteLine(sayı1 + "sayısı" + sayı2 + "ve" + sayı3 + "sayısından buyuk mudur?");
            Console.WriteLine(isGreater);

            Console.WriteLine(sayı1 + "sayısı" + sayı2 + "ve" + sayı3 + "sayısından kucuk mudur?");
            Console.WriteLine(isSmaller);


            Console.WriteLine(sayı1 + "sayısı" + sayı2 + "ve" + sayı3 + "sayısına eşit midir?");
            Console.WriteLine(isEqual);











        }
    }
}
