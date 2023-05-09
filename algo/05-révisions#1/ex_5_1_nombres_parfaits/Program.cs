// See https://aka.ms/new-console-template for more information

int[] tableauNombresParfaits = new int[4];
int nombreAdiviser = 2;


#region#RemplirTableau
for (int i = 0; i < tableauNombresParfaits.Length;  i++)
{
    bool nombreParfait = false;
 

    #region#TrouverUnNombreParfait
    do
    {
        int sommeDiviseur = 0;
        #region#TrouverAdditionnerLesDiviseurs
        for (int diviseur = 1; diviseur < nombreAdiviser; diviseur++)
        {
            if (nombreAdiviser % diviseur == 0)
            {
                sommeDiviseur = sommeDiviseur + diviseur;
            }
        }
        #endregion#TrouverAdditionnerLesDiviseurs

        #region#VerifierSiSomme=Nomnre
        if (nombreAdiviser == sommeDiviseur)
        {
            nombreParfait = true;
        }
        else
        {
            nombreAdiviser++;
        }
        #endregion#VerifierSiSomme=Nomnre
    } while (!nombreParfait);
    #endregion#TrouverUnNombreParfait

    if (nombreParfait == true)
    {
        tableauNombresParfaits[i] = nombreAdiviser;
    }

    nombreAdiviser++;
}
#endregion#RemplirTableau


#region#AfficherTableau
Console.WriteLine("Les 4 premiers nombres parfaits sont : ");
foreach(int i in tableauNombresParfaits)
{
    Console.Write("{0} ", i);
}

#endregion#AfficherTableau




