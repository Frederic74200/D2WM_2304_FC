// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

/*
int[] tableau = new int[] { 128, 64, 8, 512, 16, 32, 256 };


int tmp = tableau[0];
*/


// List<int> tableau1 = new tableau1<int>(128, 64, 8, 512, 16, 32, 256);


int[] tableau = new int[] { 128, 64, 8, 512, 16, 32, 256 };

List<int> list = new List<int>();
List<int> list2 = new List<int>();

for (int i = 0; i < tableau.Length; i++)
{
    list.Add(tableau[i]);
}


foreach (int i in list)
{
    Console.Write("{0} ", i);
}

int fin = list.Count;

// ----------------------------------------------------------------------------------------------------------------------------------


for (int j = 0; j < fin; j++)
{

    int tmp = list[0];



    for (int i = 0; i < list.Count; i++)
    {
        

        Console.WriteLine("tmp  tmp = list[j]; " + tmp);

        if (list[i] < tmp)
        {
            tmp = list[i];
            Console.WriteLine("tmp  tmp = list[i]; " + tmp);
        }
    }

    Console.WriteLine(" sortie boucle  ; " + tmp);



    list2.Insert(j, tmp);





    for (int i = 0; i < list.Count; i++)
    {


        if (list[i] == tmp)
        {
            list.RemoveAt(i);
        }
    }

   

}

foreach (int i in list2) // affichage
{
    Console.Write("{0} ", i );
}


Console.WriteLine("_______________________________________________________________");
foreach (int i in list) // affichage
{
    Console.Write("{0} ", i);
}

/*
for (int i = 0; i < tableau.Length; i++)
{
   if (tableau[i] < tmp)
    {
        tmp = tableau[i];
    }

   
}
Console.WriteLine("tmp = "+tmp);

*/
