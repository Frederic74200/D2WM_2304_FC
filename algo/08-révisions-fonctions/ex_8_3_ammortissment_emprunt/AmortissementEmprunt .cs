using System;
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


        // accesseurs ----------------------------------------------------------------------------------------------



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

        // construction tableau 

        public List<List<double>> construireTableau()
        {
            tableau.Add(new List<double>());
            tableau.Add(new List<double>());
            tableau.Add(new List<double>());
            tableau.Add(new List<double>());


            return this.tableau;
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

            double tauxInteretmensuel;
            double nbMoisNegatif;

            this.mois = this.nbrAnneeRbmt * 12;
            nbMoisNegatif = 0 - this.mois;
            tauxInteretmensuel = this.tauxInteretAnnuel / 12 / 100;

            mensualite = (this.capitalEmprunte * tauxInteretmensuel) / (1 - Math.Pow((1 + tauxInteretmensuel), nbMoisNegatif));

            return Math.Round(mensualite, 2);

        }







        // affichages ---------------------------------------------------------------------------------------------






    }
}
