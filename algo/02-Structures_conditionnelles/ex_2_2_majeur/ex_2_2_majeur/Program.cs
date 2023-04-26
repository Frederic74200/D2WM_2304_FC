namespace ex_2_2_majeur
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // VARIABLES
            int ageA;
            String saisieA;
            bool saisieAok;


            //TRAITEMENT
            Console.WriteLine("Étes-vous majeur.e ?");

            do
            {
                Console.WriteLine("Veuillez saisir votre âge :");
                saisieA = Console.ReadLine();

                saisieAok = int.TryParse(saisieA, out ageA);

                if (!saisieAok)
                {
                    Console.WriteLine("Veuillez recommencer.");
                }
            } while (!saisieAok);


            if (ageA < 0)
            {
                Console.WriteLine("Vous n'êtes pas encore né.e");
            }
            else if (ageA > 0 && ageA < 18)
            {
                Console.WriteLine("Vous êtes mineur.e");
            }
            else
            {
                Console.WriteLine("Vous êtes majeur.e.");
            }

            //FIN TRAITEMENT

            Console.WriteLine("Appuyez sur une touche pour quitter");
            Console.ReadLine();

            //FIN PROGRAMME


        }
    }
}