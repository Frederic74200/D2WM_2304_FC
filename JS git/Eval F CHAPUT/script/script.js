console.log("toto")

var prenom;
var age;
function affichePrenonAge(_prenom, _age) {

    prenom = _prenom
    age = _age;
    let control = false; console.log(prenom);
    console.log(age);

    if (prenom.match(new RegExp("[A-z_-àâäéèêëîïôùûü]")) && age > 0 && age < 123) {
        control = true;

        alert('ok');


    }
    else {



        /*   document.querySelector(_prenom).value = "";
           document.querySelector('#' + _age).value = "";
   
           document.querySelector('#' + _prenom).focus();
           document.querySelector('#' + _age).focus();
   
           document.querySelector('#' + _resultat).style.color = '#ff0000';*/
        alert('ereur');

    }
}


function majeur(_age, _resultat) {

    let age = document.querySelector('#' + _age).value;

    if (age < 18) {
        document.querySelector('#' + _resultat).innerHTML = "Vous êtes mineure.";
    }
    else {
        document.querySelector('#' + _resultat).innerHTML = "Vous êtes majeure.";
    }

}


function retraire(_age, _resultat) {

    let age = document.querySelector('#' + _age).value;
    let diff;

    if (age < 64) {
        diff = 64 - age

        document.querySelector('#' + _resultat).innerHTML = "Il vous reste : " + diff + 'avant la retraie. ';
    }
    else if (age > 64) {
        diff = age - 64;
        document.querySelector('#' + _resultat).innerHTML = "Vous êtes à la retraite depuis : " + diff + ' années. ';
    }
    else {
        document.querySelector('#' + _resultat).innerHTML = "Vous prenez votre retraite cette année ! ";
    }
}








document.querySelector('#valid').addEventListener('click', function () {

    affichePrenonAge(
        document.querySelector('#inputPrenom').value,
        document.querySelector('#inputAge').value


    );
    /*
        majeur(
    
            document.querySelector('#inputAge'),
            document.querySelector('#majeur')
    
    
        );
    
        retraite(
    
            document.querySelector('#inputAge'),
            document.querySelector('#retraite')
    
    
        );
    */

})