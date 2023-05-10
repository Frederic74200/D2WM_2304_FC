// See https://aka.ms/new-console-template for more information


int[] tableau = new int[] {8, 16, 32, 64, 128, 256, 512};
int nombreN;
bool nombreTrouve = false;
int i;

String saisie;
bool saisieOK;

Console.WriteLine("Le nombre se trouve t-il dans le tableau ?");

do
{
    Console.WriteLine("Saisissez un nombre entier : ");
    saisie = Console.ReadLine();    
    saisieOK = int.TryParse(saisie, out nombreN );
    if (saisieOK == false)
    {
        Console.WriteLine("Saisie incorrecte ! Recommencez !");
    }
} while (!saisieOK);


for (i = 0; i < tableau.Length; i++)
{
    if (tableau[i] == nombreN)
    {
        Console.WriteLine("Le nombre " + nombreN + " se trouve à l'index : " + i); 
        nombreTrouve = true;    
    }
}


if (nombreTrouve == false)
{
    Console.WriteLine("Le nombre "+nombreTrouve+" n'est pas dans le tableau");
}