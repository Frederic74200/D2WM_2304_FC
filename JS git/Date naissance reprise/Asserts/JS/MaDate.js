

class MaDate {

    /**
     * Constructeur 
     * @param {Date} _date date de naissance 
     */
    constructor(_date) {
        this.dateJour = new Date();
        this.dateNaissance = _date;
    };

    /**
     * Fonction verification date dans le passé       
     * @returns {boolean} vrai si dans passé 
     */
    estDansLePasse() {
        return this.dateNaissance < this.dateJour;
    }

    /**
     * Fonction calcul nombre années depuis la naissance 
     * @returns {number} nombre d'années depuis la naissance 
     */
    calculAns() {
        let diff = this.dateJour - this.dateNaissance;
        diff = diff / 1000 / 3600 / 24 / 365;
        diff = parseInt(diff);
        return diff;
    }

    /**
     * Fonction calculsigne astro
     * @returns {string} signe astro 
     */
    calculerSigne() {
        let mois = this.dateNaissance.getMonth() * 100;
        let jour = this.dateNaissance.getDate();
        let total = mois + jour;


        const signAsttro = ["Capricorne", "Verseau", "Poisson", "Belier", "Taureau", "Gémeaux", "Cancer", "Lion", "Vierge", "Balance", "Scorpion", "Sagittaire", "Capricorne"];



        /*
                const numAsttro = ["Capricorne", "Verseau", "Poisson", "Belier", "Taureau", "Gémeaux", "Cancer", "Lion", "Vierge", "Balance", "Scorpion", "Sagittaire", "Capricorne"];
        
        
        
        */

    }

};

/*
var obj = {key1: ["val1", "val2", "val3"], key2: "value2"};

const date = new Date();

const year = date.getFullYear();
const month = date.getMonth() + 1;
const day = date.getDate();

const withSlashes = [year, month, day].join('/');
console.log(withSlashes); // 👉️ "2023/7/25"

const withHyphens = [year, month, day].join('-');
console.log(withHyphens); // 👉️ "2023-7-25"



   let date = new Date();
       let mois = date.getMonth() *100;
       let jour = date.getDate();
       let total = mois + jour;
       console.log(total); 
*/