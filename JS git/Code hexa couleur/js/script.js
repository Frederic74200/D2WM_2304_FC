console.log("toto");

// Contrôler la saisie ----------------------------------------- 
function validInput(inputColor) {

    let control = false;

    let hexa = document.querySelector('#' + inputColor).value;

    if (hexa.match(new RegExp("^[A-Fa-f0-9]{2}$"))) {
        console.log('saisie ok');
        control = true;
    }
    else {
        console.log('erreur !');
        document.querySelector('#' + inputColor).value = '';
        document.querySelector('#' + inputColor).focus();
    }
}

// chnager la couleur du body en fonction de la saisie 
function changeColor() {
    let rg = document.querySelector('#hexa_rg').value.toString();
    let vrt = document.querySelector('#hexa_vrt').value.toString();
    let bl = document.querySelector('#hexa_bl').value.toString();
    let color = '#' + rg + vrt + bl;
    document.body.style.backgroundColor = color;
}

// passer le body en rouge en cliquant sur le bouton
function rouge() {
    document.body.style.backgroundColor = '#FF0000';
}

// passer le body en vert en cliquant sur le bouton

function vert() {
    document.body.style.backgroundColor = '#00FF00';
}
// passer le body en bleu en cliquant sur le bouton

function bleu() {
    document.body.style.backgroundColor = '#0000ff';
}

// inverser color body et h1

function invertColor() {
    let elmBody = document.querySelector('body');
    let color = elmBody.style.backgroundColor;
    console.log(color);

    let titre = document.querySelector('h1');
    titre.style.color = color;
    titre.style.filter = 'invert(100%)';
}


// associer les contôles de siasie et changement de couleur body aux input et changement couleur h1
document.querySelector('#hexa_rg').addEventListener('blur', function () { validInput('hexa_rg'); changeColor(); invertColor(); });
document.querySelector('#hexa_vrt').addEventListener('blur', function () { validInput('hexa_vrt'); changeColor(); invertColor(); });
document.querySelector('#hexa_bl').addEventListener('blur', function () { validInput('hexa_bl'); changeColor(); invertColor(); });

// associer changement couleurs aux boutons  et changement couleur h1
document.querySelector('#btn_rg').addEventListener('click', function () { rouge(); invertColor() });
document.querySelector('#btn_vrt').addEventListener('click', function () { vert(); invertColor() });
document.querySelector('#btn_bl').addEventListener('click', function () { bleu(); invertColor() });


