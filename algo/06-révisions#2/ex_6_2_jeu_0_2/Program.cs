namespace ex_6_2_jeu_0_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombreHumain;
            int nombreOrdi;
            int scoreHumain = 0;
            int scoreOdi = 0;
            int compteur = 0;

            bool more = true;

            Console.WriteLine("Jeu du 0-2");

            #region#PhaseDeJeu
            do
            {
                #region#SaisieHumain
                bool saisieOk = false;
                do
                {
                    Console.WriteLine(".................................................................\n\r" +
                        "Votre score : " + scoreHumain + " Score ordinateur : " + scoreOdi + "\n\r" +
                                       "Jouez 0, 1 ou 2 \n\r" +
                                       "Entrez un nombre négatif pour quitter");
                    string? saisie = Console.ReadLine();

                    saisieOk = int.TryParse(saisie, out nombreHumain);

                    if (nombreHumain > 2)
                    {
                        saisieOk = false;
                    }

                } while (!saisieOk);
                #endregion#SaisieHumain


                nombreOrdi = new Random().Next(3);

                Console.WriteLine("Vous avez jpué : " + nombreHumain + "\n\r" +
                                   "L'ordinateur a joué : " + nombreOrdi);

                compteur++;

                #region#PointsouQuit
                if (nombreHumain < 0)
                {
                    more = false;
                }

                else if (nombreHumain - nombreOrdi == 2)
                {
                    scoreHumain++;
                }

                else if (nombreOrdi - nombreHumain == 2)
                {
                    scoreOdi++;
                }
                else if (nombreHumain - nombreOrdi == 1)
                {
                    scoreOdi++;
                }

                else if (nombreOrdi - nombreHumain == 1)
                {
                    scoreHumain++;

                }
                else
                {
                    Console.WriteLine("Egalité !");
                }
                #endregion#PointsouQuit

            } while (more && scoreHumain < 10 && scoreOdi < 10);
            #endregion#PhaseDeJeu



            #region#Affichage

            if (scoreHumain >= 10)
            {
                Console.WriteLine("--------------------------------------------------------------------------------------- \n\r" +
                                   "Vous avez gagné ! \n\r" +
                    "Votre score : " + scoreHumain + " Score ordinateur : " + scoreOdi + "\n\r" +
                    "Nombre d'essais : " + compteur);
            }
            else if (scoreOdi >= 10)
            {
                Console.WriteLine("--------------------------------------------------------------------------------------- \n\r" +
                    "L'ordinateur a gagné ! \n\r" +
                   "Votre score : " + scoreHumain + " Score ordinateur : " + scoreOdi + "\n\r" +
                    "Nombre d'essais : " + compteur);
            }
            else
            {
                Console.WriteLine("Vous avez quitté le jeu.");
            }
            #endregion#Affichage
        }
    }
}