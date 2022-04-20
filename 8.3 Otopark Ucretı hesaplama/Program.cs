using System;

namespace _8._3_Otopark_Ucretı_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen araç tipi seçiniz: 1-Otomobil 2- Motorsiklet 3- Minübüs 4-Kamyon");
            Otomobil otomobil = new Otomobil();
            Motorsiklet motorsiklet = new Motorsiklet();
            Minübüs minübüs = new Minübüs();
            Kamyon kamyon = new Kamyon();


            int secim = Convert.ToInt32(Console.ReadLine());
            double saat;
            
            switch (secim)
            {
                case 1:
                    Console.WriteLine("1-Otomobil");
                    Console.WriteLine("kaç saat kaldınız :");
                    saat = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(otomobil.Hesapla(saat));
                    
                    
                    break;
                case 2:
                    Console.WriteLine("2- Motorsiklet");
                    Console.WriteLine("kaç saat kaldınız :");
                    saat = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(motorsiklet.Hesapla2(saat));
                    

                    break;
                case 3:
                    Console.WriteLine("3- Minübüs");
                    Console.WriteLine("kaç saat kaldınız :");
                    saat = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(minübüs.Hesapla3(saat));
                    break;
                case 4:
                    Console.WriteLine("4-Kamyon");
                    Console.WriteLine("kaç saat kaldınız :");
                    saat = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(kamyon.Hesapla4(saat));
                    break;                
            }
            
        }
    }
}
