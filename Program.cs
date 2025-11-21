using Operadores.Models;

double x = 0;
double y = 0;

Operacao calc = new Operacao();

Console.WriteLine("Calculadora Simples\n");

Console.WriteLine("Digite a operação desejada:");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
Console.WriteLine("5 - Potência");
string escolha = Console.ReadLine()!;

if (escolha == "1" || escolha == "2" || escolha == "3" || escolha == "4")
{
    Console.WriteLine("Digite o primeiro número:");
    while (!double.TryParse(Console.ReadLine(), out x))
{
    Console.WriteLine("Entrada invalida. Por favor, digite um numero valido para o primeiro numero:");
}

    Console.WriteLine("Digite o segundo número:");
    while (!double.TryParse(Console.ReadLine(), out y))
{
    Console.WriteLine("Entrada invalida. Por favor, digite um numero valido para o segundo numero:");
}

}
else if  (escolha == "5")
{
    Console.WriteLine("Digite a base:");
    while (!double.TryParse(Console.ReadLine(), out x))
{
    Console.WriteLine("Operação inválida. Por favor, escolha uma operação válida.");
    return;
}
    Console.WriteLine("Digite o expoente:");
    while (!double.TryParse(Console.ReadLine(), out y))
{
    Console.WriteLine("Entrada invalida. Por favor, digite um numero valido para o expoente:");
}

}

switch (escolha)
{
    case "1":
        calc.Somar(x, y);
        break;
    case "2":
        calc.Subtrair(x, y);
        break;
    case "3":
        calc.Multiplicacao(x, y);
        break;
    case "4":
        if (y == 0)
        {
            Console.WriteLine("Erro: Divisão por zero não é permitida.");
            break;
        }
        calc.Divisao(x, y);
        break;
    case "5":
        calc.potencia(x, y);
        break;
    default:
        Console.WriteLine("Operação inválida. Por favor, escolha uma operação válida.");
        break;
}