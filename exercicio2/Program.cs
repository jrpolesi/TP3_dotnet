namespace exercicio2;

class Program
{
    static void Main(string[] args)
    {
        var ingresso = new Ingresso
        {
            nomeDoShow = "Show do João",
            preco = 99.99,
            quantidadeDisponivel = 50
        };

        Console.WriteLine($"Nome do show: {ingresso.nomeDoShow}");
        Console.WriteLine($"Preço: {ingresso.preco}");
        Console.WriteLine($"Quantidade disponível: {ingresso.quantidadeDisponivel}");
    }
}