 function jogartable() {
//Atribui os dados obtidos nos campos e transfere para variavel no js.
 	var alimento61 = document.getElementById("alimento61").value;
 	var pl61 = document.getElementById("pl61").value;

 	var alimento62 = document.getElementById("alimento62").value;
 	var pl62 = document.getElementById("pl62").value;

 	var alimento63 = document.getElementById("alimento63").value;
 	var pl63 = document.getElementById("pl63").value;
//--------------------------------------------------------------------------------------------
 	var alimento91 = document.getElementById("alimento91").value;
 	var pl91 = document.getElementById("pl91").value;
 	
 	var alimento92 = document.getElementById("alimento92").value;
 	var pl92 = document.getElementById("pl92").value;
	
 	var alimento93 = document.getElementById("alimento93").value;
 	var pl93 = document.getElementById("pl93").value;
//--------------------------------------------------------------------------------------------
 	
 	var alimento121 = document.getElementById("alimento121").value;
 	var pl121 = document.getElementById("pl121").value;
 	
 	var alimento122 = document.getElementById("alimento122").value;
 	var pl122 = document.getElementById("pl122").value;
	
 	var alimento123 = document.getElementById("alimento123").value;
 	var pl123 = document.getElementById("pl123").value;

//--------------------------------------------------------------------------------------------

	var alimento151 = document.getElementById("alimento151").value;
 	var pl151 = document.getElementById("pl151").value;
 	
 	var alimento152 = document.getElementById("alimento152").value;
 	var pl152 = document.getElementById("pl152").value;
	
 	var alimento153 = document.getElementById("alimento153").value;
 	var pl153 = document.getElementById("pl153").value;

//--------------------------------------------------------------------------------------------
 	var alimento181 = document.getElementById("alimento181").value;
 	var pl181 = document.getElementById("pl181").value;
 	
 	var alimento182 = document.getElementById("alimento182").value;
 	var pl182 = document.getElementById("pl182").value;
	
 	var alimento183 = document.getElementById("alimento183").value;
 	var pl183 = document.getElementById("pl183").value;
//--------------------------------------------------------------------------------------------
 	 var alimento211 = document.getElementById("alimento211").value;
 	var pl211 = document.getElementById("pl211").value;
 	
 	var alimento212 = document.getElementById("alimento212").value;
 	var pl212 = document.getElementById("pl212").value;
	
 	var alimento213 = document.getElementById("alimento213").value;
 	var pl213 = document.getElementById("pl213").value;

//--------------------------------------------------------------------------------------------
 	var v6a = new Array;
 	var v6p = new Array;

//Preenche posições do vetor com os dados inserido nos campos.
 	v6a.push(alimento61);
 	v6p.push(pl61);
 	v6a.push(alimento62);
 	v6p.push(pl62);
 	v6a.push(alimento63);
 	v6p.push(pl63);

 	var r6 = Math.floor(Math.random()*3);
 	document.getElementById("comida6").innerHTML = v6a[r6] ;
 	document.getElementById("pcomida6").innerHTML = v6p[r6] ;

 	//--------------------------------------------------------------------------------------------

 	
 	var v9a = new Array;
 	var v9p = new Array;

 	v9a.push(alimento91);
 	v9p.push(pl91);
 	v9a.push(alimento92);
 	v9p.push(pl92);
 	v9a.push(alimento93);
 	v9p.push(pl93);

 	var r9 = Math.floor(Math.random()*3);
 	document.getElementById("comida9").innerHTML = v9a[r9] ;
 	document.getElementById("pcomida9").innerHTML = v9p[r9] ;

 	//--------------------------------------------------------------------------------------------
 	
 	

 	var v12a = new Array;
 	var v12p = new Array;

 	v12a.push(alimento121);
 	v12p.push(pl121);
 	v12a.push(alimento122);
 	v12p.push(pl122);
 	v12a.push(alimento123);
 	v12p.push(pl123);

 	var r12 = Math.floor(Math.random()*3);
 	document.getElementById("comida12").innerHTML = v12a[r12] ;
 	document.getElementById("pcomida12").innerHTML = v12p[r12] ;

//--------------------------------------------------------------------------------------------

 	

 	var v15a = new Array;
 	var v15p = new Array;

 	v15a.push(alimento151);
 	v15p.push(pl151);
 	v15a.push(alimento152);
 	v15p.push(pl152);
 	v15a.push(alimento153);
 	v15p.push(pl153);

 	var r15 = Math.floor(Math.random()*3);
 	document.getElementById("comida15").innerHTML = v15a[r15] ;
 	document.getElementById("pcomida15").innerHTML = v15p[r15] ;
//--------------------------------------------------------------------------------------------
 


 	var v18a = new Array;
 	var v18p = new Array;

 	v18a.push(alimento181);
 	v18p.push(pl181);
 	v18a.push(alimento182);
 	v18p.push(pl182);
 	v18a.push(alimento183);
 	v18p.push(pl183);

 	var r18 = Math.floor(Math.random()*3);
 	document.getElementById("comida18").innerHTML = v18a[r18] ;
 	document.getElementById("pcomida18").innerHTML = v18p[r18] ;

 //--------------------------------------------------------------------------------------------	




 	var v21a = new Array;
 	var v21p = new Array;

 	v21a.push(alimento211);
 	v21p.push(pl211);
 	v21a.push(alimento212);
 	v21p.push(pl212);
 	v21a.push(alimento213);
 	v21p.push(pl213);

 	var r21 = Math.floor(Math.random()*3);
 	document.getElementById("comida21").innerHTML = v21a[r21] ;
 	document.getElementById("pcomida21").innerHTML = v21p[r21] ;



}

