using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture
{
    internal class Voiture
    {

        // Attributs -----------------------------------------------------------------------------
        private string modeleVoiture;
        private List<Roue> roueslist; 
        private Moteur moteurList;



        // accesseurs mutaeurs -------------------------------------------------------------------
        public string ModeleVoiture { get => modeleVoiture; set => modeleVoiture = value; }
        internal List<Roue> Roueslist { get => roueslist; set => roueslist = value; }
        internal Moteur MoteurList { get => moteurList; set => moteurList = value; }




        // Connstructeurs ------------------------------------------------------------------------
        // Avec paramètres 


        // Par défaut


        // Clonage 




        // Fonctions -------------------------------------------------------------------------------






    }
}
