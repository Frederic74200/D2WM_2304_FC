// See https://aka.ms/new-console-template for more information


int[] tableau = new int[7] { 128, 64, 8, 512, 16, 32, 256 };

// afficher tableau départ
Console.WriteLine("Tableau initial : \n\r");
foreach (int i in tableau)
{
    Console.Write("{0} ", i);
}


#region#GrandeBoucleFor
for (int i = 0; i < tableau.Length; i++)
{
    int tmp = tableau[i];
    int min = tmp;
    int index = i;
    #region#RechercheMin
    for (int j = i; j < tableau.Length; j++)
    {

        if (tableau[j] < min)
        {
            min = tableau[j];
            index = j;
        }
    }
    #endregion#RechercheMin

    tableau[i] = min;
    tableau[index] = tmp;
}
#endregion#GrandeBoucleFor


// afficher tableau final
Console.WriteLine("\n\r Tableau final : \n\r");

foreach (int k in tableau)
{
    Console.Write("{0} ", k);
}


