

import { Db } from "./Db.js";
import { Cereal } from "./Cereal.js";


const urlJson = "https://arfp.github.io/tp/web/vuejs/10-cereals/cereals.json";



const cereals = {
    data() {

        return {

            baseCereals: [],
            baseCerealsCopy: [],
            headTable: [],
            searchValue: "",
            sortTable: true,
            typesOfNS: [],
            inputNS: [],
            category: "0"


        }

    },
    async mounted() {
        let json = await Db.fetchJson(urlJson);
        let jsonGet = [...json.data]

        for (let item of jsonGet) {
            this.baseCereals.push(new Cereal(item));
        };

        for (let key in this.baseCereals[1]) {
            // let titleCase = (key.charAt(0).toUpperCase() + key.slice(1));

            this.headTable.push(key.toUpperCase());
        };

        for (let item of this.baseCereals) {
            this.typesOfNS.push(item.ns)
        }
        this.typesOfNS.sort();
        this.typesOfNS = new Set(this.typesOfNS);

        console.log(this.typesOfNS);
        this.baseCerealsCopy = [...this.baseCereals]

    },
    computed: {

        entries() {

            return this.baseCerealsCopy.length;
        },

        calAvg() {
            let total = 0;
            for (let item of this.baseCerealsCopy) {
                total += item.calories
            }
            let avg = total / this.entries;
            return avg.toFixed(0);
        }


    },
    methods: {

        dysplayInconsole() {
            if (this.baseCereals.length > 0) {
                console.log(this.baseCereals);
                console.log(this.headTable);
                console.log(this.baseCerealsCopy);
                console.log('ok console');

            }
            else {
                alert("raté !");
            }

        },
        columnSort(event) {
            let attribute = event.target.id;
            attribute = attribute.toLowerCase();

            let sortMethod = (a, b) => {
                if (a[attribute] > b[attribute]) {
                    return 1;
                }
                else if (a[attribute] < b[attribute]) {
                    return -1;
                } else {
                    return 0;
                }
            }
            this.baseCerealsCopy = this.baseCereals.sort(sortMethod)


            if (!this.sortTable) {
                this.baseCerealsCopy.reverse();

            }
            this.sortTable = !this.sortTable;
        },
        resteTable() {
            return this.baseCerealsCopy = [...this.baseCereals];
        },
        delRow(event) {

            let delVal = event.target.id;

            let newTable = [...this.baseCerealsCopy]

            let del = 0;
            for (let item of newTable) {
                if (delVal == item.id) {
                    del = newTable.indexOf(item).toString();
                }
            }

            newTable.splice(del, 1);

            return this.baseCerealsCopy = [...newTable]

        },
        searchCer() {

            let input = this.searchValue.toLowerCase();

            this.baseCerealsCopy = this.baseCereals.filter(item => item.name.toLowerCase().includes(input));


            console.log(input);
            return this.baseCerealsCopy;

        },
        sortNS() {
            console.log(this.inputNS);
            this.baseCerealsCopy = this.baseCereals.filter(item => this.inputNS.includes(item.nutriscore));

        },
        sortCategorie() {

            const criteria = {
                sansSucre: (item) => item.sugars <= 1,
                pauvreEnSel: (item) => item.sodium <= 50,
                boost: (item) => item.vitamins >= 25 && item.fiber >= 10,
            };

            this.baseCerealsCopy = this.baseCereals.filter(criteria[this.category]);







            /*
            
                        switch (this.category) {
            
                            case 0: this.baseCerealsCopy = [...this.baseCereals];
                                break;
                            case 1: this.baseCerealsCopy = this.baseCereals.filter(item => item.sugars = 0);
                                break;
                            case 2: this.baseCerealsCopy = this.baseCereals.filter(item => item.sodium > 0 && item.sodium < 50);
                                break;
                            case 3: this.baseCerealsCopy = this.baseCereals.filter(item => item.vitamins >= 25 && item.fiber >= 10);
                                break;
            
                        }
            */
        }












    }
}



Vue.createApp(cereals).mount("#app");
