using ClassLibraryFraction;

namespace ConsoleAppFonction2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Fraction f1 = new Fraction(12, 7);
            Fraction f2 = new Fraction();
            Fraction f3 = new Fraction(9);

           
           Console.WriteLine(f1.ToString());
            Console.WriteLine(f2.FractionToString());
            Console.WriteLine(f3);

             Console.WriteLine("Hello, World!");
        }
    }
}