using ClassLibraryFraction;

namespace ConsoleAppFraction2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Fraction f1 = new Fraction(12, 7);
            Fraction f2 = new Fraction();
            Fraction f3 = new Fraction(9);


            Console.WriteLine(f1.ToString());

            string fract = f2.ToString();
            Console.WriteLine(fract);
            Console.WriteLine(f3);

            Console.WriteLine("---------------------Oppose---------------------------------");
            f1.Oppose();
            Console.WriteLine(f1);



            Console.WriteLine("---------------------Inverse---------------------------------");

            f1.Inverse();
            Console.WriteLine(f1);

            Console.WriteLine("---------------------Superieure-  7/12  9/1 --------------------------------");

            bool sup = f1.SuperieurA(f3);
            Console.WriteLine(sup);

            Console.WriteLine("---------------------égale -  clone f1 --------------------------------");

            Fraction F1Bis = new Fraction(f1);
            bool egal = f1.EgalA(F1Bis);
            Console.WriteLine(egal);


            Console.WriteLine("------------------------------------------------------");


            Fraction f4 = new Fraction(120, -150);

            Console.WriteLine(f4);

            int ppdc = f4.GetPgcd();

            Console.WriteLine(ppdc+"");


            f4.Reduire();

            Console.WriteLine(f4);


            Console.WriteLine("------------------------------------------------------");

            Fraction f5 = new Fraction(63, 46);
            Fraction f6 = new Fraction(17, 16);

            Console.WriteLine("1ère faction : "+f5);

            Console.WriteLine("2ème faction : " + f6);

            Console.WriteLine("-------------------------PLUS-------------------------");
            Fraction f5PlusF6 = f5.Plus(f6);
            Console.WriteLine(f5PlusF6);

            Console.WriteLine("-------------------------MOINS-------------------------");

            Fraction f5MoinsF6 = f5.Moins(f6);
            Console.WriteLine(f5MoinsF6);


            Console.WriteLine("-------------------------FOIS-------------------------");
            Fraction f5FoisF6 = f5.Multiplie(f6);
            Console.WriteLine(f5FoisF6);

            Console.WriteLine("-------------------------DIVISE-------------------------");

            Fraction fDiviseF6 = f5.Divise(f6);
            Console.WriteLine(fDiviseF6);


        }
    }
} 