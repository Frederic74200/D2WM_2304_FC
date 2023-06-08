namespace Bouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            BouteilleClass bouteilleVerreJusFruit = new BouteilleClass();
            BouteilleClass gourdeRandonnee = new BouteilleClass("Gourde pour la randonnée", false, 100,100);
            BouteilleClass flaconSavonMains = new BouteilleClass("Flacon de savon pour les mains", true, 50, 18);
            BouteilleClass nouvelleBouteilleJusFruit = new BouteilleClass(bouteilleVerreJusFruit);
            BouteilleClass nouvelleGourdeRando = new BouteilleClass(gourdeRandonnee);    

            Console.WriteLine("Nombres bouteilles instenciées : "+BouteilleClass.nombreBouteillesInstenciees);

            Console.WriteLine("--------------------------------- états initiaux  -----------------");
            bouteilleVerreJusFruit.AfficherEtatBouteille();
            gourdeRandonnee.AfficherEtatBouteille();
            flaconSavonMains.AfficherEtatBouteille();
            nouvelleBouteilleJusFruit.AfficherEtatBouteille();
            nouvelleGourdeRando.AfficherEtatBouteille();


            bouteilleVerreJusFruit.OuvrirLaBouteille();
            bouteilleVerreJusFruit.AjouterQuantiteChoisieLiquide(55);

            gourdeRandonnee.OuvrirLaBouteille();
            gourdeRandonnee.RetirerQuantiteChoisieLiquide(27);

            flaconSavonMains.RemplirTout();

            nouvelleBouteilleJusFruit.OuvrirLaBouteille();
            nouvelleBouteilleJusFruit.AjouterQuantiteChoisieLiquide(99);

            nouvelleGourdeRando.OuvrirLaBouteille();
            nouvelleGourdeRando.ViderTout();

            Console.WriteLine("--------------------------------- Nouveaux états  ------------------------------------");

            bouteilleVerreJusFruit.AfficherEtatBouteille();
            gourdeRandonnee.AfficherEtatBouteille();
            flaconSavonMains.AfficherEtatBouteille();
            nouvelleBouteilleJusFruit.AfficherEtatBouteille();
            nouvelleGourdeRando.AfficherEtatBouteille();


            bouteilleVerreJusFruit.ViderTout();
            bouteilleVerreJusFruit.FermerLaBouteille();

            nouvelleBouteilleJusFruit.RemplirTout();
            nouvelleBouteilleJusFruit.FermerLaBouteille();

            BouteilleClass troisiemeBouteilleJusFruit = new BouteilleClass(nouvelleBouteilleJusFruit);

            Console.WriteLine("--------------------------------- Nouveaux états  ------------------------------");
            bouteilleVerreJusFruit.AfficherEtatBouteille();
            nouvelleBouteilleJusFruit.AfficherEtatBouteille();
            troisiemeBouteilleJusFruit.AfficherEtatBouteille();



        }
    }
}