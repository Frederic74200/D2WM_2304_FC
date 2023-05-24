// See https://aka.ms/new-console-template for more information

String texte = "";
int nomnbreMinCractères = 120;
bool saisieOK = false;
String alphabet = "abcdefghijklmnopqrstuvwxyz";


#region
do
{
    Console.WriteLine("Ssaisissez un texte de 120 caractères minimun: ");
   String saisie = Console.ReadLine();

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
for (int i=0; i<alphabet.Length; i++)
{
    int occurence = 0;
    for (int j=0; j<texte.Length; j++)
    {
        if ( texte[j] == alphabet[i])
        {
            occurence++;
        }
    } // fin for j

    if (occurence >= 1)
    {
        Console.WriteLine("La lettre : " + alphabet[i] + " est présente : " + occurence + " fois dans le texte.");
    }
}
#endregion

Console.WriteLine("Appuyer sur une touche pour quitter");
    Console.ReadLine();