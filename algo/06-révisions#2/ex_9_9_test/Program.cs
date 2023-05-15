using System.Globalization;

namespace ex_9_9_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // test 

            int[] tableau = new int[20];
            Console.WriteLine("test");
            string saisie = Console.ReadLine();

            try
            {
                tableau = saisie.Split(" ").Select(int.Parse).ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erreur");    
            }



            foreach (int i in tableau) { Console.WriteLine(i); }





           // Split(';').Select(n => Convert.ToInt32(n)).ToArray();
        }
    }
}