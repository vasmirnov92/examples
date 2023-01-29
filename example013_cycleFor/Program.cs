// помимио цикла While, основным в разработке являестя цикл For
// он позволяет уменьшить количество строк когда
// рассомтрим его применение на примере предыдущей задачи с методами

// предыдущая задача для нашлядности:
// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(count: 4, text: "привет");
// Console.WriteLine(res);

string Method4(int count, string text)
{
    int i=0;
    string result = String.Empty;
    for (i=0; i<count; i++)
    {
        result = result + text;
    }
    return result;
}
string arg = Method4(count: 5, text: "Привет ");
Console.WriteLine(arg);

