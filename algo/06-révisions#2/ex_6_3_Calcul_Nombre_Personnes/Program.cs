namespace ex_6_3_Calcul_Nombre_Personnes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint[] tableauAges = new uint[20];

            int moinsDe20ans = 0;
            int ont20ans = 0;
            int plusDe20ans = 0;

            bool saisieOk = false;

            #region#VerifSaisie
            do
            {
                Console.WriteLine("Programme de comptage de personnes par catégories d'êge.");
                Console.WriteLine("Saisissez les âges des 20 personnes séparés par un espace");
                String? saisie = Console.ReadLine();

                #region#SaisieNotNull
                if (saisie != null)
                {
                    try
                    {
                        tableauAges = saisie.Split(" ").Select(uint.Parse).ToArray();
                        saisieOk = true;
                    }
                    catch (Exception e)
                    {
                        saisieOk=false;
                        Console.WriteLine("Erreur saisie !");
                    }
                }
                else
                {
                    saisieOk = false;
                    Console.WriteLine("Erreur saisie !");
                }
                #endregion#SaisieNotNull

            } while (!saisieOk);
            #endregion#VerifSaisie


            #region#TriParCategoriesDages
            for (int i = 0; i < tableauAges.Length; i++)
            {
                if (tableauAges[i] < 20)
                {
                    moinsDe20ans++;
                }
                else if (tableauAges[i] == 20)
                {
                    ont20ans++; 
                }
                else
                {
                    plusDe20ans++;
                }
            }
            #endregion#TriParCategoriesDages



            #region#Affichage
            Console.WriteLine("Dans la liste suivante : \n\r");
            foreach (int i in tableauAges)
            {
                Console.Write("{0} ", i);
            }

            if (ont20ans ==  0 && plusDe20ans ==0)
            {
                Console.WriteLine(" \n\r Toutes les personnes ont moins de 20 ans.");    
            }
            else if (moinsDe20ans == 0 && ont20ans == 0)
            {
                Console.WriteLine(" \n\r Toutes les personnes ont plus de 20 ans.");

            }
            else
            {
                Console.WriteLine(" \n\r "+moinsDe20ans + " personnes ont moins de 20 ans \n\r " +
                                   ont20ans + " ont 20 ans. \n\r " +
                                   plusDe20ans + " ont plus de 20 ans.");
            }

            #endregion#Affichage

        }
    }
}