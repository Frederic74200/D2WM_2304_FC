
using Bouteille;

namespace TestProjectBouteille
{
    [TestClass]
    public class UnitTest1
    {

        // Tests Vrais -----------------------------------------
        [TestMethod]
        public void TestMethod_OuvrirLaBouteille()
        {
            Bouteille.BouteilleClass testBouteille =new Bouteille.BouteilleClass("Bouteille de test", false, 100, 50);

            bool ouvert = testBouteille.OuvrirLaBouteille();
            Assert.IsTrue(ouvert);
        }

        [TestMethod]
        public void TestMethod_FermerLaBouteille()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", true, 100, 50);

            bool ferme = testBouteille.FermerLaBouteille();
            Assert.IsTrue(ferme);
        }


        [TestMethod]
        public void TestMethod_RetirerQuantiteChoisieLiquide()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", true, 100, 50);

            uint quantiteRestante = testBouteille.RetirerQuantiteChoisieLiquide(25);
            Assert.IsTrue(quantiteRestante == 25);
        }

        [TestMethod]
        public void TestMethod_AjouterQuantiteChoisieLiquide()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", true, 100, 50);

            uint quantiteRestante = testBouteille.AjouterQuantiteChoisieLiquide(25);
            Assert.IsTrue(quantiteRestante == 75);
        }

        [TestMethod]
        public void TestMethod_ViderTout()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", true, 100, 50);

            bool toutVider = testBouteille.ViderTout();
            Assert.IsTrue(toutVider);
        }

        [TestMethod]
        public void TestMethod_RemplirTout()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", true, 100, 50);

            bool toutRemplir = testBouteille.ViderTout();
            Assert.IsTrue(toutRemplir);
        }

        // Tests faux -----------------------------------------

        [TestMethod]
        public void TestMethod_Faux_OuvrirLaBouteille()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", false, 100, 50);

            bool ouvert = testBouteille.OuvrirLaBouteille();
            Assert.IsFalse(!ouvert);
        }

        [TestMethod]
        public void TestMethod_Faux_FermerLaBouteille()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", true, 100, 50);

            bool ferme = testBouteille.FermerLaBouteille();
            Assert.IsFalse(!ferme);
        }


        [TestMethod]
        public void TestMethod_Faux_RetirerQuantiteChoisieLiquide()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", true, 100, 50);

            uint quantiteRestante = testBouteille.RetirerQuantiteChoisieLiquide(25);
            Assert.IsFalse(quantiteRestante != 25);
        }

        [TestMethod]
        public void TestMethod_Faux_AjouterQuantiteChoisieLiquide()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", true, 100, 50);

            uint quantiteRestante = testBouteille.AjouterQuantiteChoisieLiquide(25);
            Assert.IsFalse(quantiteRestante != 75);
        }

        [TestMethod]
        public void TestMethod_Faux_ViderTout()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", true, 100, 50);

            bool toutVider = testBouteille.ViderTout();
            Assert.IsFalse(!toutVider);
        }

        [TestMethod]
        public void TestMethod_Faux_RemplirTout()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", true, 100, 50);

            bool toutRemplir = testBouteille.ViderTout();
            Assert.IsFalse(!toutRemplir);
        }









    }
}