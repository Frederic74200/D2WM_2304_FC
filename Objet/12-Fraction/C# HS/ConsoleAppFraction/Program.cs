using ClassLibraryFraction;

namespace ConsoleAppFraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Fraction f1 = new Fraction(12,7);
            Fraction f2 = new Fraction();
            Fraction f3 = new Fraction(9);

            Console.WriteLine("F1 : "+f1.Numerator+" | "+f1.Denominator);
            Console.WriteLine("F2 : " + f2.Numerator + " | " + f2.Denominator);
            Console.WriteLine("F3 : " + f3.Numerator + " | " + f3.Denominator);

        }
    }
}