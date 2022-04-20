using System;

namespace _3.Karşılaştırma_İşlmeleri_ve_Operatörleri_3._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ekrandan okunan iki karakteri karşılaştırma");

            Console.WriteLine("karakter1 'ı gırınız :");
            char karakter1 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("karakter2 'yı gırınız :");
            char karakter2 = Convert.ToChar(Console.ReadLine());

            bool isEqual = karakter1 == karakter2;
            bool isGreater = karakter1 > karakter2;
            Console.WriteLine("karakter1"+karakter1+"karakter 2 "+karakter2+"ıfadesıne eşit midir ?");
            Console.WriteLine(isEqual);

            Console.WriteLine("karakter1" + karakter1 + "karakter 2 " + karakter2 + "ıfadesınden buyuk mudur  ?");
            Console.WriteLine(isGreater);

        }
    }
}
