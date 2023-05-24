using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ex_8_1_jeu_0_2
{
    internal class Jeu_0_2
    {

        // attributs  -------------------------------------------------------------------------------------

        private int nombreHumain;
        private int nombreOrdi;

        private int scoreHumain;
        private int scoreOrdi;
        private int scroreAatteindre;

        public int ScroreHumain { get => scoreHumain; set => scoreHumain = value; }
      


        // constructeurs  --------------------------------------------------------------------------------


        // par défaut
        public Jeu_0_2()
        {
            this.ScroreHumain = 0;
            this.scoreOrdi = 0;
            this.scroreAatteindre = 10;
        }

        // avec paramètres 

        public Jeu_0_2(int _scoreHumain, int _scroreOrdi, int _scoreAatteindre)
        {
            this.ScroreHumain = _scoreHumain;
            this.scoreOrdi = _scroreOrdi;
            this.scroreAatteindre = _scoreAatteindre;
        }



        // get -------------------------------------------------------------------------------------------

        public int getScroreHumain()
        {
            return this.scoreHumain;
        }

        public int getScoreOrdi()
        {
            return this.scoreOrdi;
        }


        public int getNombreHumain()
        {
            return this.nombreHumain;
        }


        // fonctions --------------------------------------------------------------------------------------------
        //modifieur pour nombre ordinateur
        public int setNombreOrdi()
        {
            this.nombreOrdi = new Random().Next(3);
            return this.nombreOrdi;
        }


        // verification valeur numerique et <3 et non vide
        public bool verificationSaisie(string saisieUtilisateur)
        {
            int chiffreJeuHumain;


            if (saisieUtilisateur == null)
            {
                Console.WriteLine("Erreur saisie ! recommencez !");
                return false;
            }
            else if (int.TryParse(saisieUtilisateur, out chiffreJeuHumain))
            {

                this.nombreHumain = chiffreJeuHumain;


                if (this.nombreHumain > 2)
                {
                    return false;
                    Console.WriteLine("Erreur saisie ! recommencez !");
                }
                else
                {
                    return true;
                }

            }
            else
            {
                Console.WriteLine("Erreur saisie ! recommencez !");
                return false;
            }
        }


        // quitter le  jeu avant son terme par volonté joueur
        public bool quitterJeu(int siaiseNegative)
        {
            if (siaiseNegative >= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        // quitter  le  jeu score maxi atteint machine ou joueur
        public bool scoreAtteint()
        {
            if (this.scoreHumain == this.scroreAatteindre || this.scoreOrdi == this.scroreAatteindre)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // phase dde jeu avec incrémentation des scores
        public void phaseDeJeu()
        {

            int diff = Math.Abs(this.nombreOrdi - this.nombreHumain);

            switch (diff)
            {
                case 2:
                    if (this.nombreHumain > this.nombreOrdi)
                    {
                        this.scoreHumain++;
                    }
                    else
                    {
                        this.scoreOrdi++;
                    }
                    break;

                case 1:

                    if (this.nombreHumain > this.nombreOrdi)
                    {
                        this.scoreOrdi++;
                    }
                    else
                    {
                        this.scoreHumain++;
                    }
                    break;

                case 0:
                    Console.WriteLine("Egalité ! Pas de points marqués !");
                    break;

                default:
                    Console.WriteLine("erreur !");
                    break;
            }
        }

        // affichage du résultat final 
        public void affichageApresJeu()
        {

            if (this.scoreHumain == this.scroreAatteindre)
            {
                Console.WriteLine("Bavo ! Vous Avez gagné ! \n\r" +
                                   "Votre sore : " + this.scoreHumain + "\n\r" +
                                   "Score de l'ordinateur : " + this.scoreOrdi);
            }
            else if (this.scoreOrdi == this.scroreAatteindre)
            {
                Console.WriteLine("L'ordi. gagne  essai encore! \n\r" +
                                   "Votre sore : " + this.scoreHumain + "\n\r" +
                                   "Score de l'ordinateur : " + this.scoreOrdi);
            }

            else
            {
                Console.WriteLine("Vous avez quitté le jeu.");
            }

        }


    }
}
