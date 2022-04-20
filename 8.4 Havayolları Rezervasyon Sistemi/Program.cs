using System;

namespace _8._4_Havayolları_Rezervasyon_Sistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Ekonomi ekonomi = new Ekonomi();
            Business business = new Business();

            Console.WriteLine("1.Business Class bölümüiçin 1 tuşuna basın \n 2.Economy Class bölümüiçin 2 tuşuna basın");
            int secim = Convert.ToInt32(Console.ReadLine());
            switch (secim)
            {
                case 1:
                    Console.WriteLine("Busıness Class'a hos geldınız");
                    Console.WriteLine("Lütfen numara gırınız : ");
                    int numara = Convert.ToInt32(Console.ReadLine());
                    ekonomi.Yazdır(numara);
                    break;
                case 2:
                    Console.WriteLine("Ekonomi Class'a hos geldınız");
                    Console.WriteLine("Lütfen numra gırınız : ");
                    numara = Convert.ToInt32(Console.ReadLine());
                    business.NumaraVer(numara);
                    break;
               
            }
        }

    }
    class Ekonomi
    {
        int[] koltuk = new int[12];
        string[] isim = new string[12];
        public void Yazdır(int numara) 
        {
            for (int i = 0; i <koltuk.Length; i++)
            {
                if (koltuk[i]==null)
                {
                    Console.WriteLine(koltuk[i]);
                    koltuk[i] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Lütfen isminizi giriniz :");
                    isim[i] = Console.ReadLine();
                    Console.WriteLine(koltuk[i] + "numaralı koltuk" + isim[i] + "adına ayırtılmıstır.");
                }
               
                else
                {
                    Console.WriteLine("koltuk dolu koltuk numarası : " + koltuk[i] + "koltuk ısmı  " + isim[i]);
                }
            }
            
               
        }


    }
    class Business
    {
        int[] koltuk2 = new int[8];
        string[] isim2 = new string[8];
        public void NumaraVer(int numara)
        {
            for (int i = 0; i < koltuk2.Length; i++)
            {
                if (koltuk2[i] == null)
                {
                    Console.WriteLine(koltuk2[i]);
                    koltuk2[i] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Lütfen isminizi giriniz :");
                    isim2[i] = Console.ReadLine();
                    Console.WriteLine(koltuk2[i] + "numaralı koltuk" + isim2[i] + "adına ayırtılmıstır.");
                }

                else
                {
                    Console.WriteLine("koltuk dolu koltuk numarası : " + koltuk2[i] + "koltuk ısmı  " + isim2[i]);
                }
            }


        }

    }
}
