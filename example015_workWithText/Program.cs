//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// при работе со строками можно обратиться непосредственно к символу, например
// string s = "qwerty"
//             012345
// s[3] // r        // обращаемся к третьему символу и получаем "r"

string replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;             //получаем длину строки 
    for (int i=0; i<length; i++)
    {
        if (text[i] == oldValue) result = result +  $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
string newText1 = replace(newText, 'с', 'С');
Console.WriteLine(newText1);
Console.WriteLine();
string newText2 = replace(newText1, 'к', 'К');
Console.WriteLine(newText2);
