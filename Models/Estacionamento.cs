using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estacionamento_DIO.Models
{
    public class Estacionamento
    {
        private List<string> Veiculos = new List<string>();
        private double precoHora;
        private double precoInicial;

        public Estacionamento(double precoHora, double precoInicial)
        {
            this.precoHora = precoHora;
            this.precoInicial = precoHora;
        }
        public void AdicionarVeiculos()
        {
            Console.Write("Digite a placa do Veiculo: ");
            string placa = Console.ReadLine();
            Veiculos.Add(placa);
            Console.WriteLine($"Veículo com placa {placa} adicionado com sucesso.");
        }
        public void RemoverVeiculos()
        {
            Console.Write("Digite a placa do Veiculo a ser removido: ");
            string placa = Console.ReadLine();

            if (Veiculos.Remove(placa))
            {   
                Console.Write("Digite o valor de hora(s) estacionado: ");
                double.TryParse(Console.ReadLine(), out double horasEstacionado);
                
                double valorTotal = precoInicial + (precoHora * horasEstacionado);

                Console.WriteLine($"O veiculo {placa} foi removido e seu valor total {valorTotal:C}.");
            }
            else
            {
                Console.WriteLine($"Veículo com placa {placa} não encontrado na lista.");
            }
        }
        public void ListarVeiculos()
        {
            Console.WriteLine("Lista de Veículos:");

            foreach (string veiculo in Veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }
    }
}