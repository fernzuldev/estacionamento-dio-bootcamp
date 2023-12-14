// See https://aka.ms/new-console-template for more information
using Estacionamento_DIO.Models;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Clear();
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");

Console.Write("Digite o preço inicial: ");
double.TryParse(Console.ReadLine(), out double precoInicial);

Console.Write("Digite o preço por hora: ");
double.TryParse(Console.ReadLine(), out double precoHora);

Estacionamento es = new Estacionamento(precoInicial, precoHora);
Console.Clear();

int opcao = 0;
do
{
    Console.WriteLine("----------------------");
    Console.WriteLine("1 - CADASTRAR VEICULO");
    Console.WriteLine("2 - REMOVER VEICULO");
    Console.WriteLine("3 - LISTAR VEICULOS");
    Console.WriteLine("4 - ENCERRAR PROGRAMA");
    Console.WriteLine("----------------------");
    Console.Write("Selecione a opção: ");
    int.TryParse(Console.ReadLine(), out opcao);
    
    switch(opcao)
    {
        case 1: 
            es.AdicionarVeiculos();
            break;

        case 2:
            es.RemoverVeiculos();
            break;

        case 3:
            es.ListarVeiculos();
            break;

        case 4:
            Console.Clear();
            Console.WriteLine("Programa encerrado com sucesso!");
            break;

        default:
            Console.Clear();
            Console.WriteLine("Digite uma opção válida!");
            break;
    }
}
while(opcao != 4);