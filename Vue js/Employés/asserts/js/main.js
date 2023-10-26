import { Db } from "./Db.js";

const apiUrl = "https://arfp.github.io/tp/web/html-css-js/05-employees/employees.json";
const { createApp } = Vue;


const empTable = {

    data() {
        return {

            empList: [],
            empBirth: 0,
            empTotal: 0,
            monthSalUnit: [],
            salSum: 0,
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
        createMail(_fullname) {
            let name = _fullname.split(' ');
            let firstName = name[0];
            return firstName[0].toLowerCase() + "." + name[1].toLowerCase() + '@email.com';
        },
        monthSal(_yearSal) {
            let monthSalary = _yearSal / 12;
            this.monthSalUnit.push(monthSalary);

            return monthSalary.toFixed(2) + ' €';
        },
        yearBirht(_age) {
            let cuurentYear = this.dayDate.getFullYear();
            return cuurentYear - _age;

        }






    },
    computed: {


    }


}

Vue.createApp(empTable).mount('#app');
