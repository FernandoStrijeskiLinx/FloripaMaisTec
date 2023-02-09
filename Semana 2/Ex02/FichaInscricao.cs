public class FichaInscricao {
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }    
    public bool MenorIdade { get; set; }

    public FichaInscricao(int id, string nome, DateTime dataNascimento){
        this.Id = id;
        this.Nome = nome;
        this.DataNascimento = dataNascimento;
        this.MenorIdade = MenorDeIdade();
    }

    private bool MenorDeIdade(){
        DateTime DataDaMaiorIdade = this.DataNascimento.AddYears(18);
        if(DataDaMaiorIdade > DateTime.Today) 
            return true;
        else
            return false;
    }

    public string DemonstraClasse(){
        return $"Código {Id}, Nome {Nome}, Data Nascimento {DataNascimento.ToShortDateString()}";
    }
}