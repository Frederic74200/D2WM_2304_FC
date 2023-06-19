using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClassLibraryLépidoptère.Stade;


namespace ClassLibraryLépidoptère.Stades
{
    internal class Chrysalide : Stade
    {
         public Chrysalide()
        {

        }

        public override string SeDeplacer()
        {
            Deplacement = "Je suis une chysalide ! Je ne peux pas me déplacer !";
            return Deplacement;
        }

        public override Stade SeMetamorphoser()
        {
            return new Papillon();
        }
    }
}
