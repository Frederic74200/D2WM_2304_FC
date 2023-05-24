using System.Globalization;

namespace ex_6_4_nombre_voyelles_nombre_consonnes_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CultureInfo cultureFr = CultureInfo.InvariantCulture;


            const string VOYELLES = "aeiouy";
            const string CONSONNES = "bcdfghjklmnpqrstvwxz";
            const string CHIFFRES = "0123456789";

            int compteurVoyelles = 0;
            int compteurConsonnes = 0;
            int compteurChiffres = 0;

            double totalChiffres = 0;           
            List<int> listeChiffres = new List<int>();

            bool saisieOk = false;


            #region#VerifSaisie
            do
            {
                Console.WriteLine("Programme de comptage des types de caractères");
                Console.WriteLine("Saisissez un texte de 100 caractères minimum :");
                string? saisie = Console.ReadLine().ToLower();

                #region#SaisieNotNullEtSupp100Char
                if (saisie != null && saisie.Length >= 100)
                {

                    #region#RechercheVoyelles
                    for (int i = 0; i < VOYELLES.Length; i++)
                    {
                        for (int j = 0; j < saisie.Length; j++)
                        {
                            if (saisie[j] == VOYELLES[i])
                            {
                                compteurVoyelles++;                          
                            }
                        }
                    }
                    #endregion#RechercheVoyelles

                    #region#RechercheConsonnes
                    for (int i = 0; i < CONSONNES.Length; i++)
                    {
                        for (int j = 0; j < saisie.Length; j++)
                        {
                            if (saisie[j] == CONSONNES[i])
                            {
                                compteurConsonnes++;                            
                            }
                        }
                    }
                    #endregion#RechercheConsonnes


                    #region#RechercheChiffres
                    for (int i = 0; i < CHIFFRES.Length; i++)
                    {
                        for (int j = 0; j < saisie.Length; j++)
                        {
                            if (CHIFFRES[i] == saisie[j])
                            {
                                compteurChiffres++;

                                int chiffre =  Convert.ToInt32(new String(saisie[j],1));

                                listeChiffres.Add(chiffre);
                            }
                        }
                    }
                    #endregion#RechercheChiffres


                    saisieOk = true; // sortie boucle do while

                }
                else
                {
                    Console.WriteLine("Erreur saisie !");
                    saisieOk = false;
                }
                #endregion#SaisieNotNullEtSupp100Char


            } while (!saisieOk);
            #endregion#VerifSaisie



            #region#totalChiffres
           foreach (int i in listeChiffres)
            {
                totalChiffres += i;
            }
            #endregion#totalChiffres


            #region#Affichage
            Console.WriteLine("le texte saisie compte : \n\r" +
                              compteurConsonnes + " consonnes. \n\r" +
                              compteurVoyelles + " voyelles. \n\r" +
                              +compteurChiffres + " chiffres. \n\r" +
                              "La moyenne des chiffres est : " + totalChiffres / compteurChiffres+" \n\r"+
                              "La liste des chiffres est : \n\r");
            foreach (int i in listeChiffres)
            {
                Console.Write("{0} ", i);
            }

            #endregion#Affichage
        }
    }
}