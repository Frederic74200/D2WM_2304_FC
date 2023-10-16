import { Db } from "Db";


const appUrl = 'https://arfp.github.io/tp/web/html-css-js/03-zipcodes/zipcodes.json';
const { createApp } = Vue;


const postCode = {


    data() {
        return {
            liste: []
        }

    },
    async monted() {
        let json = await Db.fetchDb(appUrl);

        for (let item of json) {
            let c = new Card(item);
            this.cards.push(c);
        }

    },
    methods: {

    }


}

createApp(postCode).mount('#app');



