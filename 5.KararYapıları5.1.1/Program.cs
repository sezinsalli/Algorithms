using System;

namespace _5.KararYapıları5._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kullanıcı adı giriniz örnegın ısmınız Sezin ise Sezinİnyayla şeklinde :");
            string kullanıcıadı = Console.ReadLine();
            string kullanıcı1 = "Sezinİnyayla";
            
            Console.WriteLine("Şifre giriniz ");
            string sifre = Console.ReadLine();
            string sifre1 = "1234";
            if (kullanıcıadı==kullanıcı1&&sifre==sifre1)
            {
                Console.WriteLine("Girişiniz başarıyla sağlandı.");
            }
            else
            {
                Console.WriteLine("Başarısız giriş yaptınız.Girilen değer:" + kullanıcıadı, "olması gereken :" + kullanıcı1 + "Girilen sifre:" + sifre + "Olması gereken:" + sifre1);
            }



        }
    }
}
