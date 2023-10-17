class CodPost {

    /**
     * constructeur 
     * @param {String}  _cpjson récupére données du json
     */
    constructor(_cpjson) {
        Object.assign(this, _cpjson);
    }

}
export { CodPost }