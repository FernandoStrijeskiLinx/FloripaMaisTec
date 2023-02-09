public class Guitarra {
    private string afinacao;

    public Guitarra(){
        this.afinacao = "SOL";
    }

    public string TomAfinado(){
        return $"A guitarra está com afinação em {this.afinacao}";
    }

    public string Tocar(){
        return TomAfinado();
    }

    public string Tocar(string som){
        this.afinacao = som;
        return TomAfinado();
    }
}
