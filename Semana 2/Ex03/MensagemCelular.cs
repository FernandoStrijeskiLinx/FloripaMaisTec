public class MensagemCelular {
    public int Telefone { get; set; }   
    public string Mensagem { get; set; }

    public MensagemCelular(){
        
    }

    public string Executar(){
        return EnviarMensagemAoTelefone();
    }

    private string EnviarMensagemAoTelefone(){
        return "Método privado executado na classe";
    }
}