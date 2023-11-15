// classe servant à extraire le fichier json par la méthode fetch

class Db {
    static async fetchJson(_url) {
        let reponse = await fetch(_url);
        let json = await reponse.json();
        return json;
    }
}

export { Db };

