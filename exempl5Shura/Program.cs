Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "шура")
{
    Console.WriteLine("Ура это же Шура!!!!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}