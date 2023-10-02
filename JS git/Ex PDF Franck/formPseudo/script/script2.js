console.log('toto');



function getCookie() {
    // Récupère tous les cookies du document
    const cookies = document.cookie.split(";");
    for (let i in cookies) {
        console.log(cookies[i])
    }

    // Crée une Map pour stocker les clés et valeurs des cookies
    const mapCookies = new Map();

    // Parcours tous les cookies
    for (const cookie of cookies) {
        // Sépare la clé et la valeur du cookie
        const [key, value] = cookie.split("=");

        // Ajoute la clé et la valeur du cookie à la Map
        mapCookies.set(key, value);
    }

    // Affiche les clés et valeurs de la Map dans la console

    console.log(mapCookies.entries());
}

getCookie();

alert(valstr.back);
function accueilpg() {

    let tableau = document.createElement('table');
    let tbody = document.createElement('tbody');
    let tr = document.createElement('tr');
    let td = document.createElement('td');


    tableau.appendChild(tbody);


    for (let j = 0; j < 2; j++) {
        tr.appendChild(td.cloneNode(true));
    }


    for (let i = 0; i < 5; i++) {
        tbody.appendChild(tr.cloneNode(true));
    }

    document.querySelector('body').appendChild(tableau);
}

accueilpg();

