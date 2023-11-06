import { Db } from './Db.js';

console.log("toto bonjour")

const urljson = './asserts/js/eval.json';

const { createApp } = Vue;

const appEval = {

    data() {
        return {
            liste: [],
            noteElim: 12,
            total: 0,
            nbEtudiants: 0,
            moyenneClasse: 0,
            inputNom: "",
            inputNote: 0,
        }

    },
    async mounted() {
        this.liste = await Db.fetchJson(urljson);

    },

    methods: {

        nom(nomPrenom) {
            let nomP = nomPrenom.split(" ");
            return nomP[0];
        },
        prenom(nomPrenom) {
            let nomP = nomPrenom.split(" ");
            return nomP[1];
        },
        obtenu(_note) {
            return _note > this.noteElim ? "oui" : "non";
        },
        cumul(_note) {
            this.total += _note;
        },
        dessusMoy(_note) {
            if (_note > this.moyenneClasse) {
                this.nbEtudiants++;
            }

        }



    },
    computed: {
        nbEtudiants() {
            return this.liste.length;
        },
        moyenneClas() {
            this.moyenneClasse = this.total / this.liste.length;
            return this.moyenneClasse.toFixed(2);
        }



    }

}

createApp(appEval).mount('#app')
