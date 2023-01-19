//Показать вторую цифру трёхзначного числа
Console.Write("Введите трехзначное число ");
int number = int.Parse(Console.ReadLine());
int n = number % 100 / 10;
Console.WriteLine("Вторая цифра трехзначного числа: " + n);