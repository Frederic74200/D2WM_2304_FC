// See https://aka.ms/new-console-template for more information

String texte = "";
int nomnbreMinCractères = 120;
bool saisieOK = false;
String alphabet = "abcdefghijklmnopqrstuvwxyz";
int occurence = 0;
int i;
int j;

String saisie;

#region
do
{
    Console.WriteLine("Ssaisissez un texte de 120 caractères minimun: ");
    saisie = Console.ReadLine();

    if (saisie != null && saisie.Length >= nomnbreMinCractères)
    {
        saisieOK = true;
        texte = saisie.ToLower();
    }
    else
    {
        Console.WriteLine("Le texte doit avoir au moins 120 caractères ! recommencez !");
    }


} while (!saisieOK);
#endregion

#region
for (i=0; i<alphabet.Length; i++)
{
    for (j=0; j<texte.Length; j++)
    {
        if ( texte[j] == alphabet[i])
        {
            occurence++;
        }
    } // fin for j

    if (occurence >= 1)
    {
        Console.WriteLine("La lettre : " + alphabet[i] + " est présente : " + occurence + " dans le texte.");
    }

    j = 0;
    occurence = 0;

}
#endregion