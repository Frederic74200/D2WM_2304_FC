using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace ex_6_1_fruits_kg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culture1 = CultureInfo.CurrentCulture;
            var textinfo = culture1.TextInfo;

            List<string> legumes = new List<string>();
            List<decimal> prix = new List<decimal>();

            string quit;

            #region#quit
            do
            {
                bool go = false;

                #region#SaisieListe
                do
                {
                    bool saisieOk = false;

                    #region#SaisieNomLegume
                    do
                    {
                        Console.WriteLine("Saisssiez le nom du fruit ou du légume ou GO pour afficher la liste: ");
                        String saisie = Console.ReadLine();
                        String legumePascalCase = textinfo.ToTitleCase(saisie);

                        #region#VerifSaisieNull
                        if (legumePascalCase != null)
                        {

                            #region#GoOuAdd
                            if (legumePascalCase == "Go")
                            {
                                go = true;
                                saisieOk = true;
                            }
                            else
                            {
                                legumes.Add(legumePascalCase);
                                saisieOk = true;
                            }
                            #endregion#GoOuAdd

                        }
                        else
                        {
                            saisieOk = false;
                            Console.WriteLine("Erreur Saisie ! ");
                        }
                        #endregion#VerifSaisieNull

                    } while (!saisieOk);
                    #endregion#SaisieNomLegume


                    saisieOk = false;


                    #region#SaisiePrixKg
                    if (!go)
                    {
                        do
                        {

                            Console.WriteLine("Saisissez le prix au kilo en euros :");
                            String saisie = Console.ReadLine();

                            #region#VerifSaisieNull
                            if (saisie != null)
                            {

                                #region#verifPrixDecimal
                                try
                                {
                                    decimal prixKg = decimal.Parse(saisie, culture1);
                                    prix.Add(prixKg);
                                    saisieOk = true;

                                }
                                catch (Exception e)
                                {
                                    saisieOk = false;
                                    Console.WriteLine("Erreur Saisie !");
                                }
                                #endregion#verifPrixDecimal
                            }
                            else
                            {
                                saisieOk = false;
                                Console.WriteLine("Erreur Saisie ! ");
                            }
                            #endregion#VerifSaisieNull

                        } while (!saisieOk);
                    }
                    #endregion#SaisiePrixKg

                } while (!go);
                #endregion#SaisieListe


                #region#RecherchePrixMin
                decimal min = prix[0];
                int indexMin = 0;

                for (int i = 0; i < prix.Count; i++)
                {
                    if (prix[i] < min)
                    {
                        min = prix[i];
                        indexMin = i;
                    }
                }
                #endregion#RecherchePrixMin

                #region#affichage
                for (int i = 0; i < prix.Count; i++)
                {
                    Console.WriteLine("1 kg de : " + legumes[i] + " vaut : " + prix[i] + " €");
                }

                Console.WriteLine("Le légume le moins cher au kg est : " + legumes[indexMin] + "\n\r");
                #endregion#affichage


                #region#SaisieQuit
                Console.WriteLine("Taper q pour quitter ou sur une autre touche pour continuer la liste.");
                quit = Console.ReadLine().ToLower();
                #endregion#SaisieQuit


            } while (quit != "q");
            #endregion#quit

        }
    }
}