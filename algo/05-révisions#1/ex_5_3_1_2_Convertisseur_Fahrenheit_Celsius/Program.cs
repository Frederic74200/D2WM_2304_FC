using System.Globalization;

namespace ex_5_3_1_2_Convertisseur_Fahrenheit_Celsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            


            const double MINFAHRENHEIT = -459.67;
            const double MINCELSIUS = -273.15;

            string quit;

            #region#quit
            do
            {

                String? saisie;
                bool saisieOK = false;
                String nombreSaisie = "";
                String farOUcel = "";
                double nombreAconcertir = 0d;
                double nombreConverti;
                char virgule = ',';

                #region#VerifSaise
                do
                {

                    Console.WriteLine("Converstissuer Fahrenheit Celsius");
                    Console.WriteLine("--> Saisissez la valeur à convertir puis son unité précédée d'un espace. \n\r" +
                                      "--> F pour Fahrenheit | C pour Celsius \n\r" +
                                      "--> Valeur minimum en degrés Fahrenheit : -456,67 F \n\r" +
                                        "--> Valeur minimum en degrés Celsius : -273,15 C \n\r");
                    saisie = Console.ReadLine().ToLower();


                    #region#VerifSaisieNull
                    if (saisie != null)
                    {

                        #region#Extration2derniersCaracteres
                        for (int i = saisie.Length - 2; i < saisie.Length; i++)
                        {
                            farOUcel = farOUcel + saisie[i];
                        }
                        #endregion#Extration2derniersCaracteres



                        #region#verifFarouCel
                        int indexSaisie = saisie.Length;

                        if (farOUcel == " f" || farOUcel == " c")
                        {
                            saisie = saisie.Remove(indexSaisie - 1);
                            saisie = saisie.Remove(indexSaisie - 2);
                        }
                        else
                        {
                            saisieOK = false;
                            Console.WriteLine("Erreur Saisie !");
                        }
                        #endregion#verifFarouCel



                        #region#ExtractionChiffresDeChaine
                        for (int i = 0; i < saisie.Length; i++)
                        {
                            if (char.IsNumber(saisie[i]) || saisie[i] == virgule)
                            {
                                nombreSaisie = nombreSaisie + saisie[i];
                            }
                            else
                            {
                                saisieOK = false;
                                Console.WriteLine("Erreur Saisie !");
                            }
                        }
                        #endregion#ExtractionChiffresDeChaine











                    }
                    else
                    {
                        saisieOK = false;
                        Console.WriteLine("Erreur Saisie !");
                    }
                    #endregion#VerifSaisieNull














                } while (!saisieOK);
                #endregion#VerifSaise




















                Console.WriteLine("Taper q pour quitter ou sur une autre touche pour remmencer.");
                quit = Console.ReadLine().ToLower();

            } while (quit != "q");
            #endregion#quit





        }
    }
}