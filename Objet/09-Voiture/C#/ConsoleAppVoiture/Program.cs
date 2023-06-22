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





Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////");

Voiture v2 = new Voiture(new Moteur(true), false, "VW" );

Console.WriteLine(" V2 Etat initial!");
Console.WriteLine(v2.voitureToString());
v2.DemarrerLeMoteur();
v2.Avancer();

Console.WriteLine(" V2 Demarrer moteur, Avancer!");
Console.WriteLine(v2.voitureToString());

Console.WriteLine("V2 Freiner!");
v2.Freiner();
Console.WriteLine(v2.voitureToString());


Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////");

Voiture v3 = new Voiture(v2);

Console.WriteLine(" v3 Etat initial!");
Console.WriteLine(v3.voitureToString());
v3.DemarrerLeMoteur();
v3.Avancer();

Console.WriteLine(" V3 Demarrer moteur, Avancer!");
Console.WriteLine(v3.voitureToString());

Console.WriteLine("V3 Freiner!");
v3.Freiner();
Console.WriteLine(v3.voitureToString());






