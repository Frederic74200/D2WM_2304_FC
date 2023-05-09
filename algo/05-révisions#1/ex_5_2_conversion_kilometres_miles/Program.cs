// See https://aka.ms/new-console-template for more information



const double MILESKM = 1.609;
string quit;

#region#quit
do
{
    String? saisie ;
    bool saisieOK = false;
    String nombreSaisie = "";
    String kmOUmi = null;
    double nombreAconcertir = 0d;
    double nombreConverti;
    char point = '.';
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
            String saisiePointVirgule = "";

            #region#RemplacerPointParVirgule
            for (int i=0; i<saisie.Length; i++)
            {
                if (saisie[i] == point)
                {
                    saisiePointVirgule = saisiePointVirgule + virgule;
                }
                else
                {
                    saisiePointVirgule = saisiePointVirgule + saisie[i];
                }
            }
            #endregion#RemplacerPointParVirgule


            #region#ExtractionChiffresLettresDeChaine
            for (int i = 0; i < saisiePointVirgule.Length; i++)
            {
                if (char.IsNumber(saisiePointVirgule[i]) || saisiePointVirgule[i] == virgule) 
                {
                    nombreSaisie = nombreSaisie + saisiePointVirgule[i];
                }
                else
                {
                    kmOUmi = kmOUmi + saisiePointVirgule[i];
                }
            }
            #endregion#ExtractionChiffresLettresDeChaine


            nombreAconcertir = Convert.ToDouble(nombreSaisie);


            #region#VerifSaisieNomnre
            if (nombreAconcertir < 0.01 || nombreAconcertir > 1000000d)
            {
                saisieOK = false;
            }
            else
            {
                saisieOK = true;
            }
            #endregion#VerifSaisieNomnre

        }
        else 
        { 
            saisieOK = false; 
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
            Console.WriteLine("Saisie érronnée !");
            break;
    }
    #endregion#Conversion


    Console.WriteLine("Taper q pour quitter ou sur une autre touche pour remmencer.");
    quit = Console.ReadLine().ToLower();

} while (quit != "q");
#endregion#quit







