namespace ex_1_5_surface_secteur_angulaire
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // VARIABLES
            double rayonR;
            double angleA;
            double aire;
            const double NOMBREPI = Math.PI;

            // TRAITEMENT
            Console.WriteLine("Programme de calcul d'un secteur circulaire");

            Console.WriteLine("Veuillez saisir le rayon du secteur en centimètres.");
            rayonR = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Veuillez saisir l'angle du secteur en degrés");
            angleA = Convert.ToDouble(Console.ReadLine());

            aire = (NOMBREPI * Math.Pow(rayonR,2) * angleA) / 360d;

            // FIN TRAITEMENT


            // AFFICHAGE
            Console.WriteLine("Le rayon du secteur est : " + rayonR.ToString("#.###") + " cm" + "\n\r"
                              + "L'angle du secteur est :" + angleA.ToString("#.~###") + " deg" + "\n\r"
                              + "L'aire du secteur est : " + aire.ToString("#.###") + " cm2" + "\n\r");

            // FIN PROGRAMME


        }
    }
}