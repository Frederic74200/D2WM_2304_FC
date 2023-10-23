import { Db } from "./Db.js";
import { Flight } from "./Flight.js";


const dayDate = new Date(); 
const flithsUrl = "https://arfp.github.io/tp/web/html-css-js/04-flights/flights.json";
const { createApp } = Vue;


const flightApp = {

data() {

    return { 
        flights : [], 
        compagny : ""
}
},
computed: { 
  /*
 getDuration(_duration) {
       
let minutes =_duration % 60;
let hours = (_duration - minutes) / 60;
return hours.toString() + " : " + (minutes < 10 ? "0" + minutes.toString(): minutes.toString()) + " : 00"; 
}
*/
},
 async mounted() {
    let json = await Db.fetchJson(flithsUrl);
    for(let item of json) {
        let f = new Flight(item);
        this.flights.push(f);
    }

    console.log(this.flights);
},
methods: {


}






}

Vue.createApp(flightApp).mount('#app');



