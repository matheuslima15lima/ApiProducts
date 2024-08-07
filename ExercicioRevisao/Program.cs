// See https://aka.ms/new-console-template for more information
Console.WriteLine("Nota");
int Nota = int.Parse(Console.ReadLine());

if (Nota == 6){
    Console.WriteLine("recuperacao");
}

else if(Nota <= 5){
    Console.WriteLine("Reprovado");
}

else{
    Console.WriteLine("PASSOU!!!");
}

