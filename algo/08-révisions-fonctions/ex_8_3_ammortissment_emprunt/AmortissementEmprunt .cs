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






        // constructeurs ------------------------------------------------------------------------------------------

        // par défaut
        public AmortissementEmprunt()
        {
            this.capitalEmprunte = 12000;
            this.nbrAnneeRbmt = 5;
            this.tauxInteretAnnuel = 0.06;
        }

        // avec paramètres
        public AmortissementEmprunt(int _capitalEmprunte, int _nbrAnneeRbmt, double _tauxInteretAnnuel)
        {
            this.capitalEmprunte = _capitalEmprunte;
            this.nbrAnneeRbmt = _nbrAnneeRbmt;
            this.tauxInteretAnnuel = _tauxInteretAnnuel;
        }


        // accesseurs ----------------------------------------------------------------------------------





        // petis calculs ----------------------------------------------------------------------------------------

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

            return Math.Round(mensualite, 2);

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

        // remplissage colonne mois 
        public void remplirColonneMois()
        {
            this.mois = this.nbrAnneeRbmt / 12;
            for (int i = 0; i < this.mois + 1; i++)
            {
                this.tableau[0].Add(i);
            }

        }

        // remplissage colonne mensualité
        public void remplirColonneMensualite()
        {

            for (int i = 0; i < getMois() + 1; i++)
            {
                if (i > 0)
                {
                    this.tableau[4].Add(calculerMensualite());
                }
                else
                {
                    this.tableau[4].Add(0);
                }
            }

        }

        // remplissage colonne part d'intêret 
        public void remplirColonnePartInterets()
        {

            for (int i = 0; i < getMois() ; i++)
            {
                if (i > 0)
                {

                    double interetsMensuel = this.tableau[3][i - 1] * i * getTauxMensuel();


                    this.tableau[1].Add(Math.Round(interetsMensuel, 1));
                }
                else
                {
                    this.tableau[1].Add(0);
                }
            }

        }

        // remplissage colonne part capital 
        public void remplirColonnePartCapital()
        {
            for (int i = 0; i < getMois() + 1; i++)
            {
                if (i > 0)
                {
                    double amortissementMois = calculerMensualite() - this.tableau[1][i];

                    this.tableau[2].Add(Math.Round(amortissementMois, 1));
                }
                else
                {
                    this.tableau[2].Add(0);
                }
            }

        }

        // remplissage colonne capital restant dû 
        public void remplirColonneCapitalrestantDu()
        {
            this.tableau[3].Add(Convert.ToDouble(this.capitalEmprunte));

            for (int i = 1; i < getMois() + 1; i++)
            {


                double capitalRestantDu = this.tableau[3][i - 1] - this.tableau[2][i];


                this.tableau[3].Add(Math.Round(capitalRestantDu, 0));

            }

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
                    this.tableau[3].Add(Convert.ToDouble(this.capitalEmprunte));
                    this.tableau[2].Add(j);
                    this.tableau[1].Add(j);
                    this.tableau[0].Add(j);

                }
                else
                {




                    this.tableau[0].Add(i);

                    double interetsMensuel = this.tableau[3][i - 1] * i * getTauxMensuel();
                    this.tableau[1].Add(Math.Round(interetsMensuel, 1));

                    double amortissementMois = calculerMensualite() - this.tableau[1][i];
                    this.tableau[2].Add(Math.Round(amortissementMois, 1));


                    double capitalRestantDu = this.tableau[3][i - 1] - this.tableau[2][i];
                    this.tableau[3].Add(Math.Round(capitalRestantDu, 0));

                    this.tableau[4].Add(calculerMensualite());
                }
 
            }






        }



        // affichages ---------------------------------------------------------------------------------------------

        // afficher tableau
        public void afficherLeTableau()
        {
            int nblignes =this.tableau[0].Count;

            int nbcolonnes = this.tableau.Count;

            List<string> nomColonnes = new List<string>(){ "Numéro mois", "Part intérêts", "Part Capital", "Capital dû", "Mensualité" };



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


                    Console.Write(String.Format("| {0,14} ", this.tableau[j][i]));
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


    }

}
