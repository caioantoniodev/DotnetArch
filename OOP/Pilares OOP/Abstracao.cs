namespace OOP.Pilares_OOP;

public abstract class Eletrodomestico
{
    private readonly string _nome;
    private readonly int _tensao;

    protected Eletrodomestico(string nome, int tensao)
    {
        _nome = nome;
        _tensao = tensao;
    }

    public abstract void Ligar();
    public abstract void Desligar();
}