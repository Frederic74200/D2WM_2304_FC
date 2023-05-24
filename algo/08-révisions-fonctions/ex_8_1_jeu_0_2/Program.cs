namespace ex_8_1_jeu_0_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Jeu_0_2 mainJeu_0_2 = new Jeu_0_2();
            //  Jeu_0_2 nouveaauJeu = new Jeu_0_2(0, -2,12);


            bool sortirDuJeu = false;
            bool premierAdix = false;


            Console.WriteLine("Jeu du 0 2");


            do
            {
                bool siaiseOK = false;
                //top
                do
                {
                    Console.WriteLine(".................................................................\n\r" +
                                            "Votre score : " + mainJeu_0_2.getScroreHumain() + " Score ordinateur : " + mainJeu_0_2.getScoreOrdi() + "\n\r" +
                                            "Jouez 0, 1 ou 2 \n\r" +
                                            "Entrez un nombre négatif pour quitter");
                    string? saisie = Console.ReadLine();
                    siaiseOK = mainJeu_0_2.verificationSaisie(saisie);
                } while (!siaiseOK);


                int jeuJoueur = mainJeu_0_2.getNombreHumain();
                sortirDuJeu = mainJeu_0_2.quitterJeu(jeuJoueur);
                int jeuPC = mainJeu_0_2.setNombreOrdi();


                //Console.WriteLine("Vous avez joué : " + jeuJoueur + "\n\r"
                //                  + "L'ordinateur a joué : " + jeuPC);


                mainJeu_0_2.phaseDeJeu();

                premierAdix = mainJeu_0_2.scoreAtteint();


            } while (!sortirDuJeu && !premierAdix);


            mainJeu_0_2.affichageApresJeu();


        }

    }
}