namespace AtividadePOO;

public class Carro : Veiculo
{
    public Carro(string modelo, int ano) : base(modelo, ano)
    {
    }

    public override void Acelerar()
    {
        Console.WriteLine($"{Modelo} acelerou rapido pelas ruas!");
        Console.WriteLine("--------------------");
    }
}