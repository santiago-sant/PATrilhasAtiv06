nternal class Program
{
    static void Main()
    {
        Console.Write("Digite uma letra : ");
        string entrada1 = Console.ReadLine().ToLower();
        char resposta = char.Parse(entrada1);
        
        switch (resposta)
        {
            case 'p':
                Console.WriteLine("O preço é: 70.99");
                break;
            case 'm':
                Console.WriteLine("O preço é: 80.99");
                break;
            case 'G':
                Console.WriteLine("O preço é: 90.99");
                break;
            default:
                Console.WriteLine("Não temos esse tamanho");
                break;
        }
    }
}
