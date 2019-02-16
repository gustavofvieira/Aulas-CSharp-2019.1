//window.location.href = "index.html";
// ou uma variante com o mesmo efeito
//window.location.assign("index.html");

function alerta() {
	alert("pegou");
}
function cadastrar() {
	var nome = document.getElementById("nome");
	var alimento1 = document.getElementById("alimento1");
	var alimento2 = document.getElementById("alimento2");
	var alimento3 = document.getElementById("alimento3");



}

function gera_tabela(){
	alert("chegou no inicio da função");
	var nome = document.getElementById("nome").value;
	var alimento1 = document.getElementById("alimento1").value;
	var alimento2 = document.getElementById("alimento2").value;
	var alimento3 = document.getElementById("alimento3").value;

//-------------------------------------------------------------------------------------------
	if(tabelaCriada == 0){
		alert("entrou no if");

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
	
}
var tabelaCriada = 0;
if(tabelaCriada == 1){
	tabelaCriada = 1;
}