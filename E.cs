internal class Program
{
    static void Main()
    {
        Console.WriteLine("ESOLHA A OPÇÃO '1' , '2' OU '3'");
        string entrada = Console.ReadLine();


        switch (entrada)
        {
            case "1":
                Console.WriteLine("Bom Dia! (:");
                break;
            case "2":
                Console.WriteLine("Boa Tarde! (:");
                break;
            case "3":
                Console.WriteLine("Boa Noite! (:");
                break;
            default:
                Console.WriteLine("Opção não existente");
                break;
        }
            
        
       
        
    }
}
