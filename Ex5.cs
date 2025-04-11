using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Digite um número para verificar se é par ou ímpar:");
            int numero = int.Parse(Console.ReadLine());
            
            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é par.");
            }
            else
            {
                Console.WriteLine($"O número {numero} é ímpar.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número válido.");
        }
        
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
