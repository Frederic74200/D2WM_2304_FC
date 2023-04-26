namespace ex_2_1_tri_2_Nombres
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // VARIABLES
            String saisieA;
            int a;
            bool saisieAok;
            String saisieB;
            int b;
            bool saisieBok;
            int min;
            int max;


            // TRAIEMENT
            Console.WriteLine("Programme de tri de deux nombres entiers dans l'ordre croissant");

            do {
                Console.WriteLine("Veuillez saisir le premier nombre entier : ");
                saisieA = Console.ReadLine();   
                saisieAok = int.TryParse(saisieA, out a);

                if (!saisieAok)
                {
                    Console.WriteLine("Veuillez recommencer.");
                }
            } while (!saisieAok);


             do {
                Console.WriteLine("Veuillez saisir le deuxième nombre entier : ");
                saisieB = Console.ReadLine();   
                saisieBok = int.TryParse(saisieB, out b);

                if (!saisieBok)
                {
                    Console.WriteLine("Veuillez recommencer.");
                }
            } while (!saisieBok);

            if (a < b )
            {
                min = a;
                max = b;
            }

            else
            {
                min = b;
                max = a;
            }

            // FIN TRAITEMENT

            // AFFICHAGE

            Console.WriteLine("Vous avez saisi : "+a+" et "+b+"\n\r"
                               +"L'ordre croissant est : "+a+", "+b);

            Console.WriteLine("Veuillez appuyer sur une touche pour quitter.");
            Console.ReadLine(); 

            // FIN PROGRAMME

        }
    }
}