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
        private Moteur sonMoteur;
        private List<Roue> ses4roues;

        public string Marque { get => marque; set => marque = value; }


        // Constructeurs ---------------------------------------------------------------------------
        private Voiture(Moteur _moteur, List<Roue> _roues, string _marque)
        {
            sonMoteur = _moteur;
            ses4roues = _roues; 
            marque = _marque;
        }


        public Voiture(Moteur _moteur,bool tourne, string _marque)
           : this(new Moteur(),
                new List<Roue>(){new Roue(tourne),
                               new Roue(tourne),
                               new Roue(tourne),
                               new Roue(tourne)},
              _marque)
        {



        }
        public Voiture(Voiture voitureAcopier)
            : this(new Moteur(voitureAcopier.sonMoteur),
                 new List<Roue>(){new Roue(voitureAcopier.ses4roues[0]),
                                new Roue(voitureAcopier.ses4roues[1]),
                                new Roue(voitureAcopier.ses4roues[2]),
                                new Roue(voitureAcopier.ses4roues[3])},
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

            if (sonMoteur.Demarrer() == true) { return true; }
            else { return false; }

        }

        // Avancer
        public bool Avancer()
        {

            if (sonMoteur.EntrainerRoues(ses4roues[0], ses4roues[1]) == true)
            {
                sonMoteur.EntrainerRoues(ses4roues[0], ses4roues[1]);
                ses4roues[2].Tourner();
                ses4roues[3].Tourner();

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

            if (sonMoteur.ArreterRoues(ses4roues[0], ses4roues[1]) == true)
            {
                sonMoteur.ArreterRoues(ses4roues[0], ses4roues[1]);
                ses4roues[2].Stopper();
                ses4roues[3].Stopper();

                return true;
            }
            else { return false; }

        }




        // voiture to string 

        public string voitureToString()
        {
            string voitureToString = "-----------------------------------------------\n\r" +
                                    "Marque Voiture : " + marque + "\n\r" +
                                    sonMoteur.moteurToString() +
                                    ses4roues[0].roueToString() +
                                     ses4roues[1].roueToString() +
                                     ses4roues[2].roueToString() +
                                      ses4roues[3].roueToString() +
                                     "-----------------------------------------------\n\r";
            return voitureToString;
        }


    }
}
