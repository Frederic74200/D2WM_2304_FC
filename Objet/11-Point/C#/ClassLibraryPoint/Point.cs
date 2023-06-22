namespace ClassLibraryPoint
{
    public class Point
    {

        // attributs -------------------------------------------------------------------------

        private double abscisseX;
        private double ordonneeY;

        public double AbscisseX { get => abscisseX; set => abscisseX = value; }
        public double OrdonneeY { get => ordonneeY; set => ordonneeY = value; }


        // get set -----------------------------------------------------------------------



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

        public void ConstruirePointSymetriqueOrdonnee()
        {
            ordonneeY -= 2 * ordonneeY; 
        }

        public void ConstruirePointSymetriqueAbscisse()
        {
           abscisseX -= 2 * abscisseX;
        }

        public void ConstruirePointSymetriqueOrigine()
        {
            ConstruirePointSymetriqueAbscisse();
            ConstruirePointSymetriqueOrdonnee();
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