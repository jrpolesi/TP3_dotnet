namespace exercicio11;

class Program
{
    static void Main(string[] args)
    {
        var circulo = new Circulo(10);
        var areaDoCirculo = circulo.CalcularArea();
        
        Console.WriteLine($"Raio do círculo: {circulo.Raio:F2}");
        Console.WriteLine($"Área do círculo: {areaDoCirculo:F2}");

        var esfera = new Esfera(5.5);
        var volumeDaEsfera = esfera.CalcularVolume();
        
        Console.WriteLine($"Raio da esfera: {esfera.Raio:F2}");
        Console.WriteLine($"Volume da esfera: {volumeDaEsfera:F2}");
    }
}