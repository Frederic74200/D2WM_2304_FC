using Bouteille_Said_Class;

namespace ConsoleAppBouteille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bouteille bouteilleEau = new Bouteille();   
            Bouteille bouteilleSoda = new Bouteille(false, 1.5f, 0.5f, "Soda");
            Bouteille saidrate = new Bouteille(false, 0.75f, 0.75f, "Boisson de Saïd");

            Console.WriteLine("---------------  Etats départ ------------------------------- ");

            bouteilleEau.BouteilleToString();
            bouteilleSoda.BouteilleToString();  
            saidrate.BouteilleToString();

            bouteilleEau.Remplir(0.29f);
            bouteilleEau.Fermer();

            bouteilleSoda.ViderTout();
            bouteilleSoda.Fermer();

            saidrate.Ouvrir();
            saidrate.Vider(0.25f);

            Console.WriteLine("---------------  Etats après changement 1  ------------------------------- ");
            bouteilleEau.BouteilleToString();
            bouteilleSoda.BouteilleToString();
            saidrate.BouteilleToString();





            Console.WriteLine("---------------  clonage bouteille saidrate  ------------------------------- ");





        }
    }
}