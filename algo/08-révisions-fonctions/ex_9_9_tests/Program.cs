using System.Text;
using System.Text.RegularExpressions;

namespace ex_9_9_tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

           /* string somestring = "abcdefg";
            StringBuilder sb = new StringBuilder(somestring);
            sb.Remove(3, 1);
            somestring = sb.ToString();
            Console.WriteLine(sb.ToString());*/






            String motAtrouver = "radar";
             List<char> motAvecTirets = new List<char>() {'r','-', '-', '-','r' };
             char lettreSaise = 'a';
            string newString ="";

            // StringBuilder sb = new StringBuilder(motAvecTirets);

           //  int lettretrouvee = 0;

             for (int j = 1; j < motAtrouver.Length - 1; j++)
             {
                 if (motAtrouver[j].CompareTo(lettreSaise) == 0)
                 {
                    Console.WriteLine("Trouvé !");
                  //  motAvecTirets.RemoveAt(j);
                   // motAvecTirets.Insert(j, lettreSaise);

                    motAvecTirets[j] = lettreSaise;
                
                 }
             }
            


            for (int i = 0; i < motAvecTirets.Count; i++)
            {
                newString += motAvecTirets[i].ToString();
            }


            Console.WriteLine(newString);
        }
    }
}