import { Db } from "./Db.js";
// import { CodPost } from "./CodPost.js";
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
        this.liste = await Db.fetchDb(appUrl);

       
        

    },
    methods: {



    }


}

createApp(postCode).mount('#app');



