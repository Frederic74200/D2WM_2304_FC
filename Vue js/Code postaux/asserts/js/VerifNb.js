class VerifNb {

    verifNb(_input) {
        console.log("toto");

        if (_input.match(new RegExp("[0-9]"))) {
            return _input;
        }
        else {
            return "erreur saisie"
        }

    }




}
export { VerifNb }