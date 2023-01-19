// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.Clear();
Console.WriteLine("Выясняем, кратно ли число заданному. Введите делитель ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число, кратность которыго нужно узнать ");
int numberB = int.Parse(Console.ReadLine());
if(numberB % numberA == 0)
{
    Console.WriteLine("Число " + numberB + " кратно " + numberA);
}
else
{
    int numberC = numberB % numberA;
    Console.WriteLine("Число " + numberB + " не кратно " + numberA + " с остатком " + numberC);
}