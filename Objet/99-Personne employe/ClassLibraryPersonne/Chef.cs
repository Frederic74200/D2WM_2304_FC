using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPersonne
{
    public class Chef : Employe
    {
        private string service;

        public string Service { get => service; set => service = value; }

        public Chef(string n, string p, DateTime dn, double s, string _service)
            :base(n, p, dn,s)
        {
            Service = _service;
            
        }
        public override string Afficher()
        {
            return base.Afficher()+
                  "Service  : " + this.service + "\n\r";
        }


    }
}
