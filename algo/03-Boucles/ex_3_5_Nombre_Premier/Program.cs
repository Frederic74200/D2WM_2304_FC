// See https://aka.ms/new-console-template for more information

int nombreSaisi;
bool saisieOK;
String saisie;
bool nombrePremier = true;
int i = 2;

Console.WriteLine("Programme pour déterminer si un nombre est premier.");


do
{
    Console.WriteLine("Saisissez un nombre entier positif.");
    saisie = Console.ReadLine();

    saisieOK = int.TryParse(saisie, out nombreSaisi);

    if (nombreSaisi < 1)
    {
        saisieOK = false;
    }

} while (!saisieOK);


while (i < nombreSaisi && nombrePremier)
{
    if (nombreSaisi % i == 0)
    {
        nombrePremier = false;
    }
    i++;
}

if (!nombrePremier)
{
    Console.WriteLine("Le nombre : " + nombreSaisi + " n'est pas un nombre premier.");
}

else
{
    Console.WriteLine("Le nombre : " + nombreSaisi + " est un nombre premier.");
}

