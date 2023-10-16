

class GetNow {

    /**
    * constructeur
    * date et heure courantes 
    */
    constructor() {

        this.moment = new Date;
    }

    getDate() {
        return moment.toLocaleDateString("fr");
    }

    getTime() {
        return this.moment.toTimeString(); 
    }
}





