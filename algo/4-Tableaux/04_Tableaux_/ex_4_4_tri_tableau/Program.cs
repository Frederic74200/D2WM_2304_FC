// See https://aka.ms/new-console-template for more information


// Déclarer tableau départ 
int[] tableauDepart = new int[] { 128, 64, 8, 512, 16, 32, 256 };

// Déclarer 2 tableaux dynamyques
List<int> tableau1 = new List<int>();
List<int> tableau2 = new List<int>();


// remplir le 1er tableaux dynamique avec le tableau statique
for (int i = 0; i < tableauDepart.Length; i++)
{
    tableau1.Add(tableauDepart[i]);
}

// afficher 1er tableau dynamique
Console.WriteLine("Tableau initial : \n\r");
foreach (int i in tableau1)
{
    Console.Write("{0} ", i);
}



// déterminer longeur 2ème tableau dynamique
int longueurTableau2 = tableau1.Count;

// grande boucle pour remplir le 2ème tableaux dynamique

for (int i = 0; i < longueurTableau2; i++)
{
    // extraire le premier nombre du tableau 1 à comparer dans une variable temporaire
    int tmp = tableau1[0];

    // Bocle pour extraire la valeur minimun restante dans le 1er tableau dynamique
    for (int j = 1; j < tableau1.Count; j++)
    {
        if (tableau1[j] < tmp)
        {
            tmp = tableau1[j];
        }
    }

    // ajouter le nombre minmun extrait au deuxième tableau dynamique
    tableau2.Insert(i, tmp);

    // retirer le nombre extrait du 1er tableau
    for (int j = 1; j < tableau1.Count; j++)
    {
        if (tableau1[j] == tmp)
        {
            tableau1.RemoveAt(j);
        }
    }
}

// afficher 2ème tableau dynamique
Console.WriteLine("\n\r Tableau final : \n\r");
foreach (int i in tableau2)
{
    Console.Write("{0} ", i);
}
