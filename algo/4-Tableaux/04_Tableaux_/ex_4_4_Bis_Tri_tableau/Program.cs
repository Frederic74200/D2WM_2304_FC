// See https://aka.ms/new-console-template for more information


int[] tableau = new int[7] { 128, 64, 8, 512, 16, 32, 256 };

// afficher tableau départ
Console.WriteLine("Tableau initial : \n\r");
foreach (int i in tableau)
{
    Console.Write("{0} ", i);
}


#region#GrandeBoucleFor
for (int i= 0; i< tableau.Length; i++)
{
    int tmp = tableau[i];
    int min =0;
    Console.WriteLine("tmp 1  "+tmp+"  ");

    for (int j= i; j< tableau.Length; j++)
    {
        min = tableau[j];   
        if (tableau[j] < min)
        {
            min = tableau[j];
        }
    }
    Console.WriteLine("tmp 2 min 2 " + tmp + "  " + min);
    tableau[i] = min;

    for (int j= i +1; j< tableau.Length; j++)
    {
        if (tableau[j] == min) {
            tableau[i] = tmp;
        }
    }
    Console.WriteLine("tmp 3 min 3 " + tmp + "  " + min);
}
#endregion#GrandeBoucleFor


// afficher tableau final
Console.WriteLine("\n\r Tableau final : \n\r");

foreach (int i in tableau)
{
    Console.Write("{0} ", i);
}


