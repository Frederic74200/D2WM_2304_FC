using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcedureFonction
{
    internal class ProcedureFonction
    {

        // attributs  ------------------
        double nb1;
        double nb2;
        string prenom;



        // constructeurs -------------------

        // par défaut 
        public ProcedureFonction()
        {
            this.nb1 = 0.01;
           this.nb2 = 0.0001;
           this.prenom = "Fred";
        }

        // avec paramètres 

        public ProcedureFonction(double _nb1, double _nb2, string _prenom)
        {
            this.nb1 = _nb1;    
            this.nb2 = _nb2;
            this.prenom = _prenom;
        }



        // fonctions ---------------------------


        public double AdditionnerDeuxNombresReels()

        {
            double somme = nb1 + nb2;

            return somme;
        }

        public void AfficherBonjourEtPrenom()
        {
            Console.WriteLine("Bonjour "+this.prenom);
        }


    }
}
