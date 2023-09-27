


function calculerPrix() {

    let q1 = document.querySelector('#q1').value;
    let q2 = document.querySelector('#q2').value;
    let pu1 = document.querySelector('#pu1').value;
    let pu2 = document.querySelector('#pu2').value;

    (isNaN(q1) && q1 < 0 ? alert('Saisie incorrecte !') : '');
    (isNaN(q2) && q2 < 0 ? alert('Saisie incorrecte !') : '');
    (isNaN(pu1) && pu1 < 0 ? alert('Saisie incorrecte !') : '');
    (isNaN(pu2) && pu2 < 0 ? alert('Saisie incorrecte !') : '');

    let px1 = q1 * pu1;
    let px2 = q2 * pu2;

    document.querySelector('#px1').value = px1;
    document.querySelector('#px2').value = px2;
    document.querySelector('#total').value = px1 + px2;

}
document.querySelector('#q1').addEventListener('input', calculerPrix);
document.querySelector('#q2').addEventListener('input', calculerPrix);
document.querySelector('#pu1').addEventListener('input', calculerPrix);
document.querySelector('#pu2').addEventListener('input', calculerPrix);
