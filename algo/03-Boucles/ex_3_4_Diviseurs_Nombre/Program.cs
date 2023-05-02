// See https://aka.ms/new-console-template for more information

/* Lire un nombre entier et afficher tous ses diviseurs autres que 1 et lui-même.*/

int nombreSaisi;
String saisie;
bool saisieOk;

int i = 2;
int j;
int[] tableauDiviseurs = new int[0];
bool diviseurTrouve = false;


Console.WriteLine("Programme de recherche des diviseurs d'un nombre entier.");

do
{
    Console.WriteLine("Saisissez un nombre entier positif.");
    saisie = Console.ReadLine();

    saisieOk = int.TryParse(saisie, out nombreSaisi);

    if (nombreSaisi < 1)
    {
        saisieOk = false;
    }

} while (!saisieOk);

while (i < nombreSaisi)
{
    if (nombreSaisi % i == 0)
    {
        Console.WriteLine("contrôle");


        for (j = 0; j < tableauDiviseurs.Length; j++)   // j = 0 égal forcement à fin tableau. C# n'accepte rien d'autre
        {
            tableauDiviseurs[j + 1] = i;
            Console.WriteLine(i);
        }


        diviseurTrouve = true;

    }

    i++;
}


if (!diviseurTrouve)
{
    Console.WriteLine("Le nombre : " + nombreSaisi + " est un nombre premier.");
}

else
{

    Console.WriteLine("Les diviseurs du nombre ." + nombreSaisi + " sont : " + tableauDiviseurs.ToString());
}