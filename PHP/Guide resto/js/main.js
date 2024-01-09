
import { Db } from "./Db.js";


const urlJson = "../restaurants.json" // url du fichier json 


const guide = {

    data() {
        return {
            guideResto: [],
            toto: 'toto'

        }



    },
    async mounted() {

        this.guideResto = await Db.fetchJson(urlJson);
        console.log(this.guideResto);

    }






}


Vue.createApp(guide).mount("#app");
