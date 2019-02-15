function addItens(){
	var newInput = document.createElement("INPUT");
	newInput.type = "number";
	var newButton = document.createElement("BUTTON");
	var valor2 = document.createTextNode("Add Outro");
	var evento = document.createAttribute("onclick");
	evento.value = "addItens()"; 
	newButton.setAttributeNode(evento);
	newButton.appendChild(valor2);

	document.body.appendChild(newInput);
	document.body.appendChild(newButton);
}