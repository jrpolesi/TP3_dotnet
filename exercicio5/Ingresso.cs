namespace exercicio5;

public class Ingresso
{
    /**
     * Nome do show, usado para identificar o nome do evento do ingresso.
     * É importante para identificar de forma legível o evento a qual o ingresso
     * se refere.
     */
    private string nomeDoShow;

    /**
     * Preço, indica o preço do ingresso. Este valor é importante para saber
     * quanto custa o ingresso.
     */
    private double preco;

    /**
     * Quantidade disponível, indica a quantidade de ingressos disponíveis.
     * Este valor é importante para fazer o gerenciamento de disponibilidade
     * e saber se ainda há ingressos disponíveis.
     */
    private int quantidadeDisponivel;

    public string GetNomeDoShow()
    {
        return this.nomeDoShow;
    }

    public double GetPreco()
    {
        return this.preco;
    }

    public int GetQuantidadeDisponivel()
    {
        return this.quantidadeDisponivel;
    }
    
    public void SetNomeDoShow(string novoNome)
    {
        this.nomeDoShow = novoNome;
    }
    
    public void SetPreco(double novoPreco)
    {
        this.preco = novoPreco;
    }
    
    public void SetQuantidadeDisponivel(int novaQtd)
    {
        this.quantidadeDisponivel = novaQtd;
    }
    
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
        return $"Nome do show: {this.GetNomeDoShow()}\n" +
               $"Preço: {this.GetPreco()}\n" +
               $"Quantidade disponível: {this.GetQuantidadeDisponivel()}";
    }
}