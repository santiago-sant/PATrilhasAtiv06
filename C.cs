internal class Program
{
    static void Main()
    {

        Console.WriteLine("Insira sua data de nascimento :");
        DateTime.TryParse(Console.ReadLine(), out DateTime data1);
        DateTime dataAtual =  DateTime.Now;
        int diferenca  =   dataAtual.Year - data1.Year;
        Console.WriteLine("Voce tem : " + diferenca + " anos. ");
      
       
    }
}
