namespace ex_1_6_inversion_2_valeurs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // VARIABLES
            int a;
            int b;
            int tmp;

            //TRAITEMENT
            Console.WriteLine("Programme d'inversion de deux nombres");

            Console.WriteLine("Veuillez saisir le nombre A : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Veuillez saisir le nombre B : ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Avant l'inversion," + "\n\r"
                               + "Le nombre A est : " + a + "\n\r"
                               + "Le nombre B est " + b + "\n\r"
                               + "---------------------");
            tmp = a;
            a = b;
            b = tmp;

            // FIN TRAITEMENT


            // AFFICHAGE
            Console.WriteLine("Après l'inversion," + "\n\r"
                               + "Le nombre A est : " + a + "\n\r"
                               + "Le nombre B est " + b + "\n\r"
                               + "---------------------");


            Console.WriteLine("Veuillez appuyer sur une touche pour quitter");
            Console.ReadLine();

            // FIN PROGRAMME

        }
    }
}
