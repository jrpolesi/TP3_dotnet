namespace exercicio9;

class Program
{
    static void Main(string[] args)
    {
        var matricula = new Matricula(
            "João",
            "Engenharia de Software",
            123456,
            "Ativa",
            "2025-02-03"
        );

        Console.WriteLine(matricula.ExibirInformacoes());

        Console.WriteLine("\nTrancando matrícula...");

        matricula.Trancar();
        Console.WriteLine(matricula.ExibirInformacoes());

        Console.WriteLine("\nReativando matrícula...");
        matricula.Reativar();
        Console.WriteLine(matricula.ExibirInformacoes());
    }
}