
import { Db } from "./Db.js";
import { Resto } from "./Resto.js";

const urlJson = "./data/restaurants.json" // url du fichier json 


const guide = {

    data() {
        return {
            guideResto: [],
            toto: 'toto'


        }



    },
    async mounted() {

        let json = await Db.fetchJson(urlJson);
        console.log(json);


        for (let item of json) {

            this.guideResto.push(new Resto(item));
        }


        console.log(this.guideResto);

    }






}


Vue.createApp(guide).mount("#app");
