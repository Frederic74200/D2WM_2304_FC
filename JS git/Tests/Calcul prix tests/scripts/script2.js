

function createPage() {

	// Crée un élément `table`.
	const table = document.createElement("table");

	// Crée un élément `tbody`.
	const tbody = document.createElement("tbody");

	// Ajoute l'élément `tbody` à l'élément `table`.
	table.appendChild(tbody);

	// Parcourt les lignes du tableau.
	for (let i = 0; i < 10; i++) {
		// Crée un élément `tr`.
		const tr = document.createElement("tr");

		// Ajoute l'élément `tr` à l'élément `tbody`.
		tbody.appendChild(tr);

		// Parcourt les colonnes du tableau.
		for (let j = 0; j < 10; j++) {
			// Crée un élément `td`.
			const td = document.createElement("td");

			// Ajoute l'élément `td` à l'élément `tr`.
			tr.appendChild(td);

			// Crée un nœud texte contenant le numéro de la cellule.
			const kt = document.createTextNode(i * 10 + j + 1);

			// Ajoute le nœud texte à l'élément `td`.
			td.appendChild(kt);
		}
	}

	// Ajoute l'élément `table` au corps du document.
	document.querySelector('body').appendChild(table);

}

/*
		// let formulaire = document.createElement("form"[action = "#", method = "get", enctype = "text/plain", name = "formulaire"]);
	
		// let labelQuantite = document.createElement("label"["Quantité"]);l
		let parag = document.createElement("p");
		let txte = document.createTextNode("Hi there and greetings!");
	
		parag.appendChild(txte);
	
		let currentDiv = document.getElementById("p1");
		document.body.insertBefore(parag, currentDiv);
	
	
	

	let table = document.createElement("table");
	let tbody = document.createElement("tboby");
	let tr = document.createElement("tr");
	let td = document.createElement("td");

	table.appendChild(tbody);

	for (let i = 0; i < 10; i++) {

		let trn = tr.setAttribute("tr", i);

		tbody.appendChild(trn);
		for (let j = 0; j < 10; j++) {
			let tdn = td.setAttribute("td", j);
			k = i*10 + j;
			trm.appendChild(tdn);
			let kt = document.createTextNode(k);
			tdn.appendChild(kt);
		}

	}
	document.querySelector('body').appendChild(table);
*/