namespace ClassLibraryVoiture
{
    public class Roue
    {


        // Attributs ------------------------------------------------------------------------
        private string dimensionPneu;

        private bool tourne;

        // get set ----------------------------------------------------------------------------
        public bool Tourne { get => tourne; set => tourne = value; }



        // Constructeurs ------------------------------------------------------------------

        public Roue(bool _tourne)
        {
            this.tourne = _tourne;
        }

        public Roue():this(false) { }

        public Roue(Roue roueAcopier) :this(roueAcopier.Tourne) { } 



        // Fonctions ------------------------------------------------------------------------

        // Tourner
        public bool Tourner()
        {
            if(!tourne)
            {
                tourne = true;
                return true;
            }
            else
            {
                return false;
            }
        }


        // stopper
        public bool Stopper()
        {
            if (tourne)
            {
                tourne = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        // roue to string 
         public string roueToString()
        {
            string roueToString = "Roue tourne ? " + Tourne+"\n\r";
            return roueToString;
        }



    }
}