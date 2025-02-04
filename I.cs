internal class Program
{
    static void Main()
    {
        Console.Write("Digite uma letra : ");
       string entrada1 = Console.ReadLine();


        if (int.TryParse(entrada1, out int resposta)) 
        {
            switch (resposta)
            {
                case 1:
                    Console.WriteLine("Segunda-Feira");
                    break;
                case 2:
                    Console.WriteLine("Terça-Feira");
                    break;
                case 3:
                    Console.WriteLine("Quarta-Feira");
                    break;
                case 4:
                    Console.WriteLine("Quinta-Feira");
                    break;
                case 5:
                    Console.WriteLine("Sexta-Feira");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Resposta inválida! Digite um número de 1 a 7.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida! Digite um número inteiro.");
        }
    }
}
