namespace ClassLibraryCompteBanquaire
{
    public class CompteBanquaire
    {

        // Attributs ---------------------------------------------------------------------------------
        int numeroDeCompte;
        string nomPropriétaireCompte;
        double solde;
        double decouvertAutorise;

        public double Solde { get => solde; set => solde = value; }


        // Constructeurs ----------------------------------------------------------------------------
        public CompteBanquaire(int _numeroDeCompte, string _nomPropriétaireCompte, double _solde,  double _decouvertAutorise)
        {
            this.numeroDeCompte = _numeroDeCompte;
            this.nomPropriétaireCompte = _nomPropriétaireCompte;
            this.solde = _solde;
            this.decouvertAutorise = _decouvertAutorise;          
        }

        public CompteBanquaire():this(0, "", 0,0) { }

        public CompteBanquaire(CompteBanquaire CompteADupliquer): 
            this(CompteADupliquer.numeroDeCompte, CompteADupliquer.nomPropriétaireCompte, CompteADupliquer.solde, CompteADupliquer.decouvertAutorise)
        { }


        // fonctions --------------------------------------------------------------------------------

        // CompteToString
        public string CompteToString()
        {
            string CompteToString = "N° compte : " + numeroDeCompte.ToString() + "\n\r" +
                                    "Nom Propriétaire : " + nomPropriétaireCompte + "\n\r" +
                                    "Solde Actuel : " + solde.ToString() + "\n\r" +
                                    "Découvert autorisé : " + decouvertAutorise.ToString() + "\n\r";
            return CompteToString;
        }

        // overirde ToString
        public override string ToString()
        {
            return "N° compte : " + numeroDeCompte.ToString() + "\n\r" +
                                    "Nom Propriétaire : " + nomPropriétaireCompte + "\n\r" +
                                    "Solde Actuel : " + solde.ToString() + "\n\r" +
                                    "Découvert autorisé : " + decouvertAutorise.ToString() + "\n\r";
          
        }

        // CrediterUnMontant 
        public void CrediterUnMontant(double montantAcrediter)
        {
            solde += montantAcrediter; 
        }

        // DebiterUnMontant
        public bool DebiterUnMontant(double montantAdebiter)
        {
            if (montantAdebiter < solde - decouvertAutorise)
            {
                solde -= montantAdebiter; 
                return true;
            }
            else 
            {
                return false; 
            }
        }

        // TransfererMontantVersAutreCompte
        public bool TransfererMontantVersAutreCompte(CompteBanquaire compteDeDestination, double montantAtransferer)
        {
            bool debitok = DebiterUnMontant(montantAtransferer); 

            if(debitok)
            {
                compteDeDestination.CrediterUnMontant(montantAtransferer); 

                return true;
            }
            else
            {
                return false; 
            }
        }

        // SoldeCompteSuperieurAunAutreCompte

        public bool SoldeCompteSuperieurAunAutreCompte(CompteBanquaire compteAcomparer)
        {

            double soldeAutreCompte = compteAcomparer.Solde;

            if (soldeAutreCompte < this.solde)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}