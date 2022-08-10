Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "артём")
{
    Console.WriteLine("Ура, это же Артём");
}
else
{
    Console.Write ("Привет, ");
    Console.WriteLine(username);
}