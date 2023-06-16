using Bouteille_Said_Class;

namespace TestProjectBouteille
{
    [TestClass]
    public class UnitTest1
    {

        // test acceseurs ----------------------------------------------------------------------------------------
        [TestMethod]
        public void TestMethodGetBouteilleOuverte()
        {
            Bouteille bouteilleTest = new Bouteille(true, 1f, 0f, "test");
            bool ouvert = bouteilleTest.BouteilleOuverte;
            Assert.IsTrue(ouvert);
            Assert.IsFalse(!ouvert);
        }

        [TestMethod]
        public void TestMethodGetVolumeMaxEnLitres()
        {
            Bouteille bouteilleTest = new Bouteille(true, 1.33f, 0f, "test");
            float volumeMaxEnLitres = bouteilleTest.VolumeMaxEnLitres;
            Assert.IsTrue(volumeMaxEnLitres == 1.33f);
            Assert.IsFalse(volumeMaxEnLitres != 1.33f);
        }

        [TestMethod]
        public void TestMethodGetVolumeActuelEnLitres()
        {
            Bouteille bouteilleTest = new Bouteille(true, 1.33f, 0.88f, "test");
           float volActuelEnLitres = bouteilleTest.VolumeActuelEnLitres;
            Assert.IsTrue(volActuelEnLitres == 1.33f);
            Assert.IsFalse(volActuelEnLitres != 1.33f);
        }

        [TestMethod]
        public void TestMethodGetContenuBouteille()
        {
            Bouteille bouteilleTest = new Bouteille(true, 1.33f, 0.88f, "test");
          string contenuBouteille = bouteilleTest.ContenuBouteille;
            Assert.IsTrue(contenuBouteille == "test");
            Assert.IsFalse(contenuBouteille != "test");
        }

        // tests constructeurs -------------------------------------------------------------------------

        [TestMethod]
        public void TestMethod_Constructeur_parametres()
        {
            Bouteille bouteilleTest = new Bouteille(true, 1.33f, 0.88f, "test");
            bool ouverte = bouteilleTest.BouteilleOuverte;
            Assert.IsTrue(ouverte);

            float maxi = bouteilleTest.VolumeMaxEnLitres;
            Assert.IsTrue(maxi == 1.33f);

            float actuel = bouteilleTest.VolumeActuelEnLitres;
            Assert.IsTrue(actuel == 0.88f);

            string nomBtll = bouteilleTest.ContenuBouteille;
            Assert.IsTrue(nomBtll == "test");
        }



        [TestMethod]
        public void TestMethod_Constructeur_defaut()
        {
            Bouteille bouteilleTest = new Bouteille();
            bool ouverte = bouteilleTest.BouteilleOuverte;
            Assert.IsTrue(ouverte);

            float maxi = bouteilleTest.VolumeMaxEnLitres;
            Assert.IsTrue(maxi == 0.5f);

            float actuel = bouteilleTest.VolumeActuelEnLitres;
            Assert.IsTrue(actuel == 0.2f);

            string nomBtll = bouteilleTest.ContenuBouteille;
            Assert.IsTrue(nomBtll == "eau");
        }



        [TestMethod]
        public void TestMethod_Constructeur_a_cloner()
        {
            Bouteille bouteilleTest = new Bouteille();
            Bouteille clone = new Bouteille(bouteilleTest); 

            bool ouverte = clone.BouteilleOuverte;
            Assert.IsTrue(ouverte);

            float maxi = clone.VolumeMaxEnLitres;
            Assert.IsTrue(maxi == 0.5f);

            float actuel = clone.VolumeActuelEnLitres;
            Assert.IsTrue(actuel == 0.2f);

            string nomBtll = clone.ContenuBouteille;
            Assert.IsTrue(nomBtll == "eau");
        }



        // tests fonctions -----------------------------------------------------------------------------------------

        // ouvrir true
        [TestMethod]
        public void TestMethodOuvrirTrue()
        {
            Bouteille bouteilleTest = new Bouteille(false, 1.33f, 0.88f, "test");
            bool ouvrirOk = bouteilleTest.Ouvrir();
            bool estOuverte = bouteilleTest.BouteilleOuverte;
            Assert.IsTrue(ouvrirOk);   
            Assert.IsTrue(estOuverte);
        }

        // ouvrir false 
        [TestMethod]
        public void TestMethodOuvrirFalse()
        {
            Bouteille bouteilleTest = new Bouteille(true, 1.33f, 0.88f, "test");
            bool ouvrirOk = bouteilleTest.Ouvrir();
            bool estOuverte = bouteilleTest.BouteilleOuverte;
            Assert.IsFalse(ouvrirOk);
            Assert.IsFalse(estOuverte);
        }

        //--------------------------
        // Fermer true
        [TestMethod]
        public void TestMethodOFermerTrue()
        {
            Bouteille bouteilleTest = new Bouteille(true, 1.33f, 0.88f, "test");
            bool fermerOk = bouteilleTest.Fermer();
            bool estOuverte = bouteilleTest.BouteilleOuverte;
            Assert.IsTrue(fermerOk);
            Assert.IsTrue(!estOuverte);
        }

        // Fermer false 
        [TestMethod]
        public void TestMethodFermerrFalse()
        {
            Bouteille bouteilleTest = new Bouteille(false, 1.33f, 0.88f, "test");
            bool fermerOk = bouteilleTest.Fermer();
            bool estOuverte = bouteilleTest.BouteilleOuverte;

            Assert.IsFalse(fermerOk);
            Assert.IsFalse(estOuverte);

        }

        //-------------------------
        // Vider true
        [TestMethod]
        public void TestMethodOViderTrue()
        {
            Bouteille bouteilleTest = new Bouteille(true, 1.33f, 0.88f, "test");
            bool viderOk = bouteilleTest.Vider(0.33f);
            Assert.IsTrue(viderOk);
        }

        // vider false 
        [TestMethod]
        public void TestMethodViderFalse()
        {
            Bouteille bouteilleTest = new Bouteille(true, 1.33f, 0.88f, "test");
            bool viderOk = bouteilleTest.Vider(0.93f);
            Assert.IsFalse(viderOk);
        }

        //-------------------------
        // Remplir true
        [TestMethod]
        public void TestMethodORemplirTrue()
        {
            Bouteille bouteilleTest = new Bouteille(true, 1.33f, 0.88f, "test");
            bool remplirOK = bouteilleTest.Remplir(0.33f);
            Assert.IsTrue(remplirOK);
        }

        // remplir false 
        [TestMethod]
        public void TestMethodRemplirFalse()
        {
            Bouteille bouteilleTest = new Bouteille(true, 1.33f, 0.88f, "test");
            bool remplirOK = bouteilleTest.Remplir(0.93f);
            Assert.IsFalse(remplirOK);
        }

        //-------------------------
        // ViderTout true
        [TestMethod]
        public void TestMethodViderToutTrue()
        {
            Bouteille bouteilleTest = new Bouteille(true, 1.33f, 0.88f, "test");
            bool viderOk = bouteilleTest.ViderTout();
            Assert.IsTrue(viderOk);
        }

        // ViderTout false 
        [TestMethod]
        public void TestMethodViderToutFalse()
        {
            Bouteille bouteilleTest = new Bouteille(true, 1.33f, 0f, "test");
            bool viderOk = bouteilleTest.ViderTout();
            Assert.IsFalse(viderOk);
        }


        //-------------------------
        // RemplirTout true
        [TestMethod]
        public void TestMethodORemplirToutTrue()
        {
            Bouteille bouteilleTest = new Bouteille(true, 1.33f, 0.88f, "test");
            bool remplirOK = bouteilleTest.RemplirTout();
            Assert.IsTrue(remplirOK);
        }

        // RemplirTout false 
        [TestMethod]
        public void TestMethodRemplirToutFalse()
        {
            Bouteille bouteilleTest = new Bouteille(true, 1.33f, 1.33f, "test");
            bool remplirOK = bouteilleTest.RemplirTout();
            Assert.IsFalse(remplirOK);
        }





    }
}