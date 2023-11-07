// Classe permettant d'exploiter le fichier json 
class Participant {

    /**
     * Constructeur
     * @param {json} _json fichier des parcipants 
     */
    constructor(_json) {
        this.nomPartic = "";
        this.prenomPartic = "";
        this.pays = "";
        this.temps = 0;
        this.minutes = 0;
        this.secondes = "";
        this.separerNomPrenon(_json.nom);
        this.ajouterTemps(_json.temps);
        this.ajouterPays(_json.pays);
    }


    /**---------------------------------------------------------------------------------------
     *  sépartion du nom et prénom 
     * @param {string} _nom nom et prénom des participants  
     */
    separerNomPrenon(_nom) {

        // contôle validité données 
        if (_nom.match(new RegExp("[A-z_-àâäéèêëîïôùûü]"))) {

            // sépartaion du nom et du prénom
            let nomPrenom = _nom.split(" ");
            // assignation des données 
            this.nomPartic = nomPrenom[0];
            this.prenomPartic = nomPrenom[1]
        }
        else {
            // si données invalides alors erreur 
            throw new Error("Nom ou prénom invalide(s)")
        }
    }



    /**
     *  reafecter le pays au tablau  et controle la validété des données  -------------------------------------------------------
     * @param {String   } _pays pays du particpant
     */

    ajouterPays(_pays) {

        // contôle validité données 
        if (_pays.match(new RegExp("[A-z_-àâäéèêëîïôùûü]"))) {
            // assignation des données 
            this.pays = _pays;
        }
        else {
            // si données invalides alors erreur 
            throw new Error("Nom de pays invalide")
        }
    }


    /**
    *  séparation des minutes et des secondes   -------------------------------------------------------
    * @param {string } _pays pays du particpant
    */
    separerminSec(_temps) {
        let secnd = _temps % 60;
        secnd < 10 ? this.secondes = '0' + secnd : this.secondes = secnd;
        this.minutes = (_temps - (_temps % 60)) / 60;
    }




    /**
  *  reafecter le temps en seconde au tablau  et controle la validété des données ---------------------------------------------------------
  *  utlisation de la fonction de sépartaion des minutes et des secondes avec affectation au tableau 
  * @param {number } _temps temps en secondes   
  */
    ajouterTemps(_temps) {
        // si _temps n'est pas un nombre alors erreur sinon réaffaction à temps 
        if (isNaN(_temps)) {
            throw new Error("Temps  invalide(s)")

        }
        else {
            this.temps = _temps;
            this.separerminSec(_temps);
        }
    }

}
export { Participant }; 