
class Financier {


    constructor() {
        this.capital = 0;
        this.taux = 0.0;
        this.duree = 0;
    }


    // ---------------------------------- petits calculs

    getNombresMois() {
        return this.duree * 12;
    }

    getTauxMensuel() {
        return this.taux / 1200;
    }

    calculerMensualite() {
        let mensualite = 0.0;
        let puissanceNegative = this.getNombresMois * -1;
        mensualite = (this.capital * this.getTauxMensuel / (1 - Math.pow((1 + this.getTauxMensuel), puissanceNegative)));
        return mensualite.toFixed(2);
    }

    amortissment() {
        const tableau = Object.assign({}, {
            numMois: 0,
            capitalRestant: this.capital,
            interets: 0.0,
            partAmort: 0.0
        });


        for (let i = o; i < this.getNombresMois; i++) {

            this.tableau.numMois.push(i);



        }




    }




}
export { Financier }; 