import { Db } from "./Db.js";




const flithsUrl = "https://arfp.github.io/tp/web/html-css-js/04-flights/flights.json";
const { createApp } = Vue;


const flightApp = {

data() {

    return { 
        flights : [], 
        airline : "",
        results : []
}
}

,
 async mounted() {
    this.flights = await Db.fetchJson(flithsUrl);
   
      
  
},
methods: {

    getDuration(_duration) {  
    
     let minutes =_duration % 60;
     let hours = (_duration - minutes) / 60;
     
    return hours + " : " + (minutes < 10 ? "0" + minutes : minutes) + " : 00"; 
     },

    byAirline() {
        this.results = this.flights.filter( flight => flight.airline_name  == this.airline); 
    console.log("ok");
         }
       

}
,
computed: { 
   
    
}


}

Vue.createApp(flightApp).mount('#app');



