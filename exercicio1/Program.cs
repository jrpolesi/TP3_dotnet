namespace exercicio1;

class Program
{
    static void Main(string[] args)
    {
        // Objeto é uma instância criada a partir de uma classe.
        // Criamos um objeto da classe "Pessoa" e atribuímos seus atributos.
        var pessoa = new Pessoa { Nome = "João", Idade = 25 };

        Console.WriteLine($"Idade atual: {pessoa.Idade}");

        // Chamamos o método "envelhecer" para modificar o estado do objeto.
        pessoa.Envelhecer();

        Console.WriteLine($"Idade atual: {pessoa.Idade}");
    }
}