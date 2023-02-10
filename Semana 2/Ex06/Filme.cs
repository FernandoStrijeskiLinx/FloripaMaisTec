public class Filme {

    private string nomeFilme;
    private string categoria;
    
    public Filme(string nomeFilme, string categoria){
        this.nomeFilme = nomeFilme;
        this.categoria = categoria;
    }

    public string ExibeFilme(){
        return $"Mensagem “Filme {this.nomeFilme}, Categoria {this.categoria}";
    }    
}
