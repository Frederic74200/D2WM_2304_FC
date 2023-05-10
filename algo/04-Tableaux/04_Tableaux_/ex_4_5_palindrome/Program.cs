// See https://aka.ms/new-console-template for more information


/* System.String.Compare(invertText[i].ToString, taxtWhitoutSpace[i].ToString) != 0)  */

String text ="";
String imput;
bool entryOK = false;

String taxtWhitoutSpace = "";
String invertText = "";
String space = " ";
int i;
bool palindrome = true;

Console.WriteLine("Le mot ou la phrase sont-ils des palindromes ? ");

// Saisie ---------------
#region
do
{
    Console.WriteLine("Saisiez un mot ou une phrase : ");
    imput = Console.ReadLine();
    if (imput != null)
    {
        text = imput.ToLower();
        entryOK = true;
    }
    else
    {
        Console.WriteLine("La phrase est vide");
    }
} while (!entryOK);
#endregion

// supprimer les espaces -------
#region
for (i=0; i<text.Length; i++)
{
    if (System.String.Compare(text[i].ToString(), space) != 0)
    {
        taxtWhitoutSpace = taxtWhitoutSpace + text[i];
    }
}
#endregion


// Créer nouvelle chaîne inversée -------------


#region
for (i= taxtWhitoutSpace.Length-1; i>0; i--)
{
    invertText = invertText + taxtWhitoutSpace[i].ToString();
}
#endregion

// Comparer les textes sans espace et texte inversé ---------
i = 0;

#region
do
{
    if (invertText[i] == taxtWhitoutSpace[i])
    {
        i++;
        palindrome = true;
    }   
    else
    {
        palindrome = false;
    }
} while (palindrome && i < invertText.Length);
#endregion


// affichage ------------------------------------------

if (palindrome)
{
    Console.WriteLine("la chaîne de caractères est un palindrome");
}
else
{
    Console.WriteLine("la chaîne de caractères n’est pas un palindrome");
}

