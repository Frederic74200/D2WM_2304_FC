using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    internal class Rectangle
    {



        private double largeur;
        private double longuer;

        public Rectangle(double _largeur, double _longuer)
        {

            try (_largeur > 0)
                {
                this.largeur = _largeur;
            }
                catch (ArgumentException e)
            {
                Console.WriteLine($"Erreur largeur : {e.Message}");
            }


            try (_longuer > 0)
                {
                this.longuer = _longuer;
            }
                catch (ArgumentException e)
            {
                Console.WriteLine($"Erreur Longueur : {e.Message}");
            }




            this.longuer = _longuer;
        }


        public double CalculerAire()
        {
            return this.largeur * this.longuer;
        }

        public bool VerifierCarre()
        {
            return this.largeur == this.longuer ? true : false;
        }

        public double CalculerPerimetre()
        {
            return 2 * this.largeur + 2 * this.longuer;
        }

        public string rectangleToString()
        {
            return "Largeur : " + this.largeur + "\n Longueur : " + this.longuer;
        }

    }
}
