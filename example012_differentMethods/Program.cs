// Условно методы можно разделит на 4 группы:
// 1 методы, которые не получают на вход аргументы и ничего не возвращают
// 2 методы, которые получают на вход аргументы, но ничего не возвращают
// первые 2 группы - void методы
// 3 методы, которые могут что-то возвращать, но не принимают на вход аргументы
// 4 методы, которые получают на вход аргумменты и что-то возвращают

// 1 вид
void Method1()
{
    Console.WriteLine("Автор Василий");
}

//Method1();        закомментируем вызов метода, чтобы не было путаницы

// 2 вид
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Hello World!");         закомментируем вызов метода, чтобы не было путаницы

void Method21(string msg, int count)
{
    int i=0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
//Method21(msg: "Сообщение", count: 5);       //в случае, когда у нас несколько аргументов и нало к ним обратиться, делают так


// 3 вид
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

// 4 вид
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(count: 4, text: "привет");
Console.WriteLine(res);