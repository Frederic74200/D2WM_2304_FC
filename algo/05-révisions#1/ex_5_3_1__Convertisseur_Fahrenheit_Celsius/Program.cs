// See https://aka.ms/new-console-template for more information

using System.Globalization;
CultureInfo culture1 = CultureInfo.CurrentCulture;

const double MINFAHRENHEIT = -459.67;
const double MINCELSIUS = -273.15;
const double MAX = 5000000d;
string quit;

#region#quit
do
{
    String? saisie;
    bool saisieOK = false;
    String farOUcel = "";
    double nombreAconcertir = 0d;
    double nombreConverti;

    #region#VerifSaise
    do
    {
        Console.WriteLine("Converstissuer Fahrenheit Celsius");
        Console.WriteLine("\t Saisissez la valeur à convertir puis son unité précédée d'un espace. \n\r" +
                          "\t F pour Fahrenheit | C pour Celsius \n\r" +
                          "\t Valeur minimum en degrés Fahrenheit : -456,67 F \n\r" +
                          "\t Valeur minimum en degrés Celsius : -273,15 C ");
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


            #region#VerifConversionDouble
            try
            {
                nombreAconcertir = double.Parse(saisie, culture1);
            }
            catch (Exception e)
            {
                saisieOK = false;
                Console.WriteLine("Erreur Saisie !");
            }
            #endregion#VerifConversionDouble


            #region#VerifMinMax
            switch (farOUcel)
            {
                case " f":
                    if (nombreAconcertir < MINFAHRENHEIT || nombreAconcertir > MAX)
                    {
                        saisieOK = false;
                        Console.WriteLine("Erreur Saisie !");
                    }
                    else
                    {
                        saisieOK = true;
                    }
                    break;

                case " c":
                    if (nombreAconcertir < MINCELSIUS || nombreAconcertir > MAX)
                    {
                        saisieOK = false;
                        Console.WriteLine("Erreur Saisie !");
                    }
                    else
                    {
                        saisieOK = true;
                    }
                    break;
            }
            #endregion#VerifMinMax

        }
        else
        {
            saisieOK = false;
            Console.WriteLine("Erreur Saisie !");
        }
        #endregion#VerifSaisieNull

    } while (!saisieOK);
    #endregion#VerifSaise


    #region#Conversion
    switch (farOUcel)
    {
        case " f":
            nombreConverti = (nombreAconcertir - 32) * 5 / 9;
            Console.WriteLine(nombreAconcertir + " °F correspondent à : " + nombreConverti + " °C.");
            break;

        case " c":
            nombreConverti = (nombreAconcertir * 9 / 5) + 32;
            Console.WriteLine(nombreAconcertir + " °C correspondent à : " + nombreConverti + " °F.");
            break;
    }
    #endregion#Conversion

    #region#SaisieQuit
    Console.WriteLine("Taper q pour quitter ou sur une autre touche pour remmencer.");
    quit = Console.ReadLine().ToLower();
    #endregion#SaisieQuit

} while (quit != "q");
#endregion#quit




