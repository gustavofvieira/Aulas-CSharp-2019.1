function calcular() {
	//var operadores =document.getElementsClassName("operadores");

	var valor1 = parseFloat(document.getElementById("valor1").value);
	var valor2 = parseFloat(document.getElementById("valor2").value);
	var result;
	if(document.getElementById("+").selected){
		result = valor1 + valor2;
	}
	if(document.getElementById("-").selected){
		result = valor1 - valor2;
	}
	if(document.getElementById("*").selected){
		result = valor1 * valor2;
	}
	if(document.getElementById("/").selected){
		result = valor1 / valor2;
	}
	document.getElementById("resultado").innerHTML = "O resultado é: "+result;

}