// See https://aka.ms/new-console-template for more information

Random rnd = new Random();
/*
Random rnd = new Random();
int month = rnd.Next(1, 13);
Console.WriteLine(month);   

*/

int n;
int proposition;
int min = 0;
int max = 100;
int nombreEssais = 0;

String saisie;
bool saisieOk;


Console.WriteLine("Jeu de la fourchette");
n = rnd.Next(0, 100);

do
{
    do
    {
        Console.WriteLine("Proposez un nombre entre " + min + " et " + max);
        saisie = Console.ReadLine();
        saisieOk = int.TryParse(saisie, out proposition);

        if (!saisieOk || (proposition < min || proposition > max))
        {
            Console.WriteLine("Saisie Incorrecte !");
            saisieOk = false;
        }


    } while (!saisieOk);


    if (proposition < n)
    {
        min = proposition;
    }

    else if (proposition > n)
    {
        max = proposition;
    }

    ++nombreEssais;

} while (proposition != n);

Console.WriteLine("Bravo ! Vous avez trouvé en " + nombreEssais + " essais.");

