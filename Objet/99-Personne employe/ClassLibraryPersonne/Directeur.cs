using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPersonne
{
    public class Directeur : Chef
    {
        private string societe;

        public Directeur(string n, string p, DateTime dn, double s, string _service, string _societe)
            : base(n, p, dn, s, _service)
        {
           societe = _societe;

        }

        public override string Afficher()
        {
            return base.Afficher() +
                  "Société : " + this.societe + "\n\r";
        }

    }
}
