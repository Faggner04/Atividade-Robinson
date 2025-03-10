using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a altura em metros: ");
        double altura = double.Parse(Console.ReadLine());

        Console.Write("Digite o sexo (M/F): ");
        char sexo = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        double pesoIdeal = sexo == 'M' ? (72.7 * altura) - 58 : (62.1 * altura) - 44.7;

        Console.WriteLine($"O peso ideal é: {pesoIdeal:F2} kg");
    }
}
