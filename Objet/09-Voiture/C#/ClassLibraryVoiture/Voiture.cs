using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibraryVoiture
{
    public class Voiture
    {
        // Attributs --------------------------------------------------------------------------------

        private string marque;
        private Moteur moteur;
        private List<Roue> roues;

        public string Marque { get => marque; set => marque = value; }


        // Constructeurs ---------------------------------------------------------------------------
        public Voiture(Moteur _moteur, List<Roue> _roues, string _marque)
        {
            moteur = _moteur;
            roues = _roues; 
            marque = _marque;
        }



        public Voiture(Voiture voitureAcopier)
            : this(new Moteur(voitureAcopier.moteur),
                 new List<Roue>(){new Roue(voitureAcopier.roues[0]),
                                new Roue(voitureAcopier.roues[1]),
                                new Roue(voitureAcopier.roues[2]),
                                new Roue(voitureAcopier.roues[3])},
                 voitureAcopier.marque)
        {

        }

        public Voiture()
           : this(new Moteur(), new List<Roue> { new Roue(), new Roue(), new Roue(), new Roue() }, "Peugeot")
        {

        }

        // Fonctions --------------------------------------------------------------------------------

        // Démarre 
        public bool DemarrerLeMoteur()
        {

            if (moteur.Demarrer() == true) { return true; }
            else { return false; }

        }

        // Avancer
        public bool Avancer()
        {

            if ( moteur.EntrainerRoues(roues[0], roues[1]) == true)
            {
                moteur.EntrainerRoues(roues[0], roues[1]);
                roues[2].Tourner();
                roues[3].Tourner();

                return true;
            }
            else { return false; }

        }

        // Freiner 

        /*/
        public bool Freiner()
        {
            if (roues[0].Tourne == true || roues[1].Tourne == true || roues[2].Tourne == true || roues[3].Tourne == true)
            {
                for (int i = 0; i < roues.Count; i++) { roues[i].Stopper(); }
                return true;
            }
            else { return false; }

        }
        */
        public bool Freiner()
        {

            if (moteur.ArreterRoues(roues[0], roues[1]) == true)
            {
                moteur.ArreterRoues(roues[0], roues[1]);
                roues[2].Stopper();
                roues[3].Stopper();

                return true;
            }
            else { return false; }

        }




        // voiture to string 

        public string voitureToString()
        {
            string voitureToString = "-----------------------------------------------\n\r" +
                                    "Marque Voiture : " + marque + "\n\r" +
                                    moteur.moteurToString() +
                                    roues[0].roueToString() +
                                     roues[1].roueToString() +
                                     roues[2].roueToString() +
                                      roues[3].roueToString() +
                                     "-----------------------------------------------\n\r";
            return voitureToString;
        }


    }
}
