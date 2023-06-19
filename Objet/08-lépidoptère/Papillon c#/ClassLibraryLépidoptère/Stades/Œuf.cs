using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibraryLépidoptère.Stade;

namespace ClassLibraryLépidoptère.Stades
{
    internal class Œuf : Stade
    {
        public Œuf()

        {

        }

        public override string SeDeplacer()
        {
            Deplacement = "Je suis un œuf ! Je ne peux pas me déplacer !";
            return Deplacement;
        }

        public override Stade SeMetamorphoser()
        {
            return new Chenille();
        }
    }
}
