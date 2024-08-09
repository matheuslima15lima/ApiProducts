using System.ComponentModel;
// estancia o metodo Random
Random rand = new Random();

//cria uma variavel que vai receber um valor aleatorio entre 1 e 10
int randomizado = rand.Next(1, 10);

//cria uma variavel para armazenar as tentativas
int tentativas = 0;

//declara a variavel que vai guardar o valor do numero digitado
int n;

do
{

    Console.WriteLine("Adivinhe o numero");
    n = int.Parse(Console.ReadLine()!);

    // a cada erro se adiciona uma tentativa
    tentativas++;
} while (randomizado != n);

Console.WriteLine($"TENTATIVAS:{tentativas}");