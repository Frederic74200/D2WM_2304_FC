using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ClassLibraryLépidoptère
{
    public abstract class Stade
    {
        private string deplacement; 
               

        // accesseurs mutateurs 
        public string Deplacement { get => deplacement; set => deplacement = value; }

        // Fonctions

        public abstract string SeDeplacer();

        public abstract Stade SeMetamorphoser();


    }
}
