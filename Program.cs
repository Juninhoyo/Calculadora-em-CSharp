using Operadores.Models;

double x = 0;
double y = 0;
string escolha;

Operacao calc = new Operacao();

List<string> Historico = new List<string>();


Console.WriteLine("Calculadora Simples\n");
do
{
    
Console.WriteLine( 
@"Digite a operação desejada: 
1 - Soma
2 - Subtração
3 - Multiplicação
4 - Divisão
5 - Potência
6 - Raiz Quadrada
7 - Ver Histórico
Digite 0 para sair.");
escolha = Console.ReadLine()!;

double LerNumero(string mensagem)
{
    Console.WriteLine(mensagem);
    double valor;
    while (!double.TryParse(Console.ReadLine(), out valor))
    {
        Console.WriteLine("Entrada inválida. Digite novamente:");
    }
    return valor;
}

if (escolha == "1" || escolha == "2" || escolha == "3" || escolha == "4")
{
    x = LerNumero("Digite o primeiro número:");
    y = LerNumero("Digite o segundo número:");
}
else if (escolha == "5")
{
    x = LerNumero("Digite a base:");
    y = LerNumero("Digite o expoente:");
}
else if (escolha == "6")
{
    x = LerNumero("Digite o número para calcular a raiz quadrada:"); 
}
else if (escolha == "0" || escolha == "7")
{

}
else
{
    Console.WriteLine("Operação inválida. Por favor, escolha uma operação válida.");
    continue;
}


switch (escolha)
    {
    case "1":
        double res1 = calc.Somar(x, y);
        Historico.Add($"{x} + {y} = {res1}");
        break;
    case "2":
        double res2 = calc.Subtrair(x, y);
        Historico.Add($"{x} - {y} = {res2}");
        break;
    case "3":
        double res3 = calc.Multiplicacao(x, y);
        Historico.Add($"{x} * {y} = {res3}");
        break;
    case "4":
        if (y == 0)
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
            break;
        }
        double res4 = calc.Divisao(x, y);
        Historico.Add($"{x} / {y} = {res4}");
        break;
    case "5":
        double res5 = calc.Potencia(x, y);
        Historico.Add($"{x} ^ {y} = {res5}");
        break;
    case "6":
        double res6 = calc.RaizQuadrada(x);
        Historico.Add($"Raiz quadrada de {x} = {res6}");
        break;
    case "7":
        Console.WriteLine("Histórico");
        if (Historico.Count == 0)
        {
            Console.WriteLine("Nenhuma operação realizada ainda.");
        }
        else
        {
            foreach (var item in Historico)
            {
                Console.WriteLine(item);
            }
        }
        break;
    case "0":
        Console.WriteLine("Encerrando a calculadora.");
        Environment.Exit(0);
        break;
    default:
        Console.WriteLine("Operação inválida. Por favor, escolha uma operação válida.");
        break;
    }
} while (escolha != "0");