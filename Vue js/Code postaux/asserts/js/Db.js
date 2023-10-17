class Db {

    /**
     * charger Json 
     * @param {string} _url url du json 
     */
    async fetchDb(_url) {
        let reponse = await fetch(_url);
        let dataBase = await reponse.json();
        return dataBase;
    }

}
export { Db }; 