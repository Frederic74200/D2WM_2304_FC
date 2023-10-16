console.log("toto");


function imput_date() {
    document.getElementById('date').valueAsDate = new Date();
}

function imput_time() {
    let d = new Date();
    let h = d.getHours();
    let m = d.getMinutes();

    if (h < 10) {
        h = "0" + h;
    }

    if (m < 10) {
        m = '0' + m;
    }

    let time = h + ":" + m;

    document.getElementById('heure').value = time;
}