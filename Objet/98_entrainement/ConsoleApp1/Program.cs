// See https://aka.ms/new-console-template for more information



using ConsoleApp1;

Console.WriteLine("Hello, World!");
//---------------------------------------------------------------
string prenom = "Fred";

int nb = 1;

if (nb == 1 )
{
    Console.WriteLine(prenom);

}
else
{
    Console.WriteLine("Raté !"); 
}


//----------------------------------------------



Rectangle rtg = new Rectangle(3.5, 3.5);
Rectangle rtg2 = new(-3, -7); 

double aire = rtg.CalculerAire();
Console.WriteLine(aire+"\n");
bool carre = rtg.VerifierCarre();
Console.WriteLine(carre + "\n");
double perim = rtg.CalculerPerimetre();
Console.WriteLine(perim + "\n");

rtg2.rectangleToString();


