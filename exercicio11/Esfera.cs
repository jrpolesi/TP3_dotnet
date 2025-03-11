namespace exercicio11;

public class Esfera
{
    /**
     * Raio da esfera, é necessário pois a partir dele é possível calcular o volume da esfera usando a fórmula (4/3 * π * r³).
     */
    public double Raio;

    public Esfera(double raio)
    {
        Raio = raio;
    }

    public double CalcularVolume()
    {
        return (4.0 / 3.0) * Math.PI * (Raio * Raio * Raio);
    }
}