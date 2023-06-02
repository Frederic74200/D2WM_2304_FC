﻿namespace Bouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            BouteilleClass bouteilleVerreJusFruit = new BouteilleClass();
            BouteilleClass gourdeRandonnee = new BouteilleClass("Gourde pour la randonnée", false, 100,100);
            BouteilleClass flaconSavonMains = new BouteilleClass("Flacon de savon pour les mains", true, 50, 18);


            bouteilleVerreJusFruit.AfficherEtatBouteille();
            gourdeRandonnee.AfficherEtatBouteille();
            flaconSavonMains.AfficherEtatBouteille();


            bouteilleVerreJusFruit.OuvrirLaBouteille();
            bouteilleVerreJusFruit.AjouterQuantiteChoisieLiquide(55);

            gourdeRandonnee.OuvrirLaBouteille();
            gourdeRandonnee.RetirerQuantiteChoisieLiquide(27);

            flaconSavonMains.RemplirTout();

            Console.WriteLine("--------------------------------- Nouveaux états  -----------------");

            bouteilleVerreJusFruit.AfficherEtatBouteille();
            gourdeRandonnee.AfficherEtatBouteille();
            flaconSavonMains.AfficherEtatBouteille();


            bouteilleVerreJusFruit.ViderTout();
            bouteilleVerreJusFruit.FermerLaBouteille();

            Console.WriteLine("--------------------------------- Nouveaux états  -----------------");
            bouteilleVerreJusFruit.AfficherEtatBouteille();







        }
    }
}