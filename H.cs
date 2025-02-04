internal class Program
{
    static void Main()
    {
        Console.Write("Digite uma letra : ");
       string entrada1 = Console.ReadLine().ToLower();
        char resposta = char.Parse(entrada1);


            switch (resposta)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("Essa letra e vogal ");
                break;
            default:
                Console.WriteLine("Essa letra e uma consoante");
                break;
        }

    }
}
