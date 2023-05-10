// See https://aka.ms/new-console-template for more information

// test

 const double MILESKM = 1.609;
string quit;

do
{

    String saisie;
    String nombreSaisie = "";
    String kmOUmi = "";

    double nombreAconcertir;
    double nombreConverti;

    do
    {

        Console.WriteLine("Converstissuer kilomètres miles");
        Console.WriteLine("Saisissez la valeur à convertir, inférieure à 1000000, et son unité (km pour kilomètres ou mi pour miles");
        saisie = Console.ReadLine().ToLower();

        for (int i = 0; i < saisie.Length; i++)

        {
            if (char.IsNumber(saisie[i]) || saisie[i] == 46)
            {
                nombreSaisie = nombreSaisie + saisie[i];
            }
            else
            {
                kmOUmi = kmOUmi + saisie[i];
            }
        }

        nombreAconcertir = Convert.ToDouble(nombreSaisie);


        Console.WriteLine(nombreAconcertir + "   " + kmOUmi);



    } while (nombreAconcertir < 0.01 || nombreAconcertir > 1000000d || saisie == null);


    switch (kmOUmi)
    {
        case "km":
            nombreConverti = nombreAconcertir / MILESKM;
            Console.WriteLine(nombreAconcertir+" kilomètres équivalent à :"+nombreConverti+" miles.");
            break;

        case "mi":
            nombreConverti = nombreAconcertir * MILESKM;
            Console.WriteLine(nombreAconcertir + " miles équivalent à :" + nombreConverti + " kilomètres.");
            break;
        case null:
            nombreConverti = nombreAconcertir / MILESKM;
            Console.WriteLine(nombreAconcertir + " équivalent à :" + nombreConverti + " milse.");
            break;
        default:
            Console.WriteLine("Saisie érronnée !");
            break;

    }



    Console.WriteLine("Taper q pour quitter ou sur une autre touche pour remmencer.");
    quit = Console.ReadLine().ToLower(); 

} while (quit != "q");