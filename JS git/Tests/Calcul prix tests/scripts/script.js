console.log('Hello Word !');





function createTable() {

    // Crée un tableau de 5 lignes et 3 colonnes.
    const table = document.createElement("table");
    table.setAttribute("border", "1");
    table.setAttribute("width", "500px");
    table.appendChild(document.createElement("thead"));
    table.appendChild(document.createElement("tbody"));

    // Crée les en-têtes du tableau.
    const thead = table.querySelector("thead");
    thead.appendChild(document.createElement("tr"));
    thead.querySelector("tr").appendChild(document.createElement("th"));
    thead.querySelector("tr").appendChild(document.createElement("th"));
    thead.querySelector("tr").appendChild(document.createElement("th"));

    // Crée les lignes du tableau.
    const tbody = table.querySelector("tbody");
    for (let i = 0; i < 5; i++) {
        const tr = document.createElement("tr");
        tr.appendChild(document.createElement("td"));
        tr.appendChild(document.createElement("td"));
        tr.appendChild(document.createElement("td"));
        tbody.appendChild(tr);
    }

    // Crée les éléments de saisie dans les cellules du tableau.
    for (let i = 0; i < 5; i++) {
        const td = tbody.querySelector("tr:nth-child(" + i + ") td:nth-child(1)");
        td.appendChild(document.createElement("input"));
        const td2 = tbody.querySelector("tr:nth-child(" + i + ") td:nth-child(2)");
        td2.appendChild(document.createElement("input"));
        const td3 = tbody.querySelector("tr:nth-child(" + i + ") td:nth-child(3)");
        td3.appendChild(document.createElement("input"));
    }

    // Ajoute le tableau au formulaire.
    document.querySelector("form").appendChild(table);
}
















/*

function createTable() {

    const qte = document.createTextNode("Quantité : ");
    const pu = document.createTextNode("Prix Unitaire : ");
    const prix = document.createTextNode("Prix :");
    const total = document.createTextNode("Total");



    // Crée un élément `table`.
    const table = document.createElement("table");

    // Crée un élément `tbody`.
    const tbody = document.createElement("tbody");

    // Crée un élément `tfoot`.
    const tfoot = document.createElement("tfoot");

    // Crée un élément `tr`.
    const tr = document.createElement("tr");

    // Crée un élément `td`.

    const td = document.createElement("td");

    // Crée éléemnt p
    const p = document.createElement("p");

    // crée élement imput

    let imput = document.createElement("input"[type = "number", size = "10"]);

    //-------------------------------------------------------------


    // Ajoute l'élément `tbody` à l'élément `table`.
    table.appendChild(tbody);

    // Ajoute l'élément `tfoot` à l'élément `table`.
    table.append(tfoot);



    //-------------------------------------------------------------------------------------------

    // ajoueter quantité à p 

    const quntexte = p.appendChild(qte);

    // ajoueter prix unit à p 

    const putexte = p.appendChild(pu);


    // ajoueter prix à p 

    const prixtexte = p.appendChild(prix);

    // ajoueter total à p 

    const totaltexte = p.appendChild(total);



    //-----------------------------------------------------------------------------------

    // crée celule quantité 

    const celQuant = td.appendChild(quntexte);
    celQuant.append(imput);

    // crée celule prix unti 

    const celpu = td.appendChild(putexte);
    celpu.append(imput);

    // crée celule  prix

    const celPrix = td.appendChild(prixtexte);
    celPrix.append(imput);

    // créer ligne 
    const ligne = tr.appendChild(celQuant);
    ligne.append(celpu);
    ligne.append(celPrix);


    // Créer plusieurs lignes 

    for (let i = 0; i > 4; i++) {
        tbody.appendChild(ligne);
    }


    // créer cellule total 

    const celTotal = td.appendChild(total);
    celTotal.append(celTotal);

    // Ajoute l'élément `celTotal` à l'élément `tfoot`.
    tfoot.appendChild(celTotal);


    // Ajoute l'élément `for` au corps du document.
    document.querySelector('form').appendChild(table);

}





*/





/*
function IsFloat(strString, err_msg, text_name, calc_type) {
    var strValidChars = "0123456789.";
    var strChar;
    var blnResult = true;
    var Decimal_Count = new Number(0);
    for (i = 0; i < strString.length && blnResult == true; i++) {
        strChar = strString.charAt(i);
        if (strChar == ".") {
            Decimal_Count = Decimal_Count + 1;
        }
        if ((strValidChars.indexOf(strChar) == -1) || (Decimal_Count > 1)) {
            var err_msg_alert = 'Merci de rentrer un nombre décimal valide. Utiliser le point et non la virgule : par exemple 2.3 et non 2,3.'
            ' textbox';
            eval('window.document.Calculation_Form.' + text_name + '.select()');
            alert(err_msg_alert);
            blnResult = false;
            this.select;
            return blnResult;
        }
    }

    return blnResult;
}




function calculerPrix() {
    let blnNoNull = true;
    if (window.document.formulaire.quantite.value == "" || window.document.formulaire.quantite.value < 0) {
        window.document.formulaire.quantite.select();
        alert("Merci de bien vouloir rentrer la longueur du rectangle");
        blnNoNull = false;
    }
    else if (window.document.formulaire.prix_unit.value == "" || window.document.formulaire.prix_unit.value < 0) {
        window.document.formulaire.quantite.select();
        alert("Merci de bien vouloir rentrer la longueur du rectangle");
        blnNoNull = false;
    }


    else if (window.document.formulaire.quantite2.value == "" || window.document.formulaire.quantite2.value < 0) {
        window.document.formulaire.quantite.select();
        alert("Merci de bien vouloir rentrer la longueur du rectangle");
        blnNoNull = false;
    }

    else if (window.document.formulaire.prix_unit2.value == "" || window.document.formulaire.prix_unit2.value < 0) {
        window.document.formulaire.quantite.select();
        alert("Merci de bien vouloir rentrer la longueur du rectangle");
        blnNoNull = false;
    }


    if (blnNoNull) {
        let q = new Number(window.document.formulaire.quantite.value);
        let pu = new Number(window.document.formulaire.prix_unit.value);
        let q2 = new Number(window.document.formulaire.quantite2.value);
        let pu2 = new Number(window.document.formulaire.prix_unit2.value);
        let r = q * pu;
        let r2 = q2 * pu2;
        let t = q1 + q2;

        window.document.formulaire.resultat.value = r;

        window.document.formulaire.resultat2.value = r2;

        window.document.formulaire.total.value = t;
        alert(t);
    }
}
*/