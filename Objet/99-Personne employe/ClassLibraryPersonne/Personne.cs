
namespace ClassLibraryPersonne
{
    public abstract class Personne
    {
        private string nom;
        private string prenom;
        private System.DateTime dateDeNaissance;

        public Personne(string _nom, string _prenom, System.DateTime _dateDeNaissance)
        {
            this.Nom = _nom;    
            this.Prenom = _prenom;
            this.DateDeNaissance = _dateDeNaissance;
        }

       
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateDeNaissance { get => dateDeNaissance; set => dateDeNaissance = value; }

        public abstract string Afficher();

        public abstract Personne Evoluer(); 


    }
}