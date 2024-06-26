Carro c1 = new Carro();
c1.setarVelocidade(20); //setando a velocidade de 20km/h

Moto m1 = new Moto();
m1.setarVelocidade(50);

//criar arrai de inteiros de tamanho 5
int[] notas = new int [5];
//atribui valor ao array
notas[0] = 90;
notas[1] = 85;
notas[2] = 89;
notas[3] = 92;
notas[4] = 95;

//acessando e imprimindo as notas dos alunos
for (int i = 0; i < notas.Length; i++) //.lenght é o tamanho do array
{
    Console.WriteLine($"Nota do Aluno {i + 1}: {notas[i]}");
}


//Cria uma list vazia de Veiculos
List<Veiculo> veiculos = new List<Veiculo>(); //mesmo Veiculo sendo uma classe abstrata, podemos usar para fazer lista

//Adicionar veiculos
veiculos.Add(c1);
veiculos.Add(m1);

// //Remover veiculos
// veiculos.Remove(c1);

foreach (var veiculo in veiculos) //tipo o for
{  

    veiculo.Acelerar();
    veiculo.ExibirVelocidade();
    veiculo.Frear();
    veiculo.ExibirVelocidade();

// vai substituir isso
    // c1.Acelerar();
    // c1.ExibirVelocidade();
    // c1.Frear();
    // c1.ExibirVelocidade();

    // m1.Acelerar();
    // m1.ExibirVelocidade();
    // m1.Frear();
    // m1.ExibirVelocidade();
}