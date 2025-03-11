namespace exercicio7;

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

        Console.WriteLine("Nome do aluno: " + matricula.NomeDoAluno);
        Console.WriteLine("Curso: " + matricula.Curso);
        Console.WriteLine("Matrícula: " + matricula.NumeroMatricula);
        Console.WriteLine("Situação: " + matricula.Situacao);
        Console.WriteLine("Data da matrícula: " + matricula.DataInicial);
    }
}