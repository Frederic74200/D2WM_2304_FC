using ClassLibraryLépidoptère;

namespace ConsoleAppLepidoptere
{
    internal class Program
    {

        
        static void Main(string[] args)
        {

            // œuf 
            Lepidoptere lepi = new Lepidoptere();
            Console.WriteLine(lepi.SeDeplacer());

            // chenille 
            lepi.SeMetamorphoser();
            Console.WriteLine(lepi.SeDeplacer());

            // chryssalide
            lepi.SeMetamorphoser();
            Console.WriteLine(lepi.SeDeplacer());

            // papillion 
            lepi.SeMetamorphoser();
            Console.WriteLine(lepi.SeDeplacer());

            // re papillion 
            lepi.SeMetamorphoser();
            Console.WriteLine(lepi.SeDeplacer());

        }

        
    }
}