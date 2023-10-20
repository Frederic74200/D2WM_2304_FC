class Recherche {

    rechercheCP(_input, _cpJson, _villeJson) {


        const codePostal = _input.slice(0, 2);

        const villes = _villeJson.filter((ville) => ville.codePostal === codePostal);

        return villes;
    }
}




export { Recherche }; 