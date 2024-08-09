
using System.Net.Http.Headers;

float [] notasAluno1 =[10, 9, 6];
float [] notasAluno2 =[10, 9, 6];
float [] notasAluno3 =[10, 9, 6];

string [] alunos =["Matheus", "Guilherme", "Vitor"];
float CalcularMedia(float x , float y, float z){
   
  return(x + y + z)/3;
}
foreach (var item in alunos)
{
    float media = CalcularMedia(notasAluno1[0], notasAluno1[1], notasAluno1[2]);
    bool aprovado;
    if(media >= 7.0){
        aprovado= true;
    }
    else{
        aprovado = false;
    }
}

// string [] disciplinas = ["Português", "Matematica", "Geografia"];
// int n;
// Console.WriteLine($"{media}");
// n = int.Parse(Console.ReadLine());

//notas.(n);
