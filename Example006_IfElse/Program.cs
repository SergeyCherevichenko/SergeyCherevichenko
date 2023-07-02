Console.WriteLine("Введите свое имя: ");
string username = Console.ReadLine();
if(username.ToLower() == "сергей")
{
    Console.WriteLine("Ура, это же Сергей!");
}
else
{
    Console.WriteLine("Привет " + username);
}
