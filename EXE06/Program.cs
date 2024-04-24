internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite um número: ");
        int value int.Parse(Console.ReadLine());
        Console.WriteLine($"O valor informado foi: {value}. Dobro {value * 2} o Triblo {value * 3}.");
    }
}