using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Digite o primeiro número:");
            double numero1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o segundo número:");
            double numero2 = double.Parse(Console.ReadLine());
            
            if (numero1 > numero2)
            {
                Console.WriteLine($"O maior número é: {numero1}");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine($"O maior número é: {numero2}");
            }
            else
            {
                Console.WriteLine("Os números são iguais.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Por favor, digite números válidos.");
        }
        
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
