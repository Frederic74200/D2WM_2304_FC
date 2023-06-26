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

            string fract = f2.ToString();
            Console.WriteLine(fract);
            Console.WriteLine(f3);

            Console.WriteLine("Hello, World!");

            Fraction f4 = new Fraction(120, -150);

            Fraction f5 = new Fraction(1790, 736);

            int pgdc = f4.GetPgcd();
            Console.WriteLine(pgdc.ToString());
            /*  f5.Reduire();
             Console.WriteLine(f5.ToString()); */


            Console.WriteLine("Hello, World!");
        }
    }
}