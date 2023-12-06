class Resto {

    constructor(_json) {
        this.id = _json.id;
        this.nom = _json.nom;
        this.adresse = _json.adresse;
        this.prix = _json.prix;
        this.commentaire = _json.commentaire;
        this.note = _json.note;
        this.visite = _json.visite;
    }

}

export { Resto }; 