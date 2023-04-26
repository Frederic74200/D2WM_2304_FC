namespace ex_2_3_retraite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES
            String saisieAge;
            int ageA;
            bool saisieValide;

            // TRAITEMENT
            Console.WriteLine("Étes-vous à la retraite ?");

            do
            {
                Console.WriteLine("Veuillez saisir votre âge : ");
                saisieAge = Console.ReadLine();     

                saisieValide = int.TryParse(saisieAge, out ageA);

                if (!saisieValide)
                {
                    Console.WriteLine("La valeur fournie n'est pas valide.");
                }
            } while (!saisieValide);


            if (ageA > 60)
            {
                Console.WriteLine("Vous êtes à la retraite depuis "+ (ageA-60) + " années");
            }
            else if (ageA < 60)
            {
                Console.WriteLine("Il vous reste " + (60-ageA) + " années avant la retraite.");
            }
            else
            {
                Console.WriteLine("C'est le moment de prendre la retraite.");
            }

            // FIN TRAITEMENT
            Console.WriteLine("ppuyez sur une touche pour quitter le programme");
            Console.ReadLine();


            // FIN PROGRAMME
        }
    }
}