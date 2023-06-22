using ClassLibraryPoint;
using System.Security.Cryptography.X509Certificates;

namespace TestProjectPoint
{
    [TestClass]
    public class UnitTest1
    {
        // tests construceurs  ***************************************************************************************************
        // test construteur avec param�tres 
        [TestMethod]
        public void TestConstructeurAvecParametres()
        {
            Point p = new Point(4, -2);

           double x = p.AbscisseX;
            double y = p.OrdonneeY;

            Assert.IsTrue(x == 4);
            Assert.IsTrue(y == -2 );
        }


        // test construceur par d�faut 
        [TestMethod]
        public void TestConstructeurParDefaut()
        {
            Point p = new Point();

            double x = p.AbscisseX;
            double y = p.OrdonneeY;

            Assert.IsTrue(x == 0);
            Assert.IsTrue(y == 0);
        }

        // test constructeur � copier 

        [TestMethod]
        public void TestConstructeurAcopier()
        {
            Point p = new Point(31.23, 12.44);
           Point p1 = new Point(p);

            double x = p.AbscisseX;
            double y = p.OrdonneeY;

            Assert.IsTrue(x == 31.23);
            Assert.IsTrue(y == 12.44);
        }


        // tests set  ***************************************************************************************************

        // test set absysseX // test set ordonneY 

        [TestMethod]
        public void TestSetXetY()
        {
            Point p = new Point();

             p.AbscisseX = -14.3;
             p.OrdonneeY =123.4;

            double x = p.AbscisseX ;
            double y = p.OrdonneeY ;

            Assert.IsTrue(x == -14.3);
            Assert.IsTrue(y == 123.4);
        }



        // tests fonctions  ***************************************************************************************************
        
        
        // test se d�placer  -----------------------------------    
        [TestMethod]
        public void TestSeDeplacer()
        {
            Point p = new Point();

            p.SeDeplacer(-14.3, 123.4);                    

            double x = p.AbscisseX;
            double y = p.OrdonneeY;

            Assert.IsTrue(x == -14.3);
            Assert.IsTrue(y == 123.4);
        }


        // test ConstruirePointSymetriqueOrdonnee --------------------

        // nombre positif 
        [TestMethod]
        public void TestConstruirePointSymetriqueOrdonneerYpositif()
        {
            Point p = new Point(31.23, 12.44);

            p.ConstruirePointSymetriqueOrdonnee();

            double y = p.OrdonneeY;

            Assert.IsTrue(y == -12.44);
        }

        // nombre n�gatif 
        [TestMethod]
        public void TestConstruirePointSymetriqueOrdonneerYnegaatif()
        {
            Point p = new Point(31.23, -12.44);

            p.ConstruirePointSymetriqueOrdonnee();

            double y = p.OrdonneeY;

            Assert.IsTrue(y == 12.44);
        }

        // nombre z�ro 
        [TestMethod]
        public void TestConstruirePointSymetriqueOrdonneerYvautZero()
        {
            Point p = new Point(31.23, 0);

            p.ConstruirePointSymetriqueOrdonnee();

            double y = p.OrdonneeY;

            Assert.IsTrue(y == 0);
        }


        // test ConstruirePointSymetriqueAbscisse -------------------

        // nombre positif 
        [TestMethod]
        public void TestConstruirePointSymetriqueAbscisseXpositif()
        {
            Point p = new Point(31.23, -12.44);

            p.ConstruirePointSymetriqueAbscisse();

            double x = p.AbscisseX;        

            Assert.IsTrue(x == -31.23);           
        }

        // nombre n�gatif 
        [TestMethod]
        public void TestConstruirePointSymetriqueAbscisseXnegaatif()
        {
            Point p = new Point(-31.23, -12.44);

            p.ConstruirePointSymetriqueAbscisse();

            double x = p.AbscisseX;           

            Assert.IsTrue(x == 31.23);           
        }

        // nombre z�ro 
        [TestMethod]
        public void TestConstruirePointSymetriqueAbscisseXvautZero()
        {
            Point p = new Point(0, 0.2);

            p.ConstruirePointSymetriqueAbscisse();

            double x = p.AbscisseX;          

            Assert.IsTrue(x == 0);          
        }

        // test ConstruirePointSymetriqueOrigine -------------------

        [TestMethod]
        public void TestConstruirePointSymetriqueOrigine()
        {
            Point p = new Point(23,12);

            p.ConstruirePointSymetriqueOrigine();

            double x = p.AbscisseX;
            double y = p.OrdonneeY;

            Assert.IsTrue(x == -23);
            Assert.IsTrue(y == -12);
        }

        // PermuterCoordonnes  ----------------------

        [TestMethod]
        public void TestCPermuterCoordonnes()
        {
            Point p = new Point(-23, 12);

            p.PermuterCoordonnes(); 

            double x = p.AbscisseX;
            double y = p.OrdonneeY;

            Assert.IsTrue(x == 12);
            Assert.IsTrue(y == -23);
        }

    }
}