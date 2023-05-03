// See https://aka.ms/new-console-template for more information

String phrase ="";
String point = ".";
String lettre = ""  ;
int occurrence = 0;
int i;

String? saisie;
bool saisieOK = false;  


Console.WriteLine("occurrences d'une lettre dans une phrase.");
#region
do
{
    Console.WriteLine("saisisez une phrase : ");
    saisie = Console.ReadLine();

    if (saisie != null)
    {
        saisie = saisie + point;
        phrase = saisie.ToLower();  
        saisieOK = true;
    }

} while (!saisieOK);
#endregion

saisieOK = false;
saisie = null;

#region
do
{
    Console.WriteLine("Saisissez la lette que vous souhaitez compter : ");
    saisie = Console.ReadLine();

    if (saisie != null)
    {
        lettre = saisie.ToLower();
        saisieOK = true;
    }

} while (!saisieOK);
#endregion

#region
if (phrase == point || phrase == "..")
{
    Console.WriteLine("La phrase est vide");
}

else
{
    for (i= 0; i < phrase.Length; i++)
    {
           if (System.String.Compare(phrase[i].ToString(), lettre) == 0 )
        {
            occurrence++;
        }
    }

    if (occurrence == 0)
    {
        Console.WriteLine("La lettre : "+lettre+" n'est pas présente");
    }
    else
    {
        Console.WriteLine("La lettre : "+lettre+" est présente : "+ occurrence + " fois dans la phrase.");
    }

}
#endregion