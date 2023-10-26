class Db {

    static async toJson(url) {
        let reponse = await fetch(url);
        return await reponse.json();
    }

}
export { Db }; 