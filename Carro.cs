public class Carro : Veiculo //classe carro herda informações da classe veiculo
{
    public override void Acelerar() //override utilizada quando vamos subescrever um método (é só questão de identação)
    {
        velocidade += 10;
        Console.WriteLine("Carro acelerando");
    }

    public override void Frear() //override utilizada quando vamos subescrever um método (é só questão de identação)
    {
        velocidade -= 5;
        Console.WriteLine("Carro Freando");
    }
}