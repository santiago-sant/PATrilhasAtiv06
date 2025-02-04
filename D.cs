internal class Program
{
    static void Main()
    {
        Console.WriteLine("Insira o dia e mês (dd/MM):");
        string entrada = Console.ReadLine();

        if (DateTime.TryParseExact(entrada, "dd/MM", null, System.Globalization.DateTimeStyles.None, out DateTime data1))
        {
            switch (data1.ToString("dd/MM"))
            {
                case "01/01":
                    Console.WriteLine("Esse dia é feriado nacional: 'Ano Novo'");
                    break;
                case "21/04":
                    Console.WriteLine("Esse dia é feriado nacional: 'Tiradentes'");
                    break;
                case "01/05":
                    Console.WriteLine("Esse dia é feriado nacional: 'Dia do Trabalhador'");
                    break;
                case "07/07":
                    Console.WriteLine("Esse dia e feriado nacional: 'Independência do Brasil'");
                    break;
                case "12/08":
                    Console.WriteLine("Esse dia e feriado nacional: 'Nossa senhora aparecida");
                    break;
                case "02/11":
                    Console.WriteLine("Esse dia e feriado nacional: 'Finados'");
                    break;
                case "15/11":
                    Console.WriteLine("Esse dia e feriado nacional: 'Proclamação'");
                    break;
                case "20/11":
                    Console.WriteLine("Esse dia e feriado nacional: 'Consciência negra'");
                    break;
                case "25/12":
                    Console.WriteLine("Esse dia e feriado nacional: 'natal'");
                    break;
                default:
                    Console.WriteLine("Esse dia não é feriado");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Data inválida. Use o formato dd/MM.");
        }
    }
}
