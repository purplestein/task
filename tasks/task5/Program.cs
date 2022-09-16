Console.Write("Введите имя ");
string username = Console.ReadLine();

if(username.ToLower() == "саша")
{
    Console.WriteLine("Hi sasha");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}