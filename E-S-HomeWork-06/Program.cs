// Показать четные числа от 1 до N
int n = 1;
Console.Write("Введите конечное число ");
int m = int.Parse(Console.ReadLine());
if(n == 1)
{
    n += 1;
}
while(n <= m)
{
    Console.Write( n + " " );
    n += 2;
}
Console.WriteLine();
    Console.WriteLine("Все четные числа заданного диапазона");
