// Найти максимальное из трех чисел.
Console.WriteLine("Введите последовательно три числа. Программа определит большее ");
Console.WriteLine("Введите значение первого числа ");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение второго числа ");
double numberB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение третьего числа ");
double numberC = Convert.ToDouble(Console.ReadLine());

double max = numberA;

if (numberA > max ) max = numberA;
if (numberB > max ) max = numberB;
if (numberC > max ) max = numberC;

Console.Write("Наибольшее число равно ");
Console.WriteLine(max);