using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Pessoa {
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }    

    public Pessoa(string nome, DateTime dataNascimento){
        this.Nome = nome;
        this.DataNascimento = dataNascimento;
    }

    public string MostrarIdade(){
        return $"Nome {this.Nome} tem a Idade {CalcularIdade().ToString()}";        
    }

    private int CalcularIdade(){        
        var dataAtual = DateTime.Now;
        var idade = dataAtual.Year - this.DataNascimento.Year;
        if (this.DataNascimento > dataAtual.AddYears(-idade))
        {
        idade--;
        }
        return idade;
    }
}