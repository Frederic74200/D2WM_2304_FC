using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryPersonne
{
    public class Employe : Personne
    {
        private double salaire;


        public Employe(string n, string p, DateTime dn, double s)
     : base(n, p, dn)
        {
            salaire = s;
        }

     ~Employe() { }

        public double GetSalaire
        {
            get => default;
            set
            {
            }
        }

        public override string Afficher()
        {
            return "------------------------------------\n\\r" +
                "Nom : " + base.Nom + "\n\r" +
                  "Prénom : " + base.Prenom + "\n\r" +
                  "Date de naissance  : " + base.DateDeNaissance + "\n\r"+
                  "Salaire  : " + this.salaire.ToString("#,##") + "\n\r"; ;
        }

        /*
        public  Employe Evoluer(Employe emp, string service)
        {
            Chef chf = new Chef(emp.Nom, emp.Prenom, emp.DateDeNaissance, emp.GetSalaire, service);

            

            return chf;
        }
        */



    }
}
