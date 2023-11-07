/* App 10000 mètres */

// fichier principal vue.js ------------------------

// importation des classes
import { Db } from "./Db.js";
import { Participant } from "./Participant.js";



const urlJson = "../data/resultats.json" // url du fichier json 


// créer application vue js

const course = {
    data() {
        return {
            donneesCourse: [],// tableau des données issues du fichier json 
            nomGagnant: "", // nom du gagnat 
            prenomGagnant: "", // prenom du gagnat 
            listePays: [], // liste des pays 
            inputPays: [], // pays coché dans le formulaire 
            triParPays: [] // tableau des participants filtrés par pays 
        }
    },
    async mounted() {
        // extraction du json vers le tableau 
        this.donneesCourse = await Db.fetchJson(urlJson);

        // utlisation de la classe Particpants pôur séparer nom et prénom 
        for (let i = 0; i < this.donneesCourse.length; i++) {
            this.donneesCourse[i] = new Participant(this.donneesCourse[i]);
        }

        // trier le tableau par prdre croissant 
        this.donneesCourse.sort((a, b) => a.temps - b.temps);

        // assigner nom gagnat 
        this.nomGagnant = this.donneesCourse[0].nomPartic;

        // assigner nom gagnat 
        this.prenomGagnant = this.donneesCourse[0].prenomPartic;

        // lister les pays sans doulon     
        for (let item of this.donneesCourse) {
            if (!this.listePays.includes(item.pays)) {
                this.listePays.push(item.pays);
            }
        }
        this.listePays.sort();


    },
    computed: {

        /**
         * 
         * @returns {number} nombre de participants 
         */
        nbParticipants() {
            return this.donneesCourse.length;
        }

    },
    methods: {

        /**         
                * filter le tableau par pays et renvoyer un nouveau tableau
                * @returns {Array} tableau filtré         
                */
        trierpPays() {
            this.triParPays = this.donneesCourse.filter(c => this.inputPays.includes(c.pays));
        }

    }
}


// associer script à main id app dans le html
Vue.createApp(course).mount("#app");
