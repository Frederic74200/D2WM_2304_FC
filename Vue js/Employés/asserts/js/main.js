import { Db } from "./Db.js";
import { CreateMail } from "./CreateMail.js";
import { SalMounth } from "./SalMonth.js";

const apiUrl = "https://arfp.github.io/tp/web/html-css-js/05-employees/employees.json";
const { createApp } = Vue;


const empTable = {

    data() {
        return {

            empList: [],
            empBirth: 0,
            empTotal: 0,
            dayDate: new Date(),
            toto: 'toto'
        }

    },
    async mounted() {
        let json = await Db.toJson(apiUrl);
        this.empList = json.data;
        console.log(json, this.empList);

    },
    methods: {


        yearBirht(_age) {
            let cuurentYear = this.dayDate.getFullYear();
            return cuurentYear - _age;

        },
        createMail(_name) {
            let mail = new CreateMail(_name);
            return mail.createEMail();
        }

    },
    computed: {


    }


}

Vue.createApp(empTable).mount('#app');
