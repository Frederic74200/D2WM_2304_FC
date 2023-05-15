namespace ex_6_4_nombre_voyelles_nombre_consonnes_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const String VOYELLES = "aeiouy";
            const string CONSONNES = "bcdfghjklmnpqrstvwxz";
            const String CHIFFRES = "0123456789";

            int compteurVoyelles = 0;
            int compteurConsonnes = 0;
            int compteurChiffres = 0;

            double totalChiffres = 0;
            String chiffresDansChaine = "";

            bool saisieOk = false;


            #region#VerifSaisie
            do
            {
                Console.WriteLine("Programme de comptage des types de caractères");
                Console.WriteLine("Saisissez un texte de 100 caractères minimum :");
                String? saisie = Console.ReadLine().ToLower();

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
                                saisie.Remove(j);
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
                                saisie.Remove(j);
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
                                chiffresDansChaine += saisie[j];
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
            for (int i = 0; i < chiffresDansChaine.Length; i++)
            {

                int askiiChiffres = chiffresDansChaine[i];

                switch (askiiChiffres)
                {
                    case 48:
                        totalChiffres += 0;
                        break;
                    case 49:
                        totalChiffres += 1;
                        break;
                    case 50:
                        totalChiffres += 2;
                        break;
                    case 51:
                        totalChiffres += 3;
                        break;
                    case 52:
                        totalChiffres += 4;
                        break;
                    case 53:
                        totalChiffres += 5;
                        break;
                    case 54:
                        totalChiffres += 6;
                        break;
                    case 55:
                        totalChiffres += 7;
                        break;
                    case 56:
                        totalChiffres += 8;
                        break;
                    case 57:
                        totalChiffres += 9;
                        break;
                    default:
                        totalChiffres += 0;
                        break;

                }
            }
            #endregion#totalChiffres


            #region#Affichage
            Console.WriteLine("le texte saisie compte : \n\r" +
                              compteurConsonnes + " consonnes. \n\r" +
                              compteurVoyelles + " voyelles. \n\r" +
                              +compteurChiffres + " chiffres. \n\r" +
                              "La moyenne des chiffres est : " + totalChiffres / compteurChiffres);
            #endregion#Affichage
        }
    }
}