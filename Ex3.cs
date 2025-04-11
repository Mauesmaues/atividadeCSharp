using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Digite a primeira nota:");
            double nota1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a segunda nota:");
            double nota2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a terceira nota:");
            double nota3 = double.Parse(Console.ReadLine());
            
            double media = (nota1 + nota2 + nota3) / 3;
            
            Console.WriteLine($"A média das notas é: {media:F2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Por favor, digite números válidos.");
        }
        
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
