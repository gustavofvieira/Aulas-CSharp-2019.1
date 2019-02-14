function saudar() {
	var nome = document.getElementById("nome").value;
	var altura = document.getElementById("altura").value;
	var peso = document.getElementById("peso").value;
	var result = altura * 2;
	var imc = peso / result;
	alert("Ola "+nome+"\naltura: "+altura+"\npeso:"+peso+"\nIMC: "+imc);
}
function calcular_imc() {
	var altura = document.getElementById("altura").value;
	var peso = document.getElementById("peso").value;
	var imc = peso / altura * 2;

}