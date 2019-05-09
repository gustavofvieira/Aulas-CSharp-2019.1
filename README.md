# Aulas-CSharp-2019.1
Aulas de CSharp com @francisleide
Context + DBset = funções equivalentes a comandos sql, os metódos do dbset contém scripts de sql, ex: dbset.find(parametro) == a um select * from where parametro 
Painel de Controle\Contas de Usuário\Gerenciador de Credenciais -- apaga as credenciais do git na maquina
# Classes
    [Table("Table_Bloco")]
    public class Bloco
    {
        // modelagem essa tabela é 1 pra muitos no caso apartamento é N e bloco é 1
        [Key]
        public int Pk_Bloco { get; set; }
        public string Numero { get; set; }
        public double Taxa { get; set; }
        public virtual ICollection<Apartamento>  Apartamento{ get; set; } //o virtual ICollection<> serve para carregar a associação da outra classe 

    }

    [Table("Table_Apartamento")]//mudando o nome da table com o migration
    public class Apartamento
    {
        // modelagem essa tabela é 1 pra muitos no caso apartamento é N e bloco é 1
        [Key]
        public int Pk_Apartamento { get; set; }
        public string NomeDono { get; set; }
        public int Andar { get; set; }
        [ForeignKey("Bloco")]//indicando que está referenciando a chave estrangeira da table bloco
        public int Fk_Bloco { get; set; }
        public Bloco Bloco { get; set; }

    }
# Migration
Enable-Migrations -> Add-Migration -> Update-Database

# Metodos
GET: solicitação pelo http maquina cliente faz um request para o servidor dá uma resposta por exemplo uma pagina ex: clique no link faz a solicitação get. Action Listner - get source

POST:  o post não responde uma pagina, o cliente passa pelo http os dados, no caso passa os dados sem request, "passagem dos dados do formulário para o servidor"

# MultiSelect

 @Html.DropDownList("MusicoId", (MultiSelectList)ViewBag.MusicoId, new { multiple = "multiple" }) // Na view
 
[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Fk_Atendimento,Fk_Assistente")] AtendimentoAssitente atendimentoAssitente,List<int> Fk_Assistente, Atendimento Fk_Atendimento)
        {
            if (ModelState.IsValid)
            {
                foreach(var assistenteId in Fk_Assistente)
                {
                    AtendimentoAssitente aa = new AtendimentoAssitente();
                    aa.Fk_Atendimento = Fk_Atendimento.Id;
                    aa.Fk_Assistente = assistenteId;
                    db.AtendimentoAssitente.Add(aa);

                }
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View();
        }
