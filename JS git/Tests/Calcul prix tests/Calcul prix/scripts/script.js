console.log("toto");

/*
let tableau = [];
tableau = document.querySelectorAll('.remp');

for (let el in tableau) {
    tableau[el].placeholder = 'votre message ici !';
}


for (let i = 0; i < tableau.length; i++) {
    tableau[i].placeholder = 'Votre message ici ! ';
}



tableau.forEach(el => el.placeholder = "votre message : ");

  <input type="text" name="" id="monTxt1" class="remp">
        <input type="text" name="" id="monTxt2" class="remp">
        <input type="text" name="" id="monTxt3" class="remp">
        <input type="text" name="" id="monTxt4" class="remp">
        <input type="text" name="monTxt5" id="monTxt6" class="remp">
        <input type="text" name="" id="monTxt6" class="remp">


/*/







function tableauPrix() {


    // créer imput quantité 

    let inputQ = document.createElement('input');
    inputQ.type = 'number';
    let labelQuant = document.createElement('label');
    let textQ = document.createTextNode("Quantité : ");
    labelQuant.appendChild(textQ);
    let tdQ = document.createElement('td');
    tdQ.appendChild(labelQuant);
    tdQ.append(inputQ);

    // créer imput Prix unitare  

    let inputPU = document.createElement('input');
    inputPU.type = 'number';
    let labelPU = document.createElement('label');
    let textPU = document.createTextNode("Prix unitaire : ");
    labelPU.appendChild(textPU);
    let tdPU = document.createElement('td');
    tdPU.appendChild(labelPU);
    tdPU.append(inputPU);


    // créer imput Prix   

    let inputPrx = document.createElement('input');
    inputPrx.type = 'number';
    let labelPrx = document.createElement('label');
    let textPrx = document.createTextNode("Prix : ");
    labelPrx.appendChild(textPrx);
    let tdPrx = document.createElement('td');
    tdPrx.appendChild(labelPrx);
    tdPrx.append(inputPrx);


    // créer imput total   

    let inputTl = document.createElement('input');
    inputTl.type = 'number';
    let labelTl = document.createElement('label');
    let textTl = document.createTextNode("Total : ");
    labelTl.appendChild(textTl);
    let tdTl = document.createElement('td');
    tdTl.appendChild(labelTl);
    tdTl.append(inputTl);



    // constituer une ligne Q pu 

    let ligneCalcul = document.createElement('tr');
    ligneCalcul.appendChild(tdQ);
    ligneCalcul.appendChild(tdPU);
    ligneCalcul.appendChild(tdPrx);

    // constituer ligne total 
    let ligneTl = document.createElement('tr');
    ligneTl.appendChild(tdTl);

    let tbody = document.createElement('tbody');




    // insérer plusieurs lignes q pu dans tbody  


    for (let i = 0; i < 12; i++) {

        tbody.appendChild(ligneCalcul.cloneNode(true));
    }

    document.querySelector('#tableau').appendChild(tbody);

    document.querySelector('#tableau').append(ligneTl);




    inputQ.setAttribute('name', 'inputQt');

    // inputQ.addEventListener("click", function () { alert("Hello World!") });

    //  document.forms[0].elements[3].addEventListener("click", function () { alert("Hello World!"); })

    //  let inputQte = document.querySelectorAll('input[name="inputQt"]');


    //  inputQte.addEventListener("click", function () { alert("Hello World!"); })
    document.formulaire.tableau.inputQtaddEventListener("click", function () { alert("Hello World!") });

}


tableauPrix();






