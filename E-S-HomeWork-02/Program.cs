// По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("По двум заданным числам проверим является ли первое квадратом второго ");
Console.WriteLine("Введите первое число ");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число ");
double numberB = Convert.ToDouble(Console.ReadLine());

if(numberB * numberB == numberA)
{
    Console.WriteLine($"Первое число *{numberA}* является квадратом второго числа *{numberB}*");
}
else
{
    Console.WriteLine($"Первое число *{numberA}* не является квадратом второго числа *{numberB}*");
}
