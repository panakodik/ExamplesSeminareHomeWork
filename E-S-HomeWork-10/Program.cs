// Удалить вторую цифру трёхзначного числа
Console.Clear();
int number = new Random().Next(100,999);
Console.WriteLine("Дано число " + number);
int a = number % 10;
int b = number % 100 / 10;
int c = number % 1000 / 100;
int d = c * 10 + a;
Console.WriteLine("Стираем вторую цифру из числа и получаем " + d);
