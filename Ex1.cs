using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor, digite seu nome:");
        string nome = Console.ReadLine();
        
        Console.WriteLine($"Olá, {nome}! Seja bem-vindo(a)!");
        
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
