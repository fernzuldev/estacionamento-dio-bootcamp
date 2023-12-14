// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Seja bem vindo ao sistema de estacionamento!");

Console.Write("Digite o preço inicial: ");
double.TryParse(Console.ReadLine(), out double precoInicial);

Console.Write("Digite o preço por hora: ");
double.TryParse(Console.ReadLine(), out double precoHora);

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
            Console.Write("Digite a placa do veiculo para adcionar: ");
            break;

        case 2:
            Console.Write("Digite a placa do veiculo para remover: ");
            break;

        case 3:
            Console.Write("Lista de veiculos estacionados");
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