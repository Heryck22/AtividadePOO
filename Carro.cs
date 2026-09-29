namespace AtividadePOO;

public class Carro : Veiculo
{
    public Carro(string modelo, int ano) : base(modelo, ano)
    {
    }

    public override void Acelerar()
    {
        Console.WriteLine($"{Modelo} Acelerou  rapido pelas ruas!");
        Console.WriteLine("--------------------");
    }
}