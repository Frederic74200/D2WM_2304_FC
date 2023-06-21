using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVoiture
{
    public class Moteur
    {
        // Attributs -----------------------------------------------------------
        private bool enMarche;

        // get set-----------------------------------------------------------------
        public bool EnMarche { get => enMarche; set => enMarche = value; }


        // Constructeurs -------------------------------------------------------------------
        public Moteur(bool _enMarche)
        {
            this.enMarche = _enMarche;
        }

        public Moteur() : this(false) { }

        public Moteur(Moteur moteurAcopier) : this(moteurAcopier.EnMarche) { }


        // Fonctions ---------------------------------------------------------------------

        // Demmarer
        public bool Demarrer()
        {
            if (!enMarche)
            {
                enMarche = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        // Entrainer roue
        public bool EntrainerRoues(Roue roue2, Roue roue1)
        {
            if (enMarche && roue2.Tourner() == true &&  roue1.Tourner() == true)
            {

                roue2.Tourner();
                roue1.Tourner(); 
                return true;
            }
            else
            {
                return false;
            }
        }

        // Arreter roues 
        public bool ArreterRoues(Roue roue1, Roue roue2)
        {
            if (enMarche && roue1.Stopper() == true && roue2.Stopper() == true)            
            {
                roue1.Stopper();
                roue2.Stopper();

                return true;
            }
            else
            {
                return false;
            }
        }

        // eteindre 
        public bool Eteindre()
        {
            if (enMarche)
            {
                enMarche = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        // moteur to string 

        public string moteurToString()
        {
            string moteurToString = "moteur enMarche ? " + enMarche + "\n\r";
            return moteurToString;
        }


    }
}
