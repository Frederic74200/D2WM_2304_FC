namespace ex_2_5_bicyclette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES ------------------------------------------------------------------------------------------------

            
           bool ilFaitBeau;
           bool bicycletteOK;
           bool delaiGraragisteOk;
           bool livreGOTdansBibliothequeSalon;
           bool livreGOTaBibliothequeMunicipale;

            String saisie;
            String oui = "0";
            // String non = "n";



            /*
            Console.WriteLine("Fait il beau ?");

            ilFaitBeau = Console.ReadLine() == oui;
            */

            // TRAIEMENT -----------------------------------------------------------------------------


            Console.WriteLine("Que vais-je faire demain ? ");

            Console.WriteLine("Est-ce qu'il va faire beau demain ? " + "\n\r"+
                               "Entrez o pour oui ou une autre touche pour non");

            
            saisie = Console.ReadLine();

            saisie.ToLower();

            ilFaitBeau = saisie == oui;

          

        






            // il fait beau ---------------------------------------





            // il pleut





            // FIN TRAITEMENT




            // FIN PROGRAMME 

        }
    }
}