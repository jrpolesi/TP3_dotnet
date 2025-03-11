namespace exercicio4;

class Program
{
    static void Main(string[] args)
    {
        var ingresso = new Ingresso
        {
            nomeDoShow = "Show do João",
            preco = 149.50,
            quantidadeDisponivel = 150
        };

        Console.WriteLine($"Nome do show: {ingresso.nomeDoShow}");
        Console.WriteLine($"Preço: {ingresso.preco}");
        Console.WriteLine($"Quantidade disponível: {ingresso.quantidadeDisponivel}");

        Console.WriteLine("\nAlterando preço e quantidade...");
        ingresso.AlterarPreco(129.99);
        ingresso.AlterarQuantidade(15);

        var infoDoIngresso = ingresso.ExibirInformacoes();
        Console.WriteLine(infoDoIngresso);
    }
}