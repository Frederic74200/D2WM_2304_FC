using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace ex_2_5_bicyclette
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
                       /*
           Console.WriteLine("Fait il beau ?");

           ilFaitBeau = Console.ReadLine() == oui;

           saisie = Console.ReadLine().ToLower();

           ilFaitBeau = saisie == oui;

            Console.WriteLine(ouiNon);

           */

            // VARIABLES ------------------------------------------------------------------------------------------------


            bool ilFaitBeau;
            bool bicycletteOK;
            bool delaiGraragisteOk;
            bool livreGOTdansBibliothequeSalon;
            bool livreGOTaBibliothequeMunicipale;

            String ouiNon;
            char ouiNonChar;
            String oui = "o";
           
            

            bool again;

            // TRAIEMENT -----------------------------------------------------------------------------
            do
            {

                Console.WriteLine("Que vais-je faire demain ? ");

                Console.WriteLine("Est-ce qu'il fera beau demain ? " + "\n\r" +
                                   "Entrez O pour oui ou sur une autre touche pour non");

                ouiNon = Console.ReadLine().ToLower();

                if (ouiNon == "") { ouiNon = "o"; }

                ilFaitBeau = ouiNon == oui;

                ouiNon = "";


                // il fait beau ---------------------------------------
                if (ilFaitBeau)
                {
                    Console.WriteLine("Ma bicyclette est-elle en êtat de fonctionnement ?" + "\n\r" +
                                   "Entrez O pour oui ou sur une autre touche pour non");
                    ouiNon = Console.ReadLine().ToLower();

                    if (ouiNon == "") { ouiNon = "o"; }

                    bicycletteOK = ouiNon == oui;

                    ouiNon = "";


                    if (!bicycletteOK)
                    {
                        Console.WriteLine("J'emmènerai ma bicuclette chez le garagiste." + "\n\r" +
                                           "Le garaististe resparera t-il ma bicuclette immédiatement ?" + "\n\r" +
                                             "Entrez O pour oui ou sur une autre touche pour non");

                        ouiNon = Console.ReadLine().ToLower();

                        if (ouiNon == "") { ouiNon = "o"; }

                        delaiGraragisteOk = ouiNon == oui;

                        ouiNon = "";


                        if (!delaiGraragisteOk)
                        {
                            Console.WriteLine("J’irai à pied jusqu’à l’étang pour cueillir les joncs.");

                        }
                        else
                        {
                            bicycletteOK = true;
                        }
                    }

                    if (bicycletteOK)
                    {
                        Console.WriteLine("J’irai faire une balade à bicyclette.");
                    }
                }


                // il pleut -------------------------------------------------------

                else
                {
                    Console.WriteLine("J’aimerais relire le 1er tome de Game of Thrones." + "\n\r" +
                                       "Le livre Game Of Trhrones se trouve t-il dans la bibliothèque du salon ?" + "\n\r" +
                                       "Entrez O pour oui ou sur une autre touche pour non");

                    ouiNon = Console.ReadLine().ToLower();

                    if (ouiNon == "") { ouiNon = "o"; }

                    livreGOTdansBibliothequeSalon = ouiNon == oui;

                    ouiNon = "";



                    if (!livreGOTdansBibliothequeSalon)
                    {
                        Console.WriteLine("J'irai à la bibliothèque municipale." + "\n\r" +
                                         "Le livre Game Of Trhrones est-il disponible à la bibliothèque municipale ?" + "\n\r" +
                                         "Entrez O pour oui ou sur une autre touche pour non");
                        ouiNon = Console.ReadLine().ToLower();

                        if (ouiNon == "") { ouiNon = "o"; }

                        livreGOTaBibliothequeMunicipale = ouiNon == oui;

                        ouiNon = "";


                        if (!livreGOTaBibliothequeMunicipale)
                        {
                            Console.WriteLine("j’emprunterai un roman policier.");
                            livreGOTdansBibliothequeSalon = true;
                        }
                        else
                        {
                            Console.WriteLine("j’emprunterai le livre Game Of Throne.");
                            livreGOTdansBibliothequeSalon = true;
                        }

                        Console.WriteLine("Je rentrerai ensuite directement à la maison.");
                    }

                    if (livreGOTdansBibliothequeSalon)
                    {
                        Console.WriteLine("Je m’installerai confortablement dans un fauteuil et je me plongerai dans la lecture.");
                    }

                } // fin pluie


                Console.WriteLine("-----------------------------------------------------------------------------" + "\n\r" +
                                   "Souhaitez-vous recommencer ?" + "\n\r" +
                                   "Entrez O pour oui ou sur une autre touche pour non");
                ouiNon = Console.ReadLine().ToLower();
                if (ouiNon == "") { ouiNon = "o"; }

                again = ouiNon == oui;

                ouiNon = "";

            } while (again);
            // FIN TRAITEMENT

            Console.WriteLine("Appuyez sur une touche pour fermer le programme.");
            Console.ReadLine();


            // FIN PROGRAMME 

        }
    }
}