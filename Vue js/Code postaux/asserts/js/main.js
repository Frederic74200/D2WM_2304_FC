import { Db } from "./Db.js";
import { CodPost } from "./CodPost.js";
import { Recherche } from "./Recherche.js";
import { VerifNb } from "./VerifNb.js";




const appUrl = "https://arfp.github.io/tp/web/html-css-js/03-zipcodes/zipcodes.json";
// const appUrl = "./zipcodes.json";
const { createApp } = Vue;


const postCode = {


    data() {
        return {
            liste: [],
            myInput: "",
            myOutput: "",
            test: ""

        }

    },
    async mounted() {
        let json = await Db.fetchDb(appUrl);

        for (let item of json) {
            let c = new CodPost(item);
            this.liste.push(c);
        }

        let verif = new VerifNb();
        this.test = verif.verifNb(this.myInput);



        /*
                let recherche = new Recherche();
                this.myOutput = recherche.rechercheCP(this.myInput, this.liste.codePostal, this.liste.nomCommune);
                console.log(this.myOutput);
        
        */

    },
    methods: {



    }


}

createApp(postCode).mount('#app');



