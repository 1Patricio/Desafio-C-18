public class Moto : Veiculo
{
    public override void Acelerar() //override utilizada quando vamos subescrever um método (é só questão de identação)
    {
        velocidade += 15;
        Console.WriteLine("Moto acelerando");
    }

    public override void Frear() //override utilizada quando vamos subescrever um método (é só questão de identação)
    {
        velocidade -= 10;
        Console.WriteLine("Moto Freando");
    }
}