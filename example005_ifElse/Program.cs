Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "настя")
{
    Console.WriteLine("Привет, киса любимая!");
}
else
{
    Console.Write("Здравствуйте, ");
    Console.WriteLine(username);
}