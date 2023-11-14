

class Cereal {

    constructor(_json) {

        this.id = 0;
        this.name = "";
        this.calories = 0;
        this.protein = 0;
        this.sodium = 0;
        this.fiber = 0;
        this.carbo = 0;
        this.sugars = 0;
        this.potass = 0
        this.vitamins = 0;
        this.rating = "";
        this.ns = "";

        this.affectData(_json);
        this.setNutriscore(_json.rating)

    }


    // - ----------------------------------------------------------------
    affectData(_json) {
        this.id = _json.id;
        this.name = _json.name;
        this.calories = _json.calories;
        this.protein = _json.protein;
        this.sodium = _json.sodium
        this.fiber = _json.fiber;
        this.carbo = _json.carbo;
        this.sugars = _json.sugars;
        this.potass = _json.potass
        this.vitamins = _json.vitamins;
        this.rating = _json.rating;

    }



    setNutriscore(_data) {
        let rating = parseFloat(_data);

        if (rating > 80) {
            this.ns = "A";
        }
        else if (rating > 70 && rating <= 80) {
            this.ns = "B";

        }
        else if (rating > 55 && rating <= 70) {
            this.ns = "C";
        }
        else if (rating > 35 && rating <= 55) {
            this.ns = "D";
        }
        else {
            this.ns = "E";
        }

    }







}
export { Cereal }