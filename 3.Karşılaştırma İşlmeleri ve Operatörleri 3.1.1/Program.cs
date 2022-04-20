using System;

namespace _3.Karşılaştırma_İşlmeleri_ve_Operatörleri_3._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Degisken 1 giriş yapınız :");
            string degisken1 = Console.ReadLine();

            Console.WriteLine("Degisşken 2 giriş yapınız :");
            string degisken2 = Console.ReadLine();

            bool isEqual = degisken1 == degisken2;
            bool isNotEqual = degisken1 != degisken2;

            Console.WriteLine(degisken1 + "ifadesi " + degisken2 + "ifadesine eşit midir?");
            Console.WriteLine(isEqual);

            Console.WriteLine(degisken1 + "ifadesi" + degisken2 + "ifadesinden farklı mıdır?");
            Console.WriteLine(isNotEqual);



        }
    }
}
