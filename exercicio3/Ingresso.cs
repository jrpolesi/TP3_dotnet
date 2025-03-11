namespace exercicio3;

public class Ingresso
{
    /**
     * Nome do show, usado para identificar o nome do evento do ingresso.
     * É importante para identificar de forma legível o evento a qual o ingresso
     * se refere.
     */
    public string nomeDoShow;

    /**
     * Preço, indica o preço do ingresso. Este valor é importante para saber
     * quanto custa o ingresso.
     */
    public double preco;

    /**
     * Quantidade disponível, indica a quantidade de ingressos disponíveis.
     * Este valor é importante para fazer o gerenciamento de disponibilidade
     * e saber se ainda há ingressos disponíveis.
     */
    public int quantidadeDisponivel;

    public void AlterarPreco(double novoPreco)
    {
        this.preco = novoPreco;
    }

    public void AlterarQuantidade(int novaQuantidade)
    {
        this.quantidadeDisponivel = novaQuantidade;
    }

    public string ExibirInformacoes()
    {
        return $"Nome do show: {this.nomeDoShow}\n" +
               $"Preço: {this.preco}\n" +
               $"Quantidade disponível: {this.quantidadeDisponivel}";
    }
}