class SalMounth {

    constructor(_yearSal) {

        this.monthSalary = _yearSal / 12;
        this.monthSalUnit = [];
        this.sumSal;
    }


    monthSal() {

        this.monthSalUnit.push(this.monthSalary);

        return monthSalary.toFixed(2) + ' €';
    }

    salSum() {

        for (let i = 0; i < this.monthSalUnit.length; i++) {
            this.sumSal += this.monthSalUnit[i];
        }
        return this.sumSal;
    }
}

export { SalMounth };