using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture
{
    internal class Moteur
    {
        // Attributs -----------------------------------------------------------------------------

        private int puissanceEnCV;
        private bool estEnFonction;
        private static int nombreMoteursInstanciees;


        // accesseurs mutaeurs -------------------------------------------------------------------

        public int PuissanceEnCV { get => puissanceEnCV; set => puissanceEnCV = value; }
        public bool EstEnFonction { get => estEnFonction; set => estEnFonction = value; }
        public static int NombreMoteursInstanciees { get => nombreMoteursInstanciees; set => nombreMoteursInstanciees = value; }


        // Connstructeurs ------------------------------------------------------------------------

        // Avec paramètres 
        public Moteur (int _puissanceEnCV, bool _estEnFonction)
        {
            this.puissanceEnCV = _puissanceEnCV;
            this.estEnFonction = _estEnFonction;
            nombreMoteursInstanciees++;
        }

        // Par défaut
        public Moteur()
            : this(5, false)
        {

        }

        // Clonage 
        public Moteur (Moteur MoteurAdupliquer)
           : this(MoteurAdupliquer.puissanceEnCV, MoteurAdupliquer.estEnFonction)
        {

        }


        // Fonctions -------------------------------------------------------------------------------


















    }
}
