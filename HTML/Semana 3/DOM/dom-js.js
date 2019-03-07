function addItens(){
	var newInput = document.createElement("INPUT");// cria o elemento das tags, nesse caso o input
	newInput.type = "number";//indica o tipo da tag
	
	var newButton = document.createElement("BUTTON");//cria o elemento no caso button
	var evento = document.createAttribute("onclick");//cria o atributo da tag, nesse caso o atributo da tag botão o atributo onclick
	evento.value = "addItens()";//adciona o valor addItens ao onclick 
	newButton.setAttributeNode(evento);//seta o atributo do onclick no botão ficado <button onclick="addItens()"></button>

	var valor2 = document.createTextNode("Add Outro");//adciona o texto ao documento, fica como um texto solto, para posteriormente inserir no botão
	newButton.appendChild(valor2);//cria o filho com o TextNode ficado <button onclick="addItens()">Add Outro</button>

	document.body.appendChild(newInput);// cria o filho no html do input ficando <input type="number">
	document.body.appendChild(newButton);//cria o filho no HTML ficado <button onclick="addItens()">Add Outro</button>

}