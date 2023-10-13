console.log('toto');

// impoter Json 

async function getJson() {

    // 1) Création du lien vers le fichier Json. https://arfp.github.io/tp/web/frontend/cardgame/cardgame.json
    // fetch() est une méthode asyncrone, il nécessite donc l'opérateur await.
    const reponse = await fetch('https://arfp.github.io/tp/web/html-css-js/02-cardgame/cardgame.json');
    console.log(reponse);

    // 3 méthodes de récupération de fichier, il faut savoir de quel type est le fichier. Json, Xml ou Text. ici c'est du Json.(le Json est un format Text).
    const json = await reponse.json(); // converti le Json en donnée JavaScript


    for (let i = 0; i < json.length; i++) {
        delete json[i].description;
    }
    console.log(json);
    return json;
}


// créer tableau --------------------------------------------------------

function createArray() {
    let tab = document.createElement("table");;
    let thead = document.createElement("thead");
    let tbody = document.createElement("tbody");
    let th = document.createElement("th");
    let colName = ['id', 'name', 'pawer', 'attack', 'armaor', 'damage', 'migration', 'palayed', 'victory', 'defaat', 'draw'];

    for (let i = 0; i < colName.length; i++) {
        let newTh = th.cloneNode(true);
        newTh.textContent = colName[i];
        thead.appendChild(newTh);
    }

    tab.appendChild(thead);

    document.body.appendChild(tab);

    let newRow = tab.insertRow(-1);


















    tab.appendChild(tbody);
}



getJson();

createArray();


/* // 1) Création du lien vers le fichier Json. https://arfp.github.io/tp/web/frontend/cardgame/cardgame.json
// fetch() est une méthode asyncrone, il nécessite donc l'opérateur await.
const reponse = await fetch('https://arfp.github.io/tp/web/frontend/cardgame/cardgame.json');
console.log(reponse)*/