function tab(col, lign) {
    this.tab = document.createElement("table");
    this.autoid = 1;

    for (j = 0; j < lign; j++) {

        this.newRow = this.tab.insertRow(-1);

        for (i = 0; i < col; i++) {

            this.newCell = this.newRow.insertCell(i);
            this.newCell.innerHTML = /* "&nbsp;"; */ this.autoid;
            this.newCell.setAttribute("id", this.autoid);

            with (this.newCell.style) {
                borderStyle = 'solid';
                borderWidth = '2px';
                borderColor = "#000000";
                width = '100px';
                height = '50px';
                textAlign = 'center';
            }

            this.autoid++;
        }

    }

    this.addtxt = function (id) {
        document.getElementById(id).innerHTML = "ne";
    }

    document.body.appendChild(this.tab);



}
