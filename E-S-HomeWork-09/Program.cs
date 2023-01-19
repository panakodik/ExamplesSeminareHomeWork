// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int number = new Random().Next(10,99);
Console.WriteLine("Дано число " + number);
int a = number % 10;
int b = number % 100 / 10;
if(a > b)
{
    Console.WriteLine("Наибольшая цифра числа " + a);
}
else
{
    Console.WriteLine("Наибольшая цифра числа " + b);
}