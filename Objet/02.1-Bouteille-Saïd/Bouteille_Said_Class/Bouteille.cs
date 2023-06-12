using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Bouteille_Said_Class
{
    public class Bouteille
    {      

        // attributs -------------------------------------------------------------------------
        private bool bouteilleOuverte;
        private float volumeMaxEnLitres;
        private float volumeActuelEnLitres;
        private string contenuBouteille;


        // accesseurs mutateurs ------------------------------------------------------------------
        public bool BouteilleOuverte { get => bouteilleOuverte; set => bouteilleOuverte = value; }
        public float VolumeMaxEnLitres { get => volumeMaxEnLitres; }
        public float VolumeActuelEnLitres { get => volumeActuelEnLitres; set => volumeActuelEnLitres = value; }
        public string ContenuBouteille { get => contenuBouteille; set => contenuBouteille = value; }


        // constructeurs -------------------------------------------------------------------

        // avec paramètres --
        public Bouteille(bool _bouteilleOuverte, float _volumeMaxEnLitres, float _volumeActuelEnLitres, string _contenuBouteille)
        {
            this.bouteilleOuverte = _bouteilleOuverte;
            this.volumeMaxEnLitres = _volumeMaxEnLitres;
            this.volumeActuelEnLitres = _volumeActuelEnLitres;
            this.contenuBouteille = _contenuBouteille;
        }

        // par défaut --
        public Bouteille() : this(true, 0.5f, 0.2f, "eau")
        {

        }

        // pour cloner --
        public Bouteille(Bouteille BouteilleAcopier) :
            this(BouteilleAcopier.bouteilleOuverte, BouteilleAcopier.volumeMaxEnLitres, BouteilleAcopier.volumeActuelEnLitres, BouteilleAcopier.contenuBouteille)
        {

        }

        // fonctions ----------------------------------------------------------------------

         // ouvrir
         public Boolean Ouvrir()
        {
            if(!this.bouteilleOuverte)
            {
                this.bouteilleOuverte=true;
                return true;
            }
            else
            {
                return false;
            }
        }

        // fermer
        public Boolean Fermer()
        {
            if (this.bouteilleOuverte)
            {
                this.bouteilleOuverte = false;
                return true;
            }
            else
            {
                return false;
            }
        }

        // vider volumeAvider: float
        public Boolean Vider(float volumeAvider)
        {
            if (bouteilleOuverte && volumeAvider < volumeActuelEnLitres && volumeAvider > 0)
            {
                volumeActuelEnLitres-= volumeAvider;
                return true;
            }
            else
            {
                return false;
            }
        }

        // remplir volumeAremplir: float      
        public Boolean Remplir(float volumeAremplir)
        {
            if (bouteilleOuverte && volumeAremplir < (volumeMaxEnLitres - volumeActuelEnLitres) && volumeAremplir > 0) 
            {
                volumeActuelEnLitres += volumeAremplir;
                return true;
            }
            else
            {
                return false;
            }
        }

        // viderTout 
        public Boolean ViderTout()
        {
            if (volumeActuelEnLitres > 0 && bouteilleOuverte)
            {
                volumeActuelEnLitres = 0; 
                return true;  
            }
            else
            {
                return false;
            }
        }

        // remplurTout
        public Boolean RemplirTout()
        {
            if (volumeActuelEnLitres < volumeMaxEnLitres && bouteilleOuverte)
            {
                volumeActuelEnLitres = volumeMaxEnLitres; 
                return true;
            }
            else
            {
                return false;
            }
        }

        // Bouteille to string 
        public String BouteilleToString()
        {
            string bouteilleString = "------------------------------------------ \n\r" +
                              "Contenu bouteille : " + contenuBouteille + "\n\r" +
                             "¿ Est ouverte ? " + bouteilleOuverte + "\n\r" +
                             "Volume maxi litres : " + volumeMaxEnLitres + "\n\r" +
                             "Volume Actuel litres  : " + volumeActuelEnLitres;

            return bouteilleString;
        }

    }
}