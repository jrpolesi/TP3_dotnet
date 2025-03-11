namespace exercicio12;

public class Circulo
{
    /**
     * Raio do círculo, é necessário pois a partir dele é possível calcular a área do círculo usando a fórmula (π * r²).
     */
    public double Raio;

    public Circulo(double raio)
    {
        Raio = raio;
    }

    public double CalcularArea()
    {
        return Math.PI * (Raio * Raio);
    }
}