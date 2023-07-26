using ClassLibraryPoint;

namespace ConsoleAppPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Point point = new Point(-4,3);

            Point nouveauY =  point.ConstruirePointSymetriqueOrdonnee();
            Point nouveauX = point.ConstruirePointSymetriqueAbscisse();
            Point opositionXY = point.ConstruirePointSymetriqueOrigine();   


            Console.WriteLine("Hello, World!");


        }
    }
}