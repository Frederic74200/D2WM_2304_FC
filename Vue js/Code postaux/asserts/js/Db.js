class Db {

    /**
     * charger Json 
     * @param {string} _url url du json 
     */
    static async fetchDb(_url) {
        let reponse = await fetch(_url);
        let json = await reponse.json();
        return json;
    }

}
export { Db }; 