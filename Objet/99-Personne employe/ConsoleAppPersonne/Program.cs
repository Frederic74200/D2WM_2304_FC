using ClassLibraryPersonne;

namespace ConsoleAppPersonne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<Personne> entreprise = new List<Personne>();


            entreprise.Add( new Employe("NOM1", "PRENOM1", new DateTime(1985, 3, 4), 9000));
            entreprise.Add(new Employe("NOM2", "PRENOM2", new DateTime(1984, 3, 4), 10000));
            entreprise.Add(new Employe("NOM3", "PRENOM3", new DateTime(1983, 3, 4), 8000));
            entreprise.Add(new Employe("NOM4", "PRENOM4", new DateTime(1982, 3, 4), 11000));
            entreprise.Add(new Employe("NOM5", "PRENOM5", new DateTime(1981, 3, 4), 7000));
            entreprise.Add(new Chef("NOM6", "PRENOM6", new DateTime(1988, 7, 6), 9000.9989, "SERVICE1"));
            entreprise.Add(new Chef("NOM7", "PRENOM7", new DateTime(1984, 7, 6), 9000, "SERVICE2"));
            entreprise.Add(new Directeur("NOM8", "PRENOM8", new DateTime(1988, 7, 6), 9000, "SERVICE3", "SOCIETE1"));
          

            for (int i = 0 ; i< entreprise.Count-1; i++)
            {
                Console.WriteLine(entreprise[i].Afficher());
            }


            foreach( Personne presonne in entreprise )
            {
                Console.WriteLine(presonne.Afficher());
            }
        }
    }
}