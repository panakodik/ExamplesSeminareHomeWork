// Выяснить является ли число чётным
Console.WriteLine("Выяснить является ли число чётным");
int numberA = new Random().Next(1,100);

if(numberA % 2 == 0)
{
    Console.Write("Число ");
    Console.Write(numberA);
    Console.WriteLine(" четное");
}
else
{
    Console.Write("Число ");
    Console.Write(numberA);
    Console.WriteLine(" не четное");
}
