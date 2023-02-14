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

        public Ticket(double valorPorMinuto)
        {
            this.valorMinuto = valorPorMinuto;
        }

        public double CalcularTempo(){
            var tempo = this.Saida - this.Entrada;
            return tempo.TotalMinutes;
        }
        
        public double CalcularValor(){
            return CalcularTempo() * this.valorMinuto;    
        }
    }
}