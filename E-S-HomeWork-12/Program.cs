// Найти третью цифру числа или сообщить, что её нет
Console.Clear();
int number = new Random().Next(1,1000);
Console.WriteLine("Дано число " + number);
int a = number % 10;
int b = number % 1000 / 100;
if(b > 0)
{
    Console.WriteLine("Третья цифра числа слева направо " + b);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}