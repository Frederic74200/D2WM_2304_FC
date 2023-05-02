// See https://aka.ms/new-console-template for more information

int nombreA;
int nombreB;
String saisie;
bool saiseOK;

Console.WriteLine("Programme d'affichage des entiers entre deux nombres.");

do
{
    Console.WriteLine("Saisissez le premier nombre : ");
    saisie = Console.ReadLine();
    saiseOK = int.TryParse(saisie, out nombreA);

} while (!saiseOK);

saiseOK = false;


do
{
    Console.WriteLine("Saisissez le second nombre : ");
    saisie = Console.ReadLine();
    saiseOK = int.TryParse(saisie, out nombreB);

} while (!saiseOK);

if (nombreA < nombreB)
{
    do
    {
        nombreA++;

        Console.Write(nombreA + " ");
    } while (nombreA < nombreB-1);
}

else
{
    do
    {
        nombreB++;

        Console.Write(nombreB + " ");
    } while (nombreB < nombreA-1);

}

