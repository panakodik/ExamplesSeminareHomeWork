//Показать последнюю цифру трёхзначного числа
Console.Write("Введите трехзначное число ");
int number = int.Parse(Console.ReadLine());
int n = number % 10;
Console.WriteLine("Последняя цифра трехзначного числа: " + n);