using System;

namespace BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int YearTax = int.Parse(Console.ReadLine());
            double Shoes = YearTax - (YearTax * 0.4);
            double Clothes = Shoes - (Shoes * 0.2);
            double Ball = Clothes * 0.25;
            double Aksess = Ball * 0.2;

            double WholeChash = YearTax + Shoes+ Clothes + Ball+ Aksess;

            Console.WriteLine(WholeChash);
            
            


        }
    }
}
