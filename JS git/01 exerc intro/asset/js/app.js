
console.log('toto');

// récupérer éléments html  ---------------------------------------------

const btnvalider = document.getElementById('valider');
const inputPrenom = document.getElementById('prenom');
const inputAge = document.getElementById('age');
const divResultat = document.getElementById('resultat');
const ageRetraite = 64;

// ajouter événements  ------------------------------------------------------------

btnvalider.addEventListener('click', () => {

    if (agePrenomValides()) {
        console.log('OK');
        divResultat.innerHTML = `Bonjour ${inputPrenom.value}, Votre age est : ${inputAge.value} `;

        if (estMajeur()) {
            divResultat.innerHTML += `Vous êtes majeur.e !`;
        }
        else {
            divResultat.innerHTML += `Vous êtes mineur.e !`;
        }
        divResultat.innerHTML += estRetraite();

    }
    else {
        console.log('pas OK');
        divResultat.innerHTML = `Complétez / Corrigez le formulaire.`;
    }
})

// fonction --------------------------------------------------------------------------

function agePrenomValides() {
    let prenom = inputPrenom.value.trim();
    let age = inputAge.value;
    return (prenom.length > 0 && age > 0);
}

function estMajeur() {
    return (inputAge.value >= 18);
}

function estRetraite() {
    let reste;

    if (inputAge.value < ageRetraite) {
        reste = ageRetraite - inputAge.value;
        return `Il vous reste : ${reste} années jusqu'à la retraite`;
    }
    else if (inputAge.value > ageRetraite) {
        reste = inputAge.value - ageRetraite;
        return `Vous êtes à la retraite depuis: ${reste} années.`;
    }
    else {
        return `Vous prenez votre retraite cette année !`;
    }
}