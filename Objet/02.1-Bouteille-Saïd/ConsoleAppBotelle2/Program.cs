using Bouteille_Said_Class;

namespace ConsoleAppBotelle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bouteille bouteilleEau = new Bouteille();
            Bouteille bouteilleSoda = new Bouteille(false, 1.5f, 0.5f, "Soda");
            Bouteille saidrate = new Bouteille(false, 0.75f, 0.75f, "Boisson de Saïd");

            Console.WriteLine("---------------  Etats départ ------------------------------- ");

            Console.WriteLine(bouteilleEau.BouteilleToString());
            Console.WriteLine(bouteilleSoda.BouteilleToString());
            Console.WriteLine(saidrate.BouteilleToString());

            bouteilleEau.Remplir(0.29f);
            bouteilleEau.Fermer();

            bouteilleSoda.Ouvrir();
            bouteilleSoda.ViderTout();          

            saidrate.Ouvrir();
            saidrate.Vider(0.25f);

            Console.WriteLine("---------------  Etats après changement 1  ------------------------------- ");
            Console.WriteLine(bouteilleEau.BouteilleToString());
            Console.WriteLine(bouteilleSoda.BouteilleToString());
            Console.WriteLine(saidrate.BouteilleToString());


            Console.WriteLine("---------------  clonage bouteille saidrate  ------------------------------- ");

            Bouteille saidrate2 = new Bouteille(saidrate);
            Bouteille saidrate3 = new Bouteille(saidrate); 


            Console.WriteLine(" ---------------- Etats Bouteilles Saïd -------------------------------------");

            Console.WriteLine(saidrate.BouteilleToString());
            Console.WriteLine(saidrate2.BouteilleToString());
            Console.WriteLine(saidrate3.BouteilleToString());

            saidrate.ViderTout();

            saidrate2.Ouvrir();
            saidrate2.ViderTout();

            saidrate3.Ouvrir();
            saidrate3.ViderTout();

            saidrate.Fermer();
            saidrate2.Fermer();
            saidrate3.Fermer();

            Console.WriteLine(" ---------------- Nouveaux Etats Bouteilles Saïd -------------------------------------");

            Console.WriteLine(saidrate.BouteilleToString());
            Console.WriteLine(saidrate2.BouteilleToString());
            Console.WriteLine(saidrate3.BouteilleToString());



        }
    }
}