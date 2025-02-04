internal class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        string entrada = Console.ReadLine();
        int numero;

        if (int.TryParse(entrada, out numero))
        {
            switch (numero)
            {
                case int n when n < 0:
                    Console.WriteLine("Seu número é negativo.");
                    break;

                case int n when n > 0:
                    Console.WriteLine("Seu número é positivo.");
                    break;

                default:
                    Console.WriteLine("Seu número é igual a zero.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
        }
    }
}
