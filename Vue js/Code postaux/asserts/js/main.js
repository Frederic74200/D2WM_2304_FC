import { Db } from "./Db.js";
import { CodPost } from "./CodPost.js";
import { Recherche } from "./Recherche.js";



const appUrl = 'https://arfp.github.io/tp/web/html-css-js/03-zipcodes/zipcodes.json';
const { createApp } = Vue;


const postCode = {


    data() {
        return {
            liste: [],
            myInput: "",
            myOutput: ""
        }

    },
    async monted() {
        let json = await Db.fetchDb(appUrl);

        for (let item of json) {
            let c = new CodPost(item);
            this.liste.push(c);
        }
        console.log(this.liste);
        this.myOutput = Recherche.RechercheCp(myInput, liste.codePostal, liste.nomCommune);
        console.log(this.myOutput);



    },
    methods: {

    }


}

createApp(postCode).mount('#app');



