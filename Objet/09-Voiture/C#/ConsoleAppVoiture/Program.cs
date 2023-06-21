using ClassLibraryVoiture;

Console.WriteLine(" V1 Etat initial!");

Voiture v1 = new Voiture();
Console.WriteLine(v1.voitureToString());
v1.DemarrerLeMoteur();
v1.Avancer();

Console.WriteLine(" V1 Demarrer moteur, Avancer!");
Console.WriteLine(v1.voitureToString());

Console.WriteLine("V1 Freiner!");
v1.Freiner();
Console.WriteLine(v1.voitureToString());


// -------------------------------


Console.WriteLine("Hello, World!");

// Voiture v2 = new Voiture(new Moteur(true), );
