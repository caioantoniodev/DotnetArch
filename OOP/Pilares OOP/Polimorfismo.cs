namespace OOP.Pilares_OOP;

public class CafeteiraEspressa : Eletrodomestico
{
    public CafeteiraEspressa(string nome, int tensao) 
        : base(nome, tensao) {}

    public CafeteiraEspressa()
        : base("Padrao", 220) {}
    
    private static void AquecerAgua() {}
    
    private static void MoerGraos() {}

    public void PrepararCafe()
    {
        Testar();
        AquecerAgua();
        MoerGraos();
    }
    
    public override void Ligar()
    {
        // Verificar recipiente de agua
    }

    public override void Desligar()
    {
        // Resfriar aquecedor
    }

    public override void Testar()
    {
        // teste do equipamento
    }
}