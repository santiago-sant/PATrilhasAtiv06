internal class Program
{
    static void Main()
    {

        Console.WriteLine("Insira a primeira data :");
        DateTime.TryParse(Console.ReadLine(), out DateTime data1);
          Console.WriteLine("Insira a segunda data :");
          DateTime.TryParse(Console.ReadLine(), out DateTime data2);
        TimeSpan diferenca  = data1 - data2;
        Console.WriteLine("diferença em dias é de :" + Math.Abs(diferenca.TotalDays));
      
       
    }
}
