using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor, digite seu ano de nascimento:");
        
        try
        {
            int anoNascimento = int.Parse(Console.ReadLine());
            int anoAtual = 2024;
            int idade = anoAtual - anoNascimento;
            
            Console.WriteLine($"Sua idade em 2024 é: {idade} anos.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
        }
        
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
