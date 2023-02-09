public class Cobrar {

    private decimal Valor { get; set; }
    private decimal Multa { get; set; }
    
    public Cobrar(decimal valor, decimal multa){
        this.Valor = valor;
        this.Multa = multa;
    }

    private decimal CalcularMulta(){
        return this.Valor + this.Multa;
    }

    public string Calcular(){
        return $"Valor Cobrado {this.Valor.ToString("N2")}, Multa {this.Multa.ToString("N2")}, Soma Valor {this.CalcularMulta().ToString("N2")}";
    }    
}
