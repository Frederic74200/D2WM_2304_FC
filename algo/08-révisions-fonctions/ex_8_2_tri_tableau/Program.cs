namespace ex_8_2_tri_tableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            TableauTri tbtr = new TableauTri();
            TableauTri tbtr2 = new TableauTri(new List<int> { 13, 545, 89, 81, 2, 789, 123, 54, 755, 7, 333, 1});

            tbtr.printTableau();
            Console.WriteLine("\n\r");
            tbtr2.printTableau();

            tbtr.TrierLeTableau();
            tbtr2.TrierLeTableau();

            Console.WriteLine("\n\r");
            tbtr.printTableau();
            Console.WriteLine("\n\r");
            tbtr2.printTableau();




        }
    }
}