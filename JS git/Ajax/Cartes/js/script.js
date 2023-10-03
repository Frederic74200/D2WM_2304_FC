console.log('toto');

// impoter Json 

var promise;
function getJson() {
    promise = fetch("../json/cardeGame.json")
        .then(response => response.json())
        .then(response => console.log(JSON.stringify(response)))
        .catch(error => console.log("Erreur : " + error));

    for (let val in promise) {

    }
    return promise;
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