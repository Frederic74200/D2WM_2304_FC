

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
            columnName: '',
            delVal: ""

        }

    },
    async mounted() {
        let json = await Db.fetchJson(urlJson);
        let jsonGet = [...json.data]

        for (let item of jsonGet) {
            this.baseCereals.push(new Cereal(item));
        };

        for (let key in this.baseCereals[1]) {
            this.headTable.push(key)
        };

        this.columnName == '' ? this.baseCerealsCopy = [...this.baseCereals] : columnSort(this.columnName)
    },
    computed: {




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
        columnSort(_item) {

            if (this.columnName != _item) {
                this.columnName = _item;


                this.baseCerealsCopy = this.baseCereals.slice(this.baseCereals.sort((a, b) => a[this.columnName] - b[this.columnName]));

            }
            else {
                this.baseCerealsCopy.reverse()
            }
        },
        resteTable() {
            location.reload();
        },
        delRow(_val) {
            console.log(typeof _val)
            console.log(_val)
            let nb = new Number(_val)
            console.log(nb);
            this.delVal = parseInt(nb);
            console.log(this.delVal)

            delete this.baseCerealsCopy[this.delVal];
            return this.baseCerealsCopy;
        }
    }
}



Vue.createApp(cereals).mount("#app");
