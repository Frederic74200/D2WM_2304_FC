using System;
using System.Globalization;

namespace ex_5_3_2_Far_Cel_plage
{
    // using System.Globalization;
    internal class Program
    {


        static void Main(string[] args)
        {

            CultureInfo culture1 = CultureInfo.CurrentCulture;

            const double MINFAHRENHEIT = -459.67;
            const double MINCELSIUS = -273.15;
            string quit;


            #region#quit
            do
            {
                String? saisie;
                bool saisieOK = false;
                String farOUcel = "";
                double nombreMinAconcertir = 0d;
                double nombreMaxAconcertir = 0d;

                double nombreConverti;


                Console.WriteLine("Converstissuer de plages Fahrenheit Celsius");

                #region#UniteAconvertir
                do
                {
                    Console.WriteLine("Saisissez l'unité que vous souhaitez convertir : \n\r" +
                                      "\t F pour Fahrenheit | C pour Celsius \n\r");
                    farOUcel = Console.ReadLine().ToLower();

                    #region#VerifNotNull
                    if (farOUcel != null)
                    {
                        #region#VerifCouF
                        if (farOUcel == "c" || farOUcel == "f")
                        {
                            saisieOK = true;
                        }
                        else
                        {
                            saisieOK = false;
                            Console.WriteLine("Erreur Saisie !");
                        }
                        #endregion#VerifCouFS
                    }
                    else
                    {
                        saisieOK = false;
                        Console.WriteLine("Erreur Saisie !");
                    }
                    #endregion#VerifNotNull


                } while (!saisieOK);
                #endregion#UniteAconvertir

                saisieOK = false;


                #region#SaisieMin
                do
                {
                    Console.WriteLine("Saisissez la valeur minimum : \n\r" +
                                        "Ne peut être inférieure à -459,67 °F ou -273,15 °C");
                    saisie = Console.ReadLine().ToLower();

                    #region#VerifNotNull
                    if (farOUcel != null)
                    {
                        #region#VerifConversionDouble
                        try
                        {
                            nombreMinAconcertir = double.Parse(saisie, culture1);
                            saisieOK=true;
                        }
                        catch (Exception e)
                        {
                            saisieOK = false;
                            Console.WriteLine("Erreur Saisie !");
                        }
                        #endregion#VerifConversionDouble


                        #region#VerifMin
                        if (farOUcel == "c" && nombreMinAconcertir > MINCELSIUS)
                        {
                            saisieOK = true;
                        }
                        else if (farOUcel == "f" && nombreMinAconcertir > MINFAHRENHEIT)
                        {
                            saisieOK = true;
                        }
                        else
                        {
                            saisieOK = false;
                            Console.WriteLine("Erreur Saisie !");
                        }
                        #endregion#VerifMin

                    }
                    else
                    {
                        saisieOK = false;
                        Console.WriteLine("Erreur Saisie !");
                    }
                    #endregion#VerifNotNull

                } while (!saisieOK);
                #endregion#SaisieMin

                saisieOK = false;
                saisie = "";



                #region#SaisieMax
                do
                {
                    Console.WriteLine("Saisissez la valeur maximum : \n\r");
                    saisie = Console.ReadLine().ToLower();

                    #region#VerifNotNull
                    if (farOUcel != null)
                    {
                        #region#VerifConversionDouble
                        try
                        {
                            nombreMaxAconcertir = double.Parse(saisie, culture1);
                            saisieOK = true;
                        }
                        catch (Exception e)
                        {
                            saisieOK = false;
                            Console.WriteLine("Erreur Saisie !");
                        }
                        #endregion#VerifConversionDouble

                    }
                    else
                    {
                        saisieOK = false;
                        Console.WriteLine("Erreur Saisie !");
                    }
                    #endregion#VerifNotNull

                } while (!saisieOK);
                #endregion#SaisieMax

                // FIN SAISIE --------------------------------------------------------------------------------------------------------


                #region#Arrondis
                nombreMinAconcertir = Math.Ceiling(nombreMinAconcertir);
                nombreMaxAconcertir = Math.Floor(nombreMaxAconcertir);
                int min = Convert.ToInt32(nombreMinAconcertir);
                int max = Convert.ToInt32(nombreMaxAconcertir);
                #endregion#Arrondis



                #region#AffichageCelEnFar
                if (farOUcel == "c")
                {
                    for (int i = min; i <= max; i++)
                    {
                        nombreConverti = (i * 9d / 5d) + 32d;
                        Console.WriteLine(i + " °C ->> " + Math.Round(nombreConverti, 2) + " F.");
                    }
                }
                #endregion#AffichageCelEnFar

                #region#AffichageFarEnCel
                else
                {
                    for (int i = min; i <= max; i++)
                    {
                        nombreConverti = (i - 32d) * 5d / 9d;
                        Console.WriteLine(i + " °F ->> " + Math.Round(nombreConverti, 2) + " C.");
                    }
                }
                #endregion#AffichageFarEnCel


                #region#SaisieQuit
                Console.WriteLine("Taper q pour quitter ou sur une autre touche pour remmencer.");
                quit = Console.ReadLine().ToLower();
                #endregion#SaisieQuit


            } while (quit != "q");
            #endregion#quit



        }
    }
}