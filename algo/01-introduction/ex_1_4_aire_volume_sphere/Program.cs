namespace ex_1_4_aire_volume_sphere
{
    internal class Program
    {
        static void Main(string[] args)
        {


         // VARIABLES
            double rayonR;
            double aire;
            double volume;
            const double NOMBREPI = Math.PI;


            // TRAITEMENT
            Console.WriteLine("Programme de calcul de l'aire et du volume d'une sphère.");
            Console.WriteLine("Veuillez saisir le rayon de la sphère en centimètres.");
            rayonR = Convert.ToDouble(Console.ReadLine());


            aire = 4 * NOMBREPI * Math.Pow(rayonR, 2);
            volume = 4d / 3d * NOMBREPI * Math.Pow(rayonR,3);


        // FIN TRAITEMENT

        // AFFICHAGE
            Console.WriteLine("Le rayon de la sphère est : "+rayonR.ToString("#.###")+" cm"+"\n\r"
                            +"L'aire de la sphère est : "+aire.ToString("#.###") + " cm2"+"\n\r"
                               +"Le volume de la sphère est : "+volume.ToString("#.###") + " cm3");

            Console.WriteLine("Appuyer sur une touche pour fermer le programme");
            Console.ReadLine();

        // FIN PROGRAMME
       
        }
    }
}