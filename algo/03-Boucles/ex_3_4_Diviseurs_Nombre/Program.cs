/* Lire un nombre entier et afficher tous ses diviseurs autres que 1 et lui-même.*/

internal class Program
{
    private static void Main(string[] args)
    {
        int nombreSaisi;
        string saisie;
        bool saisieOk;

        int diviseur;
        bool diviseurTrouve = false;

        string listeDiviseurs = "";
        string separateur = " | ";


        Console.WriteLine("Programme de recherche des diviseurs d'un nombre entier.");

        do
        {
            Console.WriteLine("Saisissez un nombre entier positif.");
            saisie = Console.ReadLine();

            saisieOk = int.TryParse(saisie, out nombreSaisi);

            if (nombreSaisi < 1)
            {
                saisieOk = false;
            }

        } while (!saisieOk);


        Console.WriteLine(nombreSaisi);

      
        for (diviseur = 2; diviseur < nombreSaisi; diviseur++)
        {
            if (nombreSaisi % diviseur == 0)
            {
                listeDiviseurs = listeDiviseurs + separateur + diviseur.ToString();
               
              //  Console.WriteLine(diviseur.ToString() + " ");
                diviseurTrouve = true;

            }

        }
            if (!diviseurTrouve)
            {
                Console.WriteLine("Le nombre : " + nombreSaisi + " est un nombre premier.");
            }

            else
            {

                Console.WriteLine("Les diviseurs du nombre ." + nombreSaisi + " sont : " + listeDiviseurs);
            } 
        }
    }
