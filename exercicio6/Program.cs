namespace exercicio6;

class Program
{
    static void Main(string[] args)
    {
        var ingresso = new Ingresso(
            "O Meu Grande Show",
            100.25,
            1050
        );

        var infoDoIngresso = ingresso.ExibirInformacoes();
        Console.WriteLine(infoDoIngresso);

        /*
            Usar o construtor com parâmetros garante que o objeto seja
            instanciado com os atributos necessários, reduz a quantidade
            de código para inicializar um objeto, deixa o código mais legível,
            pois obriga informar os atributos todos juntos, e por fim, ajuda
            na criação de objetos imutáveis.
         */
    }
}