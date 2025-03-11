namespace exercicio12;

class Program
{
    static void Main(string[] args)
    {
        var circulo = new Circulo(3.0);
        var esfera = new Esfera(5.0);

        var areaDoCirculo = circulo.CalcularArea();
        var volumeDaEsfera = esfera.CalcularVolume();

        Console.WriteLine($"Área do círculo: {areaDoCirculo:F2}");
        Console.WriteLine($"Volume da esfera: {volumeDaEsfera:F2}");
    }
}