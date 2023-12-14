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