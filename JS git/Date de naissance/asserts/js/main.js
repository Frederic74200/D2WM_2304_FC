console.log('toto');

// élements dom ------------------------------------------------------------------------

const dateNais = document.getElementById('dateNais');
const btnCalc = document.getElementById('btnCalc');
const result = document.getElementById('result');


// évenements ---------------------------------------------------------------------------
// maxDate();



// fonctions -----------------------------------------------------

/**
 * bloquer le imput date au delà de la date du jour 
 * @param (paramète) nom variable explictation variable 
 * @returns (type) explications 
 */

function estDansLePasse(_date) {

    // refuser tout ce qui n'est pas du même type par une erreur 
    if (_date instanceof Date()) {
        throw new Error("L'application a renconté une erreur ! Veuillez contacter l'administrateur !")
    }

    let dateJour = new Date();

    return dateJour > _date;

}




/*
function maxDate() {
    let date = new Date();

    let maxDate = (date.getFullYear()) + "-" + ((date.getMonth() + 1) < 10 ? "0" + (date.getMonth() + 1) : (date.getMonth() + 1)) + "-" + (date.getDate() < 10 ? "0" + date.getDate() : date.getDate());

    dateNais.setAttribute('max', maxDate);
}

*/

