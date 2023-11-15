/* Football APP */

// importation de classes 
import { Db } from "./Db.js";
import { Match } from "./Match.js";
// import { Classement } from "./Classement.js";

// url du fichier json 
const urlJson = './tournoi/football.json'


const appFootball = {
    data() {
        return {
            tournoiSource: [], // tableau conteant les données d'origine du json
            tournoi: [], // tableau exploité dans l'application 
            equipes: [], // tableau des équipes participantes sans doulon afin de déterminer le nombre d'équipes ayant participer au tournoi
            recherche: "",// récupération de la saisie du input de recherche 
            classement: []
        }
    },
    async mounted() {
        // charger le fichier json de façon asynchrone pour ne pas bloquer le programme 
        let json = await Db.fetchJson(urlJson);

        // affectation des données du json au tableau source
        for (let item of json) {
            this.tournoiSource.push(new Match(item));
        }







        // duplication du tableau source pour affichage dans le HTML 
        this.tournoi = [...this.tournoiSource];

        // remplissage du tableau des équipes sans doublon
        // recherche de toutes les équipes
        for (let item of this.tournoiSource) {
            this.equipes.push(item.team1);
            this.equipes.push(item.team2);
        }
        // tri du tableau d'équipes
        this.equipes.sort();
        // réduction du tableau d'équipes 
        this.equipes = new Set(this.equipes);











    },
    computed: {
        // calcul du nombre d'équipes participantes 
        nbEquipes() {
            return this.equipes.size;
        },
        // calcul du nombre de matchs 
        nbMatchs() {
            return this.tournoiSource.length;
        }
    },
    methods: {
        /**
              * tri du tableau en fonction de l'entrée de l'utilisateur 
              * @return {array} retourne un tableau trié 
              */
        triTableau() {
            // si le champs de recherche contient au moins une lettre 
            if (this.recherche != "") {
                // entrée du champ de recherche en minuscules 
                let input = this.recherche.toLowerCase();
                // revoie du tableau tournoi en fonction du tableau souce et du tri conditionnel 
                this.tournoi = this.tournoiSource.filter(item => item.team1.toLowerCase().includes(input) || item.team2.toLowerCase().includes(input));
                return this.tournoi;
            }
            else { // si le champ de recherche est vide, réaffectation du tableau source au tableau tournoi 
                this.tournoi = [...this.tournoiSource]
            }

        }




    }








}





// Monter en vue.js l'appli foot dans la div avec id appFootball 
Vue.createApp(appFootball).mount("#appFootball");