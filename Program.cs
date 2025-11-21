using Operadores.Models;

double x;
double y;

Operacao calc = new Operacao();

Console.WriteLine("Calculadora Simples\n");

Console.WriteLine("Digite a operação desejada:");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");
string escolha = Console.ReadLine()!;

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

if (escolha == "1")
{
    calc.Somar(x, y);
}
else if (escolha == "2")
{
    calc.Subtrair(x, y);
}
else if (escolha == "3")
{
    calc.Multiplicacao(x, y);
}
else if (escolha == "4")
{
    if (y == 0)
    {
        Console.WriteLine("Erro: Divisão por zero não é permitida.");
        return;
    }
    else
    {
       calc.Divisao(x, y);  
    }
}
else
{
    Console.WriteLine("Operação inválida.");
}