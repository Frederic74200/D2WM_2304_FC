using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouteille
{
    public class BouteilleClass
    {

        // Attributs  ---------------------------------------------------------------

        private  string nomBouteille;
        private  bool estOuverte;
        private  uint capaciteMaxiCentilitres;
        private  uint qantiteLiquidePresentCl;
        public static uint nombreBouteillesInstenciees = 0; 

        // Constructeurs ---------------------------------------------------------

        // par défaut
        public BouteilleClass()
        {
            nomBouteille = "Bouteille en verre pour jus de fruit";
            estOuverte = false;
            capaciteMaxiCentilitres = 100;
            qantiteLiquidePresentCl = 0;
            nombreBouteillesInstenciees++;
        }

        // avec paramètres 
        public BouteilleClass(string _nomBouteille, bool _estOuverte, uint _capaciteMaxiCentilitres, uint _qantiteLiquidePresentCl)
        {
            nomBouteille = _nomBouteille;
            estOuverte = _estOuverte;
            capaciteMaxiCentilitres = _capaciteMaxiCentilitres;
            qantiteLiquidePresentCl = _qantiteLiquidePresentCl;
            nombreBouteillesInstenciees++;
        }


        //   fonctions ------------------------------------------------------------


        // + AfficherEtatBouteille() : void
        public  void AfficherEtatBouteille()
        {
            Console.WriteLine("------------------------------------------ \n\r" +                                 
                                "Nom bouteille : " + nomBouteille + "\n\r" +
                               "Est ouverte ? " + estOuverte + "\n\r" +
                               "Capacité maxi cl : " + capaciteMaxiCentilitres + "\n\r" +
                               "Quantité présente dans bouteille : " + qantiteLiquidePresentCl); ;
        }

        // + OuvrirLaBouteille() : bool
        public  bool OuvrirLaBouteille()
        {
            if (!estOuverte)
            {
                estOuverte = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        // + FermerLaBouteille() : bool
        public  bool FermerLaBouteille()
        {
            if (estOuverte)
            {
                estOuverte = false;

                return true;
            }
            else
            {
                return false;
            }

        }

        // - vider()
        private bool PossibiliteDVider()
        {
            if (qantiteLiquidePresentCl > 0 && estOuverte)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // - Remplir() 
        private bool PossibiliteDeRemplir()
        {
            if (qantiteLiquidePresentCl < capaciteMaxiCentilitres && estOuverte)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // + RetirerQuantiteChoisieLiquide() : uint
        public uint RetirerQuantiteChoisieLiquide(uint volumeAretirer)
        {
            if (PossibiliteDVider() == true &&  volumeAretirer <= qantiteLiquidePresentCl)
                {
                    qantiteLiquidePresentCl -= volumeAretirer;
                }
            else
            {
                Console.WriteLine(" Valuer incorrecte ! ");
            }
            return qantiteLiquidePresentCl;
        }

        // + AjouterQuantiteChoisieLiquide() : uint
        public uint AjouterQuantiteChoisieLiquide(uint volumeAajouter)
        {
            if (PossibiliteDeRemplir() == true && volumeAajouter <= capaciteMaxiCentilitres - qantiteLiquidePresentCl)
            {
                qantiteLiquidePresentCl += volumeAajouter;
            }
            else
            {
                Console.WriteLine(" Valuer incorrecte ! ");
            }
            return qantiteLiquidePresentCl;
        }

        // + ViderTout() : bool
        public bool ViderTout()
        {
          if (PossibiliteDVider() == true)
            {
                qantiteLiquidePresentCl = 0;
                return true;
            }
          else
            {
                return false ;
            }
        }

        // + RemplirTout() : bool
        public bool RemplirTout()
        {
            if(PossibiliteDeRemplir() == true)
            {
                qantiteLiquidePresentCl = capaciteMaxiCentilitres;  
                return true;
            }
            else
            {
                return false; 
            }
        }


    }
}
