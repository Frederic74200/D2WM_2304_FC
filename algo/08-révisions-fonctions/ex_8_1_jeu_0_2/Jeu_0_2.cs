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

        public int NombreOrdi()
        {
            this.nombreOrdi = new Random().Next(3);
            return this.nombreOrdi;
        }



        public Boolean verificationSaisie(string saisieUtilisateur)
        {
            int chiffreJeuHumain;


            if (saisieUtilisateur == null)
            {
                return false;
            }
            else if (int.TryParse(saisieUtilisateur, out chiffreJeuHumain))
            {

                this.nombreHumain = chiffreJeuHumain;


                if (this.nombreHumain > 2)
                {
                    return false;
                    Console.WriteLine("Erreur siaise ! recommencez !");
                }
                else
                {
                    return true;
                }

            }
            else
            {
                return false;
            }
        }

        public Boolean quitterJeu(int siaiseNegative)
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


        public Boolean scoreAtteint()
        {
            if (this.scoreHumain == 10 || this.scoreOrdi == 10)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

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
                        this.scoreHumain++;
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
                    Console.WriteLine("erreur ! !");
                    break;
            }
        }


        public void affichageApresJeu()
        {

            if (this.scoreHumain == 10)
            {
                Console.WriteLine("Bavo ! Vous Avez gaggné ! \n\r" +
                                   "Votre sore : " + this.scoreHumain + "\n\r" +
                                   "Score de l'ordinateur : " + this.scoreOrdi);
            }
            else if (this.scoreOrdi == 10)
            {
                Console.WriteLine("L'ordinateur a gaggné ! \n\r" +
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
