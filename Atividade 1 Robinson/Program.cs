using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a venda média mensal do produto: ");
        int vendaMedia = int.Parse(Console.ReadLine());

        Console.Write("Digite o preço atual do produto: ");
        double precoAtual = double.Parse(Console.ReadLine());

        double novoPreco = precoAtual;

        if (vendaMedia < 500 && precoAtual < 30)
        {
            novoPreco += precoAtual * 0.10;
        }
        else if (vendaMedia >= 500 && precoAtual >= 30)
        {
            novoPreco -= precoAtual * 0.20;
        }

        Console.WriteLine($"O novo preço do produto é: R$ {novoPreco:F2}");
    }
}
