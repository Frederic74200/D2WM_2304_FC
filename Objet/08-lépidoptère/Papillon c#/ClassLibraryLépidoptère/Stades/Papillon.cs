using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibraryLépidoptère.Stade;


namespace ClassLibraryLépidoptère.Stades
{
    internal class Papillon : Stade
    {
        public Papillon()
        {

        }

        public override string SeDeplacer()
        {
            Deplacement = "Je suis un papillon ! Je Vole !";
            return Deplacement;
        }

        public override Stade SeMetamorphoser()
        {
            return this;
        }

    }
}
