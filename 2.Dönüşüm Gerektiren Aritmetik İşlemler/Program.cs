using System;

namespace _2.Dönüşüm_Gerektiren_Aritmetik_İşlemler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı1 = 5;
            
            float sayı2=1.5f;

            Console.Write("toplam:");
            Console.WriteLine( (float)sayı1 + sayı2);

            Console.Write("Fark:");
            Console.WriteLine( (float)sayı1 - sayı2);

            Console.Write("Çarpma:");
            Console.WriteLine((float)sayı1 * sayı2);

            Console.Write("Bölme:");
            Console.WriteLine((float)sayı1 / sayı2);

        }
    }
}
