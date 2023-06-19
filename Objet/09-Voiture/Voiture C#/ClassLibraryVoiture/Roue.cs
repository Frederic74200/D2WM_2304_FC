using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture
{
    internal class Roue
    {

        // Attributs -----------------------------------------------------------------------------
        private int diametreEnPouce;
        private double pressionEnBar;
        private static int nombreRouesInstenciees;


        // accesseurs mutaeurs -------------------------------------------------------------------

        public int DiametreEnPouce { get => diametreEnPouce; set => diametreEnPouce = value; }
        public double PressionEnBar { get => pressionEnBar; set => pressionEnBar = value; }
        public static int NombreRouesInstenciees { get => nombreRouesInstenciees; set => nombreRouesInstenciees = value; }



        // Connstructeurs ------------------------------------------------------------------------

        // Avec paramètres 
        public Roue (int _diametreEnPouce, double _pressionEnBar)
        {
            this.diametreEnPouce = _diametreEnPouce;    
            this.pressionEnBar = _pressionEnBar;
            nombreRouesInstenciees++; 
        }

        // Par défaut
        public Roue()
            : this(17, 1.9)
        {

        }

        // Clonage 
        public Roue(Roue RoueAdupliquer)
            : this(RoueAdupliquer.diametreEnPouce, RoueAdupliquer.pressionEnBar)
        {

        }


        // Fonctions -------------------------------------------------------------------------------






    }
}
