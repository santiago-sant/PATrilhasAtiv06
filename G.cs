internal class Program
{
    static void Main()
    {
        Console.Write("Escolha uma dessas cores : 'Vermelho' , 'Azul' ou 'Verde' ");
        string entrada = (Console.ReadLine().ToLower());
       


        switch (entrada)
        {

            case "vermelho":
                Console.WriteLine("Bom dia! (;");
                break;
            case "azul":
                Console.WriteLine("Boa Tarde! (;");
                break;
            case "verde":
                Console.WriteLine("Boa Noite! (;");
                break;
            default:
                Console.WriteLine("Resposta Invalída!");
                break;
        }

    }
}
