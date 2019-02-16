function calc_watts() {
	var qtKwh = parseFloat(document.getElementById("qtKwh").value);
	var valorUnitKwh = parseFloat(document.getElementById("unitKwh").value);
	var valor;
	var porcentagem;

	if(qtKwh > 100){
		porcentagem = valorUnitKwh * 0.25;
		valorUnitKwh += porcentagem;
		valor = qtKwh * valorUnitKwh;

	} else if(qtKwh > 200){
		porcentagem = valorUnitKwh * 0.5;
		valorUnitKwh += porcentagem;
		valor = qtKwh * valorUnitKwh;
	}
	valor = qtKwh * valorUnitKwh ;
	
	document.getElementById("valor").innerHTML = "O valor é: "+valor;
}