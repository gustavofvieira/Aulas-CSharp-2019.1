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
