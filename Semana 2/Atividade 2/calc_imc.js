function calcular_imc() {
	var nome = document.getElementById("nome").value;
	var altura = parseFloat(document.getElementById("altura").value);
	var peso = parseFloat(document.getElementById("peso").value);
	var idade = parseInt(document.getElementById("idade").value);
	var result = altura * 2;
	var imc = peso / result;
	if(idade >= 18){
		alert(nome+"maior de idade\n"+idade);
		
	}
	document.getElementById("resultado").innerHTML = "Ola "+nome+"\naltura: "+altura+"\npeso:"+peso+"\nIMC: "+imc;
	

}
function frutas() {
    var frutas = document.getElementsByClassName("frutas");
    alert("Fruta 1: "+frutas[0].value);
	for(var i = frutas.length -1 ; i>=0 ; i--){
		document.getElementById("resultadoF").innerHTML += frutas[i].value+"<br>"; 
	}
}
