

function gera_tabela(){
	//alert("chegou no inicio da função");
	var nome = document.getElementById("nome").value;
	var alimento1 = document.getElementById("alimento1").value;
	var alimento2 = document.getElementById("alimento2").value;
	var alimento3 = document.getElementById("alimento3").value;
	
	var newP = document.createElement("P");
	var txtNome = document.createTextNode("Sua tabela foi criada "+nome);
	newP.appendChild(txtNome);
	document.body.appendChild(newP);
//-------------------------------------------------------------------------------------------
	if(tabelaCriada == 0){
		
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

		
		var horarios = ['6:00', '9:00', '12:00', '15:00', '18:00','21:00'];
	    var hr = Math.floor(Math.random() * horarios.length);
	    var alimentos = [alimento1,alimento2,alimento3];
	    var ar = Math.floor(Math.random() * alimentos.length);
		for (var i=0;i<6;i++){

			var newTrSequencia = document.createElement("TR");
			newTable.appendChild(newTrSequencia);
			var tdHorarioSequencia = document.createElement("TD");
			var txtHorarioSequencia = document.createTextNode(horarios[hr]);
			var tdAlimentoSequencia = document.createElement("TD");
			var txtAlimentoSequencia = document.createTextNode(alimentos[ar]);
			var tdPorcaoSequencia = document.createElement("TD");
			var txtPorcaoSequencia = document.createTextNode(alimentos[ar]);


			tdHorarioSequencia.appendChild(txtHorarioSequencia);//colocando o texto na tag header da tabela.
			tdAlimentoSequencia.appendChild(txtAlimentoSequencia);
			tdPorcaoSequencia.appendChild(txtPorcaoSequencia);

		 	newTable.appendChild(tdHorarioSequencia); // adiciono o header na table
			newTable.appendChild(tdAlimentoSequencia);
			newTable.appendChild(tdPorcaoSequencia);




		}


}







	
}
var tabelaCriada = 0;
if(tabelaCriada == 1){
	tabelaCriada = 1;
}
