console.log('Toto');


// document.cookie = "pseudo=scorpion; expires=GMT; sameSite=lax"


// variables --------------------------------------------
var prenomMag;
var total = 0;
var signe;
const signAstro = ["Capricorne", "Verseau", "Poisson", "Belier", "Taureau", "Gémeaux", "Cancer", "Lion", "Vierge", "Balance", "Scorpion", "Sagittaire"];
var formValid = 0;
var pseudo = "";
var valeurs = new Map();
var valstr = '';

// date minimum date max -----------------------------------------

function minDate() {
    let date = new Date();

    let minDate = (date.getFullYear() - 70) + "-" + ((date.getMonth() + 1) < 10 ? "0" + (date.getMonth() + 1) : (date.getMonth() + 1)) + "-" + (date.getDate() < 10 ? "0" + date.getDate() : date.getDate());

    let maxDate = (date.getFullYear() - 18) + "-" + ((date.getMonth() + 1) < 10 ? "0" + (date.getMonth() + 1) : (date.getMonth() + 1)) + "-" + (date.getDate() < 10 ? "0" + date.getDate() : date.getDate());

    document.querySelector('#date').setAttribute('min', minDate);
    document.querySelector('#date').setAttribute('max', maxDate);
}


// désactiver submit  -----------------------------------------------
function dislabSubmit() {
    document.querySelector('#validation').disabled = true;
    document.querySelector('#validation').style.opacity = '0';
}



// fonction controle que des lettres -------------------------------------------
function controle(_prenom) {
    let control = false;
    let saisie = document.querySelector('#' + _prenom).value;
    prenomMag = saisie.toUpperCase();

    if (prenomMag.match(new RegExp("[A-Z_-]"))) {
        control = true;
    }
    else {
        document.querySelector('#' + _prenom).value = "";
        document.querySelector('#' + _prenom).focus();
    }
}

// fonction total valeurs lettres prénom ---------------------------------------
function valnum() {
    for (let i = 0; i < prenomMag.length; i++) {
        total += prenomMag.charCodeAt(i);
        total += -64;
    }
}

// fonction calculer le signe astro ---------------------------------------------
function calculSigne(date) {
    let dateForm = document.querySelector('#' + date).value;
    let dateN = new Date(dateForm);
    let mois = dateN.getMonth();
    signe = signAstro[mois];
}

// fonction tous les champs remplis  ----------------------------------------------
function forOk() {
    let readOnly = document.querySelector('#pseudo').getAttribute('readonly');
    let required = document.querySelectorAll('.required');

    for (i = 0; i < required.length; i++) {
        if (!readOnly && required[i].value == "") {
            formValid++;
            required[i].style.border = '1px solid #fe5d53';
        }
        else {
            formValid = 0;
            required[i].style.border = '1px solid #4cc8b0';
        }
    }
}

// fonction calculer le pseudo ------------------------------------------------------
function calculPseudo() {
    pseudo = signe + total.toString();
    console.log(pseudo);
    document.querySelector('#pseudo').value = pseudo;
    if (formValid === 0 && pseudo != "") {
        document.querySelector('#validation').disabled = false;
        document.querySelector('#validation').style.opacity = '1';
        document.querySelector('#validation').style.cursor = 'pointer';
    }
    console.log(pseudo);
}

// difeerence en jours avec l'anniv 
function nbJoursAnniv(date) {
    let dateForm = document.querySelector('#' + date).value;
    let dateN = new Date(dateForm);
    let dateDuJour = new Date();
    let dateAnniv = new Date(dateDuJour.getFullYear(), dateN.getMonth(), dateN.getDate());

    let diff = dateAnniv.getTime() - dateDuJour.getTime();
    let diffDays = diff / (1000 * 24 * 3600);
    diffDays = Math.trunc(diffDays);

    if (diffDays == -0) {
        diffDays = Math.abs(diffDays);
    }

    else if (diffDays < 0) {
        dateAnniv = new Date((dateDuJour.getFullYear() + 1), dateN.getMonth(), dateN.getDate());
        diff = dateAnniv.getTime() - dateDuJour.getTime();
        diffDays = diff / (1000 * 24 * 3600);
        diffDays = Math.round(diffDays);
    }
    return diffDays;
}


// régler luminosité 
function lumin() {
    let nivLum = document.querySelector('#lum').value;
    let nivLumStg = ' brightness(' + nivLum + ')';
    document.body.style.filter = nivLumStg;
}
document.querySelector('#lum').addEventListener('change', function () { lumin(); });

function getValeurs() {

    valeurs.set('Nom', document.querySelector('#nom').value);
    valeurs.set('Prénom', document.querySelector('#prenom').value);
    valeurs.set('Date naissance', document.querySelector('#date').value);
    valeurs.set('pseudo', document.querySelector('#pseudo').value);
    valeurs.set('Nombre jours', nbJoursAnniv);
    return valeurs;
}


// cookie ---------------------------------------------------------------------------

function newCoockie(nom, valeur) {

    let dateJour = new Date();
    let dateExpir = new Date(dateJour.getFullYear(), (dateJour.getMonth() + 2), (dateJour.getDate() + 2));
    dateExpir = dateExpir.toUTCString();
    document.cookie = nom + '=' + valeur + "expires=" + dateExpir + ";samesite=lax";
}






minDate();

dislabSubmit();


// nom utili = prenom contole saise -------------------
document.querySelector('#nom').addEventListener('blur', function () { controle('nom'); forOk(); });
document.querySelector('#prenom').addEventListener('blur', function () { controle('prenom'); valnum(); calculPseudo(); forOk(); });

// mail ------------------------------------
document.querySelector('#email').addEventListener('blur', function () { forOk(); });

// date      ----------------------------------------------------------------------------------------
document.querySelector('#date').addEventListener('blur', function () { calculSigne('date'); calculPseudo(); forOk() });

// pseudo -------------------------------------
document.querySelector('#pseudo').addEventListener('input', function () { forOk() });



document.querySelector('#validation').addEventListener('click', function () {
    getValeurs();
    newCoockie('nom', document.querySelector('#nom').value);
    // document.forms["formulaire"].submit();
    window.location.href = '../accueil.html';
});


















