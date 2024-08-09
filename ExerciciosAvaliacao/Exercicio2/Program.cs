string[] listaNomes = new string[5];

for (int i = 0; i < 5; i++)
{

    Console.WriteLine("Insira um nome");
    listaNomes[i] = Console.ReadLine();
}

   Array.Sort(listaNomes);
Console.Clear();

foreach (var nomes in listaNomes)
{
    Console.WriteLine(nomes);
}
