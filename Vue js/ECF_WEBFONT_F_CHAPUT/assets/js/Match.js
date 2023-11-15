// classe permétant de traiter les données du json afin de les adapter à l'attente de l'application


class Match {
    /**
       * Constructeur
       * @param {json} _json fichier du tournoi 
       */
    constructor(_json) {
        this.team1 = _json.team1;
        this.team2 = _json.team2;
        this.score1 = _json.score[0];
        this.score2 = _json.score[1];
        this.gagnant1 = "";
        this.gagnant2 = "";
        this.trouverGagantsMatchs(_json.team1, _json.team2, _json.score[0], _json.score[1]);
    }

    /**
      * Déterminer les gagnants par matchs 
      * @param {String, String, String} equipe1_equipe2_scoreMatch équipes participantes et résultat du match 
      */
    trouverGagantsMatchs(equipe1, equipe2, scoreMatch1, scoreMatch2) {
        // séparer les scores des matchs 
        let score1 = scoreMatch1.split('-');
        let score2 = scoreMatch2.split('-');

        // déterminer les gagnants 
        score1[0] > score1[1] ? this.gagnant1 = equipe1 : this.gagnant1 = equipe2;
        score2[0] > score2[1] ? this.gagnant2 = equipe1 : this.gagnant2 = equipe2;
    }

}

export { Match };