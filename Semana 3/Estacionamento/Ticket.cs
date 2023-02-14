using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class Ticket
    {        
        private double valorMinuto;
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public bool Ativo { get; set; }        
    }

    public Ticket(double valorMinuto)
    {
        this.valorMinuto = valorMinuto;
    }

    public double CalcularTempo(){
        TimeSpan tempo = Saida - Entrada;
        return tempo.TotalMinutes();
    }
    
    public double CalcularValor(){
        return CacularTempo() * this.valorMinuto;
    }
}