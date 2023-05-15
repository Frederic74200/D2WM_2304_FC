using System.Globalization;

namespace ex_9_9_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // test 

            /* int[] tableau = new int[20];
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
            */

            String chaine = "12a 3 , 4";
            int total = 0;
            int chiffres  ;
            
            
            if (char.IsNumber(chaine[1]) ) {

                chiffres = chaine[1];
                Console.WriteLine(chiffres);
            }

            /*
            foreach (char ch in chaine)
            {
                if (char.IsNumber(ch, total))
                {

                    total += ch;

                    Console.WriteLine(ch);


                }
            }
            */

            /*

             for (int i = 0; i < chaine.Length; i++)
            {
                if (char.IsNumber(chaine[i] ))
                {
                  chiffres = chaine[i] - '0';
                    Console.WriteLine(chiffres);
                    total += chiffres;


                }
            }
            

            Console.WriteLine("Total : "+ total);



           // Split(';').Select(n => Convert.ToInt32(n)).ToArray(); */
        }
    }
}