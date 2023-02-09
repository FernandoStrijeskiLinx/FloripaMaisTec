public class Filme {

    private string NomeFilme { get; set; }
    private string Categoria { get; set; }
    
    public Filme(string nomeFilme, string categoria){
        this.NomeFilme = nomeFilme;
        this.Categoria = categoria;
    }

    public string ExibeFilme(){
        return $"Mensagem “Filme {this.NomeFilme}, Categoria {this.Categoria}";
    }    
}
