namespace exercicio8;

public class Matricula
{
    public string NomeDoAluno;
    public string Curso;
    public int NumeroMatricula;
    public string Situacao;
    public string DataInicial;

    public Matricula(string nomeDoAluno, string curso, int numeroMatricula, string situacao, string dataInicial)
    {
        NomeDoAluno = nomeDoAluno;
        Curso = curso;
        NumeroMatricula = numeroMatricula;
        Situacao = situacao;
        DataInicial = dataInicial;
    }

    public void Trancar()
    {
        Situacao = "Trancada";
    }

    public void Reativar()
    {
        Situacao = "Ativa";
    }

    public string ExibirInformacoes()
    {
        return $"Nome do aluno: {NomeDoAluno}\n" +
               $"Curso: {Curso}\n" +
               $"Situação atual: {Situacao}\n" +
               $"Data inicial: {DataInicial}";
    }
}