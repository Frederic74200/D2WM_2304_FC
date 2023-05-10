// See https://aka.ms/new-console-template for more information


using System.ComponentModel;

const double MILESKM = 1.609;
string quit;

#region#quit
do
{
    String? saisie;
    bool saisieOK = false;
    String nombreSaisie = "";
    String kmOUmi = "";
    double nombreAconcertir = 0d;
    double nombreConverti;
    char virgule = ',';

    #region#VerifSaise
    do
    {
        Console.WriteLine("Converstissuer kilomètres miles");
        Console.WriteLine("--> Saisissez la valeur à convertir entre 0.01 et 1 000 000 \n\r" +
                          "--> ainsi que son unité (km pour kilomètres ou mi pour miles");
        saisie = Console.ReadLine().ToLower();

        #region#VerifSaisieNull
        if (saisie != null)
        {

            #region#Extration2derniersCaracteres
            for (int i = saisie.Length - 2; i < saisie.Length; i++)
            {
                kmOUmi = kmOUmi + saisie[i];
            }
            #endregion#Extration2derniersCaracteres


            #region#verifKmOuMiles
            int indexSaisie = saisie.Length;

            if (kmOUmi == "km" || kmOUmi == "mi")
            {
                saisie = saisie.Remove(indexSaisie - 1);
                saisie = saisie.Remove(indexSaisie - 2);
            }
            else if (char.IsNumber(saisie[indexSaisie - 1]))
            {
                kmOUmi = null;
            }
            else
            {
                saisieOK = false;
                Console.WriteLine("Erreur Saisie !");
            }
            #endregion#verifKmOuMiles



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
            #endregion#ExtractionChiffresLettresDeChaine


            #region#testDouble
            try
            {
                nombreAconcertir = double.Parse(nombreSaisie);
            }
            catch (Exception e)
            {
                saisieOK = false;
                Console.WriteLine("Erreur Saisie !");
            }
            #endregion#testDouble


            #region#VerifSaisieNomnbre
            if (nombreAconcertir < 0.01 || nombreAconcertir > 1000000d)
            {
                saisieOK = false;
                Console.WriteLine("Erreur Saisie !");

            }
            else
            {
                saisieOK = true;
            }
            #endregion#VerifSaisieNomnbre


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
    switch (kmOUmi)
    {
        case "km":
            nombreConverti = nombreAconcertir / MILESKM;
            Console.WriteLine(nombreAconcertir + " kilomètres équivalent à : " + nombreConverti + " miles.");
            break;

        case "mi":
            nombreConverti = nombreAconcertir * MILESKM;
            Console.WriteLine(nombreAconcertir + " miles équivalent à : " + nombreConverti + " kilomètres.");
            break;
        case null:
            nombreConverti = nombreAconcertir / MILESKM;
            Console.WriteLine(nombreAconcertir + " kilomètres équivalent à : " + nombreConverti + " miles.");
            break;
        default:
            Console.WriteLine("\"Erreur Saisie !");
            break;
    }
    #endregion#Conversion


    Console.WriteLine("Taper q pour quitter ou sur une autre touche pour remmencer.");
    quit = Console.ReadLine().ToLower();

} while (quit != "q");
#endregion#quit











