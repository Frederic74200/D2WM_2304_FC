using ClassLibraryLépidoptère;

namespace ConsoleAppSerre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lepidoptere lepi1 = new Lepidoptere();
            Lepidoptere lepi2 = new Lepidoptere();
            Lepidoptere lepi3 = new Lepidoptere();


            List<Object> GroupePapillions1 = new List<Object>();
            List<Object> GroupePapillions2 = new List<Object>();
            List<Object> nouvelleGeneration = new List<Object>();


            for (int i = 0; i < 200; i++)
            {
                GroupePapillions1.Add(new Lepidoptere(lepi1));
                GroupePapillions2.Add(new Lepidoptere(lepi2));

            }


            for (int i = 0; i < 200; i++) // oeuf à chenille
            {
                GroupePapillions1[i] = lepi1.SeMetamorphoser();
                GroupePapillions2[i] = lepi2.SeMetamorphoser();
            }

            for (int i = 0; i < 200; i++) // chenille à Chrysalide 
            {
                GroupePapillions1[i] = lepi1.SeMetamorphoser();
                GroupePapillions2[i] = lepi2.SeMetamorphoser();
            }


            for (int i = 0; i < 200; i++) // Chrysalide à papillion 
            {
                GroupePapillions1[i] = lepi1.SeMetamorphoser();
                GroupePapillions2[i] = lepi2.SeMetamorphoser();
            }

            for (int i = 0; i < 200; i++) 
            {
                int genreA = GroupePapillions1[i](lepi1.Genre0m1f);



                GroupePapillions1[i] = lepi1.SeMetamorphoser();
                GroupePapillions2[i] = lepi2.SeMetamorphoser();
            }


        }
    }
}