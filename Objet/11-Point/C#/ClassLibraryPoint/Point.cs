namespace ClassLibraryPoint
{
    public class Point
    {

        // attributs -------------------------------------------------------------------------

        private double abscisseX;
        private double ordonneeY;


        // get set -----------------------------------------------------------------------

        public double AbscisseX { get => abscisseX; set => abscisseX = value; }
        public double OrdonneeY { get => ordonneeY; set => ordonneeY = value; }



        // constructeurs -------------------------------------------------------------------
        public Point(double _abscisseX, double _ordonneeY )
        {
            this.abscisseX = _abscisseX;
            this.ordonneeY = _ordonneeY;

        }

        public Point() :this(0,0){ }

        public Point(Point pointAcopier) :this(pointAcopier.AbscisseX, pointAcopier.OrdonneeY) { }
       
        // fonctions -----------------------------------------------------------------------
        public void SeDeplacer(double nouveauX, double nouveauY)
        {
           this.abscisseX = nouveauX;
            this.ordonneeY= nouveauY;
        }

        public override string ToString()
        {
            return "Position x : "+abscisseX+" Position Y : "+ordonneeY+"]";
        }

    
       public Point ConstruirePointSymetriqueOrdonnee()
        {       

           double nouveauX = abscisseX;
           double nouveauY = ordonneeY - 2 * ordonneeY;

            Point _point = new Point(nouveauX, nouveauY);
            return _point;
        }

        public Point ConstruirePointSymetriqueAbscisse()
        {
            double nouveauX = abscisseX - 2 * abscisseX; 
            double nouveauY = ordonneeY ;

            Point _point = new Point(nouveauX, nouveauY);

            return _point;
        }

        public Point ConstruirePointSymetriqueOrigine()
        {
            Point Xpoint = ConstruirePointSymetriqueAbscisse();
            Point Ypoint = ConstruirePointSymetriqueOrdonnee();

            double nouveauX = Xpoint.AbscisseX;
            double nouveauY = Ypoint.OrdonneeY;

            Point _point = new Point(nouveauX, nouveauY);

            return _point;

        }

        public void PermuterCoordonnes()
        {
            double tmp;

            tmp = abscisseX;
            abscisseX = ordonneeY;
            ordonneeY = tmp;    
        }
    }
}