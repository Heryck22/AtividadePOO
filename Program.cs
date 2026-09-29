namespace AtividadePOO;

internal class Program
{
    private static void Main(string[] args)
    {
        Veiculo[] veiculos =
        [
            new Carro("Carro", 2999),
            new Moto("Moto", 2029),
            new Caminhao("Caminhao", 2080)
        ];
        foreach (var veiculo in veiculos)
        {
            veiculo.Ligar();
            veiculo.Acelerar();
        }
    }
}