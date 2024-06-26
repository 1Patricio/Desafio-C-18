public abstract class Veiculo{ //classe base que vai apenas servir de base mas não iremos instanciar objeto
    protected int velocidade;

    public void setarVelocidade(int valor){ //Método Set
        velocidade = valor; //vamos atribuir variavel do program.cs para o atributo velocidade
    }
    public abstract void Acelerar(); //método abstrato com tipo de retorno void e com nome acelerar
    public abstract void Frear();
    public void ExibirVelocidade()
    {
        Console.WriteLine($"A velocidade atual do veiculo é {velocidade}KM/h");
    }
}