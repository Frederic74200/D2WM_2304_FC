class Classement {


    constructor(_tableau) {
        this.equipes(_tableau._team1, _tableau._team2);
    }

    equipes(_team1, _team2) {
        let equipe = [];
        equipe.push(_team1);
        equipe.push(_team2)
        return equipe;

    }






}

export { Classement }; 