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

        // tests fonctions -----------------------------------------------------------------------------------------

        // ouvrir true
        [TestMethod]
        public void TestMethodOuvrirTrue()
        {
            Bouteille bouteilleTest = new Bouteille(false, 1.33f, 0.88f, "test");
            bool ouvrirOk = bouteilleTest.Ouvrir();
            Assert.IsTrue(ouvrirOk);           
        }

        // ouvrir false 
        [TestMethod]
        public void TestMethodOuvrirFalse()
        {
            Bouteille bouteilleTest = new Bouteille(true, 1.33f, 0.88f, "test");
            bool ouvrirOk = bouteilleTest.Ouvrir();
            Assert.IsFalse(ouvrirOk);
        }

        //--------------------------
        // Fermer true
        [TestMethod]
        public void TestMethodOFermerTrue()
        {
            Bouteille bouteilleTest = new Bouteille(true, 1.33f, 0.88f, "test");
            bool fermerOk = bouteilleTest.Fermer();
            Assert.IsTrue(fermerOk);
        }

        // Fermer false 
        [TestMethod]
        public void TestMethodFermerrFalse()
        {
            Bouteille bouteilleTest = new Bouteille(false, 1.33f, 0.88f, "test");
            bool fermerOk = bouteilleTest.Fermer();
            Assert.IsFalse(fermerOk);
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

        /-------------------------
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