// See https://aka.ms/new-console-template for more information

float somme;
int nombreMagasins = 0;

String? saisie;
bool saisieOk = false;


Console.WriteLine("Dans combien de magasins Barnabé va t-il faire ses courses ?");


do
{
    Console.WriteLine(" Saisissez la somme en euros dont dispose Barnabé : ");
    saisie = Console.ReadLine();


    saisieOk = float.TryParse(saisie, out somme);

    if (somme < 0f)
    {
        Console.WriteLine("saisie incorrecte ! Recommencez !");
        saisieOk = false;
    }



} while (!saisieOk);

if (somme >= 1)
{

    while (somme >= 1 && somme / 2 - 1 > 1)
    {
        somme = somme / 2 - 1;
        nombreMagasins++;
        Console.WriteLine(somme);
    }

    Console.WriteLine("Barnabé à fait ses courses dans : " + nombreMagasins + " magasins");
}

else
{
    Console.WriteLine("Barnabé n'a pas pu faire ses courses.");
}