using System.Runtime.InteropServices.Marshalling;

int n ;
Console.WriteLine("Informe um numero");
n= int.Parse(Console.ReadLine());

if((n%2) == 0){
        Console.WriteLine("par");
}

else if((n%2) != 0){
    Console.WriteLine("impar");
}

else{
    Console.WriteLine("NUmero invalido");
}