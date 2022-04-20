using System;

namespace _4.Mantıksal_İşlemeler_ve_Operatörler4._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sezinYas = 31;
            int fatihYas = 35;
            int keremYas = 2;

            bool isEqual = sezinYas == fatihYas && fatihYas == keremYas;
            bool isnotEqual = sezinYas != fatihYas || sezinYas != keremYas || fatihYas != keremYas;
            bool isGreater = sezinYas > keremYas && sezinYas > fatihYas;
            bool isSmaller= sezinYas < keremYas && sezinYas < fatihYas;

            Console.WriteLine("Sezin fatih ve kerem'in yaşları eşit mi?");
            Console.WriteLine(isEqual);
            Console.WriteLine("Sezin fatih ve kerem'in yaşları eşitdeğil  mi?");
            Console.WriteLine(isnotEqual);
            Console.WriteLine("Sezin fatih ve kerem''den buyuk mu??");
            Console.WriteLine(isGreater);
            Console.WriteLine("Sezin fatih ve kerem''den kucuk mu??");
            Console.WriteLine(isSmaller);
        }
    }
}
