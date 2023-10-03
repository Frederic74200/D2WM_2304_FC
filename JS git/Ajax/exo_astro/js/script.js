function  afficheJour()
{
 let uneOption= document.createElement('option');
 uneOption.value=0;
 uneOption.text="choisissez votre jour";
 document.querySelector("#jour").options[0]=uneOption;
/*document.querySelector("#jour").appendChild(uneOption);*/
for (let i = 1; i < 32; i++) {
    uneOption= document.createElement('option');
    uneOption.value=i;
    uneOption.text=i;
    document.querySelector("#jour").options[i]=uneOption;
}

}
afficheJour();
