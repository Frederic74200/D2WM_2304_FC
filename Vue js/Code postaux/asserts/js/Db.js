class Db {
    /**
     * charger Json 
     * @param {*} _url url du json 
     */
    async fetchDb(_url) {
        const reponse = await fetch(_url);
        const dataBase = await reponse.json();
        return dataBase;
    }

}
export { Db }; 