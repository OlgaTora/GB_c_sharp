Console.WriteLine("Введите имя пользователя:");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Привет, красавица!");

}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}
;