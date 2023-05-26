using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ex_8_3_ammortissment_emprunt
{
    internal class AmortissementEmprunt
    {

        // Attributs ----------------------------------------------------------------------------------------------

        private int capitalEmprunte;
        private int nbrAnneeRbmt;
        private double tauxInteretAnnuel;

        private double mois;
        private double tauxInteretmensuel;

        // tableau dynamique 2 dimensiosn 

        List<List<double>> tableau = new List<List<double>>();

        private int moisAconsulter;




        // constructeurs ------------------------------------------------------------------------------------------

        // par défaut
        public AmortissementEmprunt()
        {
            this.capitalEmprunte = 12000;
            this.nbrAnneeRbmt = 5;
            this.tauxInteretAnnuel = 6;
        }

        // avec paramètres
        public AmortissementEmprunt(int _capitalEmprunte, int _nbrAnneeRbmt, double _tauxInteretAnnuel)
        {
            this.capitalEmprunte = _capitalEmprunte;
            this.nbrAnneeRbmt = _nbrAnneeRbmt;
            this.tauxInteretAnnuel = _tauxInteretAnnuel;
        }


        // accesseurs ----------------------------------------------------------------------------------





        // mutateurs ------------------------------------------------------------------------------------------

        public int saisirCapitalEmprunte()
        {
            bool saisieOk = false;

            do
            {
                Console.WriteLine("Saisissez le capital emprunté : ");
                string? saisie = Console.ReadLine();

                saisieOk = int.TryParse(saisie, out this.capitalEmprunte);

            } while (!saisieOk);

            return this.capitalEmprunte;
        }

        public int saisirNombreAnnees()
        {
            bool saisieOk = false;

            do
            {
                Console.WriteLine("Saisissez le nombre d'années de remboursements : ");
                string? saisie = Console.ReadLine();

                saisieOk = int.TryParse(saisie, out this.nbrAnneeRbmt);

            } while (!saisieOk);


            return this.nbrAnneeRbmt;
        }

        public double saisirTauxAnnuel()
        {
            bool saisieOk = false;

            do
            {
                Console.WriteLine("Saisissez le taux d'intérêt annuel en poucentage: ");
                string? saisie = Console.ReadLine();

                saisieOk = double.TryParse(saisie, out this.tauxInteretAnnuel);

            } while (!saisieOk);

            return this.tauxInteretAnnuel;
        }

        // fonctions --------------------------------------------------------------------------------------------


        // petis calculs 

        public double getMois()
        {
            this.mois = this.nbrAnneeRbmt * 12;
            return this.mois;
        }

        public double getTauxMensuel()
        {
            this.tauxInteretmensuel = this.tauxInteretAnnuel / 12 / 100;
            return this.tauxInteretmensuel;
        }



        // Saisie capital, nombre années, taux

        public void saisirInfos()
        {
            saisirCapitalEmprunte();
            saisirNombreAnnees();
            saisirTauxAnnuel();
        }

        // calcul mensualité

        public double calculerMensualite()
        {
            double mensualite;
            double tm = getTauxMensuel();

            double nbMoisNegatif;

            this.mois = this.nbrAnneeRbmt * 12;
            nbMoisNegatif = 0 - this.mois;

            mensualite = (this.capitalEmprunte * tm / (1 - Math.Pow((1 + tm), nbMoisNegatif)));

            return mensualite;

        }




        // construction tableau ----------------------------------------------
        public List<List<double>> construireTableau()
        {
            tableau.Add(new List<double>());
            tableau.Add(new List<double>());
            tableau.Add(new List<double>());
            tableau.Add(new List<double>());
            tableau.Add(new List<double>());


            return this.tableau;
        }


        // reprise remplisage tableau 


        public void remplirColonnesIndex_1_2_3()
        {


            for (int i = 0; i < getMois() + 1; i++)
            {

                if (i == 0)
                {
                    double j = 0;
                    this.tableau[4].Add(j);
                    this.tableau[3].Add(this.capitalEmprunte);
                    this.tableau[2].Add(j);
                    this.tableau[1].Add(j);
                    this.tableau[0].Add(j);

                }

                else
                {
                    this.tableau[0].Add(i);


                    double interetsMensuel = this.tableau[3][i - 1] * getTauxMensuel();
                    this.tableau[1].Add(interetsMensuel);

                    double amortissementMois = calculerMensualite() - this.tableau[1][i];
                    this.tableau[2].Add(amortissementMois);


                    double capitalRestantDu = this.tableau[3][i - 1] - this.tableau[2][i];
                    this.tableau[3].Add(capitalRestantDu);

                    this.tableau[4].Add(calculerMensualite());
                }

            }
        }


        // siaise mois à consulter

        public int consulterUnMois()
        {
            bool saisieOk = false;

            do
            {
                Console.WriteLine("Saisissez le numéro du mois à consulter : ");
                string? saisie = Console.ReadLine();

                saisieOk = int.TryParse(saisie, out this.moisAconsulter);


            } while (!saisieOk);


            return this.moisAconsulter;
        }





        // affichages ---------------------------------------------------------------------------------------------

        // afficher tableau
        public void afficherLeTableau()
        {
            int nblignes = this.tableau[0].Count;

            int nbcolonnes = this.tableau.Count;

            List<string> nomColonnes = new List<string>() { "Numéro mois", "Part intérêts", "Part Capital", "Capital dû", "Mensualité" };



            // table header 
            for (int i = 0; i < nbcolonnes; i++)
            {
                Console.Write(String.Format("  {0,14} ", "------------"));
            }
            Console.Write(" \n\r");
            for (int i = 0; i < nbcolonnes; i++)
            {
                Console.Write(String.Format("| {0,14} ", nomColonnes[i]));
            }
            Console.Write("| \n\r");
            for (int i = 0; i < nbcolonnes; i++)
            {
                Console.Write(String.Format("  {0,14} ", "------------"));
            }
            Console.Write(" \n\r");
            // table body


            for (int i = 0; i < nblignes; i++)
            {
                for (int j = 0; j < nbcolonnes; j++)
                {


                    Console.Write(String.Format("| {0,14} ", Math.Round(this.tableau[j][i], 2)));
                }
                Console.Write("| \n\r");
            }


            // table footer
            for (int i = 0; i < nbcolonnes; i++)
            {
                Console.Write(String.Format("  {0,14} ", "------------"));
            }
            Console.Write(" \n\r");



        }


        // afficher une ligne spécifique

        public void afficherUnmois()
        {

            int nblignes = this.moisAconsulter;

            int nbcolonnes = this.tableau.Count;

            List<string> nomColonnes = new List<string>() { "Numéro mois", "Part intérêts", "Part Capital", "Capital dû", "Mensualité" };



            // table header 
            for (int i = 0; i < nbcolonnes; i++)
            {
                Console.Write(String.Format("  {0,14} ", "------------"));
            }
            Console.Write(" \n\r");
            for (int i = 0; i < nbcolonnes; i++)
            {
                Console.Write(String.Format("| {0,14} ", nomColonnes[i]));
            }
            Console.Write("| \n\r");
            for (int i = 0; i < nbcolonnes; i++)
            {
                Console.Write(String.Format("  {0,14} ", "------------"));
            }
            Console.Write(" \n\r");
            // table body


            for (int i = nblignes; i < nblignes + 1; i++)
            {
                for (int j = 0; j < nbcolonnes; j++)
                {
                    Console.Write(String.Format("| {0,14} ", Math.Round(this.tableau[j][i], 2)));
                }
                Console.Write("| \n\r");
            }


            // table footer
            for (int i = 0; i < nbcolonnes; i++)
            {
                Console.Write(String.Format("  {0,14} ", "------------"));
            }
            Console.Write(" \n\r");
        }


        // afficher coût du crédit 

        public void affciherCoutCredit()
        {
            double totalInterets = 0;
            double fraisDeDossier = 50;

            for (int i = 1; i < this.mois + 1; i++)
            {
                totalInterets += this.tableau[1][i];
            }

            Console.WriteLine("\n\r --------------------------------------------" +
                                "\n\rLe total des intérêts est : " + Math.Round(totalInterets, 2) + "\n\r" +
                               "Les frais de dossier sont : " + fraisDeDossier + "\n\r" +
                               "Coût global du crédit : " + Math.Round( (this.capitalEmprunte + totalInterets + fraisDeDossier), 2) + "\n\r" +
                               "------------------------------------------- \n\r");
        }


        // interaction utlisateur ----------------------------------------------------------------------------------


        public void interagirAvecLeProgramme()
        {

            saisirInfos();

            construireTableau();

            remplirColonnesIndex_1_2_3();

            afficherLeTableau();

            affciherCoutCredit();

            string quit = "";

            do
            {
                consulterUnMois();
                afficherUnmois();

                Console.WriteLine("Appuyer sur Q pour quitter le programme \n\r" +
                                   "Ou sur une autre touche pour continuer.");
                quit = Console.ReadLine().ToLower();

            } while (quit != "q");





        }



    }

}
