using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibraryLépidoptère.Stade;


namespace ClassLibraryLépidoptère.Stades
{
    internal class Chenille : Stade
    {
        public Chenille()
        {

        }

        public override string SeDeplacer()
        {
            Deplacement = "Je suis une chenille ! Je rampe !";
            return Deplacement;
        }

        public override Stade SeMetamorphoser()
        {
            return new Chrysalide();
        }
    }
}
