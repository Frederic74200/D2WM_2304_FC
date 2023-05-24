using System.Text;
using System.Text.RegularExpressions;

namespace ex_9_9_tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*  int capitalEmprunte = 12000;
              double mensualite;
              int mois;
              double tauxInteretmensuel;
              int nbMoisNegatif;

              mois = 60;
              nbMoisNegatif = 0 - mois;
              tauxInteretmensuel = 0.005;

              mensualite = (capitalEmprunte * tauxInteretmensuel) / (1 - Math.Pow((1 + tauxInteretmensuel), nbMoisNegatif));

              Console.WriteLine(Math.Round(mensualite, 2)); */

            /* List<List<string>> myList = new List<List<string>>();
              myList.Add(new List<string> { "a", "b" });
              myList.Add(new List<string> { "c", "d", "e" });
              myList.Add(new List<string> { "qwerty", "asdf", "zxcv" });
              myList.Add(new List<string> { "a", "b" });

              // To iterate over it.
              foreach (List<string> subList in myList)
              {
                  foreach (string item in subList)
                  {
                      Console.WriteLine(item);
                  }
              }

              */



            
            List<List<double>> myList = new List<List<double>>();
            myList.Add(new List<double> { 0, 1, 2, 3 });
            myList.Add(new List<double> {337.4, 23.756, 47,5, 16.33 });
            myList.Add(new List<double> { 123, 47.55, 14.18, 45 });
            myList.Add(new List<double> { 0.01, 0.1});

            // To iterate over it.
            foreach (List<double> subList in myList)
            {
                

                foreach (double item in subList)
                {
                    Console.Write(String.Format("|{0,9} ", item));
                }

                Console.Write("\n\r");
            }

            

            /*

            int arg0 = 0 ; int arg1 = 777 ; int arg2 = 48 ; int arg3 = 12345;

            Console.WriteLine(
            String.Format("|{0,5}|{1,5}|{2,5}|{3,5}|", arg0, arg1, arg2, arg3) );

            */

        }
    }
}