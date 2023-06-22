using ClassLibraryCompteBanquaire;

namespace ConsoleAppCompteBanquaire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            CompteBanquaire c1 = new CompteBanquaire();
            CompteBanquaire c2 = new CompteBanquaire(12345, "Toto", 1000, -500);

            Console.WriteLine(c1.CompteToString());
            Console.WriteLine(c2.CompteToString());

            Console.WriteLine("---------------------------------");

            CompteBanquaire b = new CompteBanquaire(545454, "Laurent", 2000, -500);
            b.CrediterUnMontant(100);
            Console.WriteLine(b.CompteToString());

            bool ok = b.DebiterUnMontant(10000);
            Console.WriteLine(b.CompteToString());
            if (ok)
            {
                Console.WriteLine("Débit réussi");
            }
            else
            {
                Console.WriteLine("Débit pas réussi");
            }

            Console.WriteLine("---------------------------------");

            CompteBanquaire c3 = new CompteBanquaire(45657, "Titi", 2000, -1000);

            c2.TransfererMontantVersAutreCompte(c3, 1300);
            Console.WriteLine(c2.CompteToString());
            Console.WriteLine(c3.CompteToString());


            Console.WriteLine("---------------------------------");

            bool sup = c2.SoldeCompteSuperieurAunAutreCompte(c3);
            if (sup)
            {
                Console.WriteLine("Superieur");
            }
            else
            {
                Console.WriteLine("Inferieur");
            }


            Console.WriteLine("---------------------------------");
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
        }
    }
}