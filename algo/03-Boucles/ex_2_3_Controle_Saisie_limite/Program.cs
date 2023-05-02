// See https://aka.ms/new-console-template for more information

String motDePasse = "formation";
String saisie;
bool saisieOk;
int nombreMaxiEssais = 3;


do
{
    Console.WriteLine("saisissez votre mot de passe : ");
    saisie  = Console.ReadLine();   

    if (saisie != motDePasse)
    {
        nombreMaxiEssais--;
        saisieOk = false;
        Console.WriteLine("Ce mot de passe n'est pas valide ! Il vous reste : " + nombreMaxiEssais + " essais !");
    }
    else
    {
        saisieOk = true;
    }

} while (!saisieOk && nombreMaxiEssais > 0);


if (saisieOk)
{
    Console.WriteLine("Vous êtes connecté.");
}

else
{
    Console.WriteLine("Votre compte est bloqué.");
}
