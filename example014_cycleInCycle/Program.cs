// классической демонстарцией цикла в цикле вляется демонтарация таблицы умножения на экран

for (int i=2; i<=10; i++)
{
    for (int j=2; j<=10; j++)
    {
        Console.WriteLine($"{i} X {j} = {i*j}");
    }
    Console.WriteLine();
}
