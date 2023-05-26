using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ex_8_3_Jeu_Du_Pendu
{
    internal class JeuDuPendu
    {

        // Attributs --------------------------------------------------------------------------
        private string motAtrouver;
        private List<char> motAvecTirets;
        private char lettreSaisie;
        private string lettresDejaJouees = "";
    
        private int nombreMiniCharMot;

        private int nombreMaxiEssais;

        

        // Constructeurs -----------------------------------------------------------------------

        // Par défaut
        public JeuDuPendu()
        {
            this.nombreMaxiEssais = 6;
            this.nombreMiniCharMot = 5;
        }

        // Avec paramètres 
        public JeuDuPendu(int _nombreMaxiEssais, int _nombreMiniCharMot)
        {
            this.nombreMaxiEssais = _nombreMaxiEssais;
            this.nombreMiniCharMot = _nombreMiniCharMot;
        }



        // Fonctions ----------------------------------------------------------------------------

        // Saisie mot à trouver et vérification + transformation mot avec tirets

        private void saisieMotAtrouver()
        {
            bool saisieOk = false;

            #region#VerificationSaisie
            do
            {
                Console.WriteLine("Saisissez le mot à deviner : ");
                string? saisie = Console.ReadLine();


                if (saisie != null)
                {
                    if (Regex.IsMatch(saisie, @"^[a-zA-Z]+$") == true) // si saisie ne contient que des lettres
                    {

                        if (saisie.Length >= this.nombreMiniCharMot) // si nombre de lettres du mot sup ou égal à minimum requis
                        {
                            this.motAtrouver = saisie.ToUpper(); // saisie devient mot à trouver en majuscules
                            saisieOk = true;
                        }
                        else
                        {
                            Console.WriteLine("Erreur saisie !");
                            saisieOk = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Erreur saisie !");
                        saisieOk = false;
                    }
                }
                else
                {
                    Console.WriteLine("Erreur saisie !");
                    saisieOk = false;
                }
            }while (!saisieOk);
            #endregion#VerificationSaisie

            Console.Clear();


            #region#remplacerLettresParTirets
            this.motAvecTirets = new List<char>();

            for (int i = 0; i < this.motAtrouver.Length; i++)
            {
                if (i == 0)
                {
                    this.motAvecTirets.Add(this.motAtrouver[i]);
                }
                else if (i < this.motAtrouver.Length - 1)
                {
                    this.motAvecTirets.Add('-');
                }
                else
                {
                    this.motAvecTirets.Add(this.motAtrouver[i]);
                }
            }
            #endregion#remplacerLettresParTirets
 
        }


        // affichage mot avec tirets

        private string motAvecTiretsToString()
        {
            string motTiretsString = "";
            
            for (int i = 0; i < this.motAvecTirets.Count; i++)
            {
                motTiretsString += motAvecTirets[i].ToString();
            }

            return motTiretsString;
        }


        // siaise lettre + recherche lettre + compteur essais

        private void saisieLettreJouee()
        {
            bool saisieOk = false;

            #region#VerificationSaisie
            do
            {
                Console.WriteLine("-----------------------------------------------------------------------  \n\r"+
                                    "Il vous reste : " + this.nombreMaxiEssais + " essais \n\r" +
                                    "Les lettres que vous avez déjà joué : " + lettresDejaJouees + "\n\r" +
                                    "Mot à deviner : " + motAvecTiretsToString() + "\n\r" +
                                    "Quelle lettre voulez-vous jouée ? ");
                string? saisie = Console.ReadLine();

                string temp;

                if (saisie != null)
                {
                    if (Regex.IsMatch(saisie, @"^[a-zA-Z]+$") == true) // si saisie est effectivement une lettre
                    {
                        temp = saisie.ToUpper(); // lettre saisie en majuscule
                        this.lettreSaisie = char.Parse(temp); // Conversion lettre en char 
                        saisieOk = true;
                    }
                    else
                    {
                        Console.WriteLine("Erreur saisie !");
                        saisieOk = false;
                    }
                }
                else
                {
                    Console.WriteLine("Erreur saisie !");
                    saisieOk = false;
                }
            } while (!saisieOk);
            #endregion#VerificationSaisie



            #region#rechercherLettreDansMot
            int lettretrouvee = 0;

            for (int j = 1; j < this.motAtrouver.Length - 1; j++)
            {
                if (this.lettreSaisie == this.motAtrouver[j])
                {
                    lettretrouvee++;
                    motAvecTirets[j] = lettreSaisie;
                }
            }

            if (lettretrouvee == 0)
            {
                this.nombreMaxiEssais--;
                Console.WriteLine("La lettre : " + Convert.ToString(this.lettreSaisie) + " n'est pas dans le mot.");
            }

            this.lettresDejaJouees += " " + Convert.ToString(this.lettreSaisie);
            #endregion#rechercherLettreDansMot
        }




        // /---------------------------------------------------------------------------------------------

        // Verifier s'il reste des tirets

        private bool verifierResteDesTirets()
        {
            //bool tiret = false;
            for (int i = 0; i < this.motAvecTirets.Count; i++)
            {
                if (this.motAvecTirets[i] == '-')
                {
                    //tiret = true;
                    return true;
                }
            }
           
                Console.WriteLine("Bravo ! Vous avez gagné en : " + nombreMaxiEssais+"\n\r"+
                                   "Le mot recherché était : "+this.motAtrouver);
                return false;
            
        }

        // gagné ou perdu 

        private bool verifierSiPerdu()
        {
            if (this.nombreMaxiEssais == 0)
            {
                Console.WriteLine("Vous avez perdu ! \n\r" +
                                   "Le mot à trouver était : " + this.motAtrouver);
                return true;
            }
            else
            {
                return false;
            }

        }


        // Jouer au pendu ---------------------------------------------------------------------------

        public void jouerAuPendu()
        {
            saisieMotAtrouver();

            bool resteDesTirets = true;
            bool perdu = false;

            do
            {
                saisieLettreJouee();

                resteDesTirets = verifierResteDesTirets();
                perdu = verifierSiPerdu();



            } while (resteDesTirets && !perdu);


        }

    }
}
