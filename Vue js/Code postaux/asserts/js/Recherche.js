class Recherche {

    rechercheCP(_input, _cpJson, _villeJson) {
        if (_input.length > 1) {

            for (let i = 0; i < _input.length; i++) {

                if (_cpJson.indexOf(_input) < -1) {
                    return _villeJson;
                }
            }
        }
    }
}

export { Recherche }; 