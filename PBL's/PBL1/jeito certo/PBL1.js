function gera() {
	
		alert("entrou");
		var alimento = document.getElementById("alimento_1_6").value;
		return alert(alimento);

		document.
	
}
function validacao() {
	if(document.form.nome_completo.value==""){
		alert("preencha o nome");
		return false;
		document.form.nome_completo.focus();
	}
}

function gera_tabela(){

	//alert("chegou no inicio da função");
	var nome = document.getElementById("nome_completo").value;
//Horário das 6
	var alimento_1_6 = document.getElementById("alimento_1_6").value;
	var porcao_1_6 = document.getElementById("porcao_1_6").value;
	var alimento_2_6 = document.getElementById("alimento_2_6").value;
	var porcao_2_6 = document.getElementById("porcao_2_6").value;
	var alimento_3_6 = document.getElementById("alimento_3_6").value;
	var porcao_3_6 = document.getElementById("porcao_3_6").value;
//Horário das 9





//-------------------------------------------------------------------------------------------
	if(tabelaCriada == 0){
	var newP = document.createElement("P");
	var txtNome = document.createTextNode("Sua tabela foi criada "+nome);
	newP.appendChild(txtNome);
	document.body.appendChild(newP);
		
	var newTable = document.createElement("TABLE");
	var borda = document.createAttribute("BORDER");
	borda.value = "1"; 
	newTable.setAttributeNode(borda); // até aqui está criado <table border="1"></table>

//-------------------------------------------------------------------------------------------
	var newTr = document.createElement("TR");// criando uma nova linha
//-------------------------------------------------------------------------------------------	
	var thHorario = document.createElement("TH");//criando os headers da tabela
	var thAlimento = document.createElement("TH");
	var thPorcao = document.createElement("TH");
//------------------------------------------------------------------------------------------- 
    var txtHorario = document.createTextNode("Horario");// criando os textos dos heades
	var txtAlimento = document.createTextNode("Alimento");
	var txtPorcao = document.createTextNode("Porção");
//-------------------------------------------------------------------------------------------
	thHorario.appendChild(txtHorario);//colocando o texto na tag header da tabela.
	thAlimento.appendChild(txtAlimento);
	thPorcao.appendChild(txtPorcao);
//-------------------------------------------------------------------------------------------
	newTable.appendChild(thHorario); // adiciono o header na table
	newTable.appendChild(thAlimento);
	newTable.appendChild(thPorcao);

	 document.body.appendChild(newTable); // adciono a table no html
	 tabelaCriada = 1;
	// alert("chegou no fim da função");
	

}
	if(tabelaCriada == 1 ){

		
	
		
			// linha horário das 6
			var tr6 = document.createElement("TR");
			newTable.appendChild(tr6);
			var tdHorario6 = document.createElement("TD");
			var txtHorario6 = document.createTextNode("06:00hrs");
			tdHorario6.appendChild(txtHorario6);//colocando o texto na tag header da tabela.
			newTable.appendChild(tdHorario6); // adiciono o header na table
			var tdAlimentoSequencia = document.createElement("TD");
			var txtAlimentoSequencia = document.createTextNode(alimento_1_6);
			var tdPorcaoSequencia = document.createElement("TD");
			var txtPorcaoSequencia = document.createTextNode(porcao_1_6);
			tdAlimentoSequencia.appendChild(txtAlimentoSequencia);
			tdPorcaoSequencia.appendChild(txtPorcaoSequencia);
			newTable.appendChild(tdAlimentoSequencia);
			newTable.appendChild(tdPorcaoSequencia);
			// linha horário das 9
			var tr9 = document.createElement("TR");
			newTable.appendChild(tr9);
			var tdHorario9 = document.createElement("TD");
			var txtHorario9 = document.createTextNode("09:00hrs");
			tdHorario9.appendChild(txtHorario9);//colocando o texto na tag header da tabela.
			newTable.appendChild(tdHorario9); // adiciono o header na table
			var tdAlimentoSequencia = document.createElement("TD");
			var txtAlimentoSequencia = document.createTextNode(alimento_1_6);
			var tdPorcaoSequencia = document.createElement("TD");
			var txtPorcaoSequencia = document.createTextNode(porcao_1_6);
			tdAlimentoSequencia.appendChild(txtAlimentoSequencia);
			tdPorcaoSequencia.appendChild(txtPorcaoSequencia);
			newTable.appendChild(tdAlimentoSequencia);
			newTable.appendChild(tdPorcaoSequencia);
			// linha horário das 12
			var tr6 = document.createElement("TR");
			newTable.appendChild(tr6);
			var tdHorario6 = document.createElement("TD");
			var txtHorario6 = document.createTextNode("06:00hrs");
			tdHorario6.appendChild(txtHorario6);//colocando o texto na tag header da tabela.
			newTable.appendChild(tdHorario6); // adiciono o header na table
			var tdAlimentoSequencia = document.createElement("TD");
			var txtAlimentoSequencia = document.createTextNode(alimento_1_6);
			var tdPorcaoSequencia = document.createElement("TD");
			var txtPorcaoSequencia = document.createTextNode(porcao_1_6);
			tdAlimentoSequencia.appendChild(txtAlimentoSequencia);
			tdPorcaoSequencia.appendChild(txtPorcaoSequencia);
			newTable.appendChild(tdAlimentoSequencia);
			newTable.appendChild(tdPorcaoSequencia);




		


}







	
}
var tabelaCriada = 0;
if(tabelaCriada == 1){
	tabelaCriada = 1;
}

	
