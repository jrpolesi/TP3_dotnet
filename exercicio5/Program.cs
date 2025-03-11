namespace exercicio5;

class Program
{
    static void Main(string[] args)
    {
        var ingresso = new Ingresso();

        ingresso.SetNomeDoShow("Meu Show");
        ingresso.SetPreco(200.0);
        ingresso.SetQuantidadeDisponivel(10);

        Console.WriteLine("Nome do Show: " + ingresso.GetNomeDoShow());
        Console.WriteLine("Preço: " + ingresso.GetPreco());
        Console.WriteLine("Quantidade Disponível: " + ingresso.GetQuantidadeDisponivel());

        /*
            O uso de getters e setters permite encapsular os atributos de uma classe,
            adicionando lógica de acesso e modificação, como validações e tratamento
            de exceções, dessa forma, contribuindo para a consistência dos dados.

            Além disso, getters e setters, criam um uníco ponto de acesso e
            modificação dos atributos, ajudando em alterações futuras sem a
            necessidade de alterar o código em diversos pontos, e facilitando
            o log de modificação de atributos.
         */
    }
}