
using Bouteille;

namespace TestProjectBouteille
{
    [TestClass]
    public class UnitTest1
    {


        // tests get 
        [TestMethod]
        public void TestMethod_GetNomBouteille()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", false, 100, 50);
            string nomBouteille = testBouteille.NomBouteille;
            Assert.IsTrue(nomBouteille == "Bouteille de test");
            Assert.IsFalse(nomBouteille != "Bouteille de test");
        }

        [TestMethod]
        public void TestMethod_GetEstOverte()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", true, 100, 50);
            bool ouverte = testBouteille.EstOuverte;
            Assert.IsTrue(ouverte);
            Assert.IsFalse(!ouverte);
        }

        [TestMethod]
        public void TestMethod_GetapaciteMaxiCentilitres()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", true, 100, 50);
            uint capacite = testBouteille.CapaciteMaxiCentilitres;
            Assert.IsTrue(capacite == 100);
            Assert.IsFalse(capacite != 100);
        }


        [TestMethod]
        public void TestMethod_GetQantiteLiquidePresentCl()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", true, 100, 50);
            uint quantite = testBouteille.QantiteLiquidePresentCl;
            Assert.IsTrue(quantite == 50);
            Assert.IsFalse(quantite != 50);
        }

        [TestMethod]
        public void TestMethod_GetNombreBouteillesInstenciees()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", true, 100, 50);
            uint nbBouteilles = testBouteille.GetNombreBouteillesInstenciees();
            Assert.IsTrue(nbBouteilles == 1);
            Assert.IsFalse(nbBouteilles != 1);
        }





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

            bool retirerLiquide = testBouteille.RetirerQuantiteChoisieLiquide(25);
            Assert.IsTrue(retirerLiquide);
        }

        [TestMethod]
        public void TestMethod_AjouterQuantiteChoisieLiquide()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", true, 100, 50);

           bool ajouterLiquide = testBouteille.AjouterQuantiteChoisieLiquide(25);
            Assert.IsTrue(ajouterLiquide);
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
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", true, 100, 50);

            bool ouvert = testBouteille.OuvrirLaBouteille();
            Assert.IsFalse(ouvert);
        }

        [TestMethod]
        public void TestMethod_Faux_FermerLaBouteille()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", false, 100, 50);

            bool ferme = testBouteille.FermerLaBouteille();
            Assert.IsFalse(ferme);
        }


        [TestMethod]
        public void TestMethod_Faux_RetirerQuantiteChoisieLiquide()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", true, 100, 50);

            bool retirerLiquide  = testBouteille.RetirerQuantiteChoisieLiquide(25);
            Assert.IsFalse(!retirerLiquide);
        }

        [TestMethod]
        public void TestMethod_Faux_AjouterQuantiteChoisieLiquide()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", true, 100, 50);

           bool ajouterLiquide= testBouteille.AjouterQuantiteChoisieLiquide(75);
            Assert.IsFalse(ajouterLiquide);
        }

        [TestMethod]
        public void TestMethod_Faux_ViderTout()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", true, 100, 0);

            bool toutVider = testBouteille.ViderTout();
            Assert.IsFalse(toutVider);
        }

        [TestMethod]
        public void TestMethod_Faux_RemplirTout()
        {
            Bouteille.BouteilleClass testBouteille = new Bouteille.BouteilleClass("Bouteille de test", true, 100, 100);

            bool toutRemplir = testBouteille.ViderTout();
            Assert.IsFalse(!toutRemplir);
        }


    }
}