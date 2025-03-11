namespace exercicio10;

class Program
{
    static void Main(string[] args)
    {
        var circulo = new Circulo(10);
        Console.WriteLine($"Raio do círculo: {circulo.Raio:F2}");

        var esfera = new Esfera(10);
        Console.WriteLine($"Raio da esfera: {esfera.Raio:F2}");
    }
}