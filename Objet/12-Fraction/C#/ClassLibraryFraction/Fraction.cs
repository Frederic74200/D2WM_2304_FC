namespace ClassLibraryFraction
{
    public class Fraction
    {
        // Attributs ----------------------------------------------------------------------------
        private int numerator;
        private int denominator;

        // Get set -------------------------------------------------------------------------------

        public int Numerator { get => numerator; set => numerator = value; }
        public int Denominator { get => denominator; set => denominator = value; }

        // Constructeurs ---------------------------------------------------------------------------
        public Fraction(int _numerator, int _denominator)
        {
           this.numerator = _numerator; 
           this.denominator = _denominator;
        }

        public Fraction() :this(0,1) { }

       public Fraction(int _numerator) : this(_numerator, 1)
        {
            
        }



        // Fonctions -------------------------------------------------------------------------------

        // fraction to string 

        public override string ToString()
        {
            return numerator.ToString() + denominator.ToString();
        }


        public string FractionToString() { 
            
            string fractionToString = numerator.ToString() + denominator.ToString();

            return fractionToString;

        } 
    }
}