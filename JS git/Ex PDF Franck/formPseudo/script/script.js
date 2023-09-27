console.log('Toto');


// document.cookie = "pseudo=scorpion; expires=GMT; sameSite=lax"


// variables --------------------------------------------
var prenomMag;
var total = 0;
var signe;
const signAstro = ["Capricorne", "Verseau", "Poisson", "Belier", "Taureau", "Gémeaux", "Cancer", "Lion", "Vierge", "Balance", "Scorpion", "Sagittaire"];
var formValid = 0;
var pseudo = "";

var dateDuJour = new Date();

// date minimum date max 

function minDate() {

    let minDate = new Date(dateDuJour.getFullYear() - 70, dateDuJour.getMonth(), dateDuJour.getDate());
    let maxDate = new Date(dateDuJour.getFullYear() - 18, dateDuJour.getMonth(), dateDuJour.getDate());
    minDate = minDate.toUTCString();
    maxDate = maxDate.toUTCString();

    document.querySelector('#date').setAttribute('min', minDate);

    document.querySelector('#date').setAttribute('max', maxDate);

    console.log(minDate);

}



// désactiver submit  -----------------------------------------------
function dislabSubmit() {
    document.querySelector('#validation').disabled = true;
    document.querySelector('#validation').style.opacity = '0.2';
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
    console.log(total);
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
    }
}







document.querySelector('#prenom').addEventListener('blur', function () { controle('prenom'); valnum(); });


document.querySelector('#date').addEventListener('blur', function () { calculSigne('date'); forOk(); calculPseudo(); });

minDate();

dislabSubmit();
