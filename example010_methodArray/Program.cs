int [] array = {18, 52, 43, 54, 85, 76, 67, 85, 84};

int n = array.Length;
int find = 85;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
    Console.WriteLine (index);
    break;
    }
   // else Console.WriteLine("такого элемента массива нет");
    index++;
}