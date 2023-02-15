using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento
{
    public class Ticket
    {        
        private double valorMinuto = 0.09d;
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public bool Ativo { get; set; }        

        public Ticket(DateTime Entrada)
        {
            this.Entrada = Entrada;
            this.Ativo = true;
        }

        public double CalcularTempo(){           
            var tempo = this.Saida - this.Entrada;
            return tempo.TotalMinutes;
        }
        
        public double CalcularValor(){
            return CalcularTempo() * this.valorMinuto;    
        }

        public static string GerarTicket(string placa){
            Carro carro = Carro.ObterCarro(placa);
            if(carro==null){
                return "Veículo não cadastrado!";
            } else {
                if(carro.Tickets.Exists(x => x.Ativo == true)){
                    return "Veículo já possui um ticket aberto!";
                } else {
                    Ticket ticket = new Ticket(DateTime.Now);
                    carro.Tickets.Add(ticket);
                }
            }
        }
        
        public static void Historico(string placa){
            Carro carro = Carro.ObterCarro(placa);
            if(carro==null){
                Console.WriteLine("Veículo não cadastrado!");
            } else {
                if(carro.Tickets.Count = 0){
                    Console.WriteLine("Veículo ainda não possui tickets vinculados!");
                } else {
                    Console.WriteLine("Exibindo histórico dos tickets:");
                    foreach(Ticket ticket in carro.Tickets){
                        Console.WriteLine($"Entrada: {ticket.Entrada.ToShortDateString()} - Saída: {ticket.Saida.ToShortDateString()} Valor pago: R$ {CalcularValor()}");
                    }
                }
            }
        }
    }
}