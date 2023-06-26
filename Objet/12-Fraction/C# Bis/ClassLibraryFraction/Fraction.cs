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

        public Fraction() : this(0, 1) { }

        public Fraction(int _numerator) : this(_numerator, 1)
        {

        }

        public Fraction(Fraction fractionAcopier) : this(fractionAcopier.numerator, fractionAcopier.denominator) { }

        // Fonctions -------------------------------------------------------------------------------

        // fraction to string        

        public override string ToString()
        {
            return numerator + " / " + denominator;
        }


        public void Oppose()
        {
            numerator -= 2 * numerator;
        }


        public void Inverse()
        {
            int tmp = numerator;
            numerator = denominator;
            denominator = tmp;
        }

        public bool SuperieurA(Fraction _fraction)
        {
            double calcul1 = numerator / denominator;
            double calcul2 = _fraction.numerator / _fraction.denominator;

            if (calcul1 > calcul2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EgalA(Fraction _fraction)
        {
            double calcul1 = numerator / denominator;
            double calcul2 = _fraction.numerator / _fraction.denominator;

            if (calcul1 == calcul2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public int GetPgcd()
        {
            int a = this.numerator;
            int b = this.denominator;
            int pgcd = 1;
            if (a != 0 && b != 0)
            {
                if (a < 0) a = -a;
                if (b < 0) b = -b;
                while (a != b)
                {
                    if (a < b)
                    {
                        b = b - a;
                    }
                    else
                    {
                        a = a - b;
                    }
                }
                pgcd = a;
            }
            return pgcd;
        }



        public void Reduire()
        {
            int pgdc = GetPgcd();
            numerator = numerator / pgdc;
            denominator = denominator / pgdc;

            if (numerator < 0 && denominator < 0)
            {
                numerator -= 2 * numerator;
                denominator -= 2 * denominator;
            }

            if (numerator > 0 && denominator < 0)
            {
                numerator -= 2 * numerator;
                denominator -= 2 * denominator;
            }

        }




        public Fraction Plus(Fraction _fraction)
        {
            int  numFract1 = numerator * _fraction.Denominator;
            int numFract2 = denominator * _fraction.Numerator;    

            int denCommun = denominator * _fraction.Denominator;

            int plusNum = numFract1 + numFract2;    


            Fraction plus = new Fraction(plusNum, denCommun);   

            plus.Reduire();

            return plus;
        }


        public Fraction Moins(Fraction _fraction)
        {
            int numFract1 = numerator * _fraction.Denominator;
            int numFract2 = denominator * _fraction.Numerator;

            int denCommun = denominator * _fraction.Denominator;

            int moinsNum = numFract1 - numFract2;


            Fraction moins = new Fraction(moinsNum, denCommun);

            moins.Reduire();

            return moins;
        }


        public Fraction Multiplie(Fraction _fraction)
        {
            int numCommun = numerator *  _fraction.Numerator;

            int denCommun = denominator * _fraction.Denominator;           


            Fraction Multiplie = new Fraction(numCommun, denCommun);

            Multiplie.Reduire();

            return Multiplie;
        }



        public Fraction Divise(Fraction _fraction)
        {
            _fraction.Inverse();

            Fraction Divise = Multiplie(_fraction);

            Divise.Reduire();

            return Divise;
        }



    }
}