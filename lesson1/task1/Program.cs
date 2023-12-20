int i1 = 10;
int i2 = 10;

if (i1 > i2)
{
    Console.Write("Первое число ");
    Console.Write(i1);
    Console.Write(" больше, чем второе число ");
    Console.Write(i2);
}
else
{
    if (i1 < i2)
    {
        Console.Write("Второе число ");
        Console.Write(i2);
        Console.Write(" больше, чем первое число ");
        Console.Write(i1);
    }
    else
    {
        Console.Write("Первое число ");
        Console.Write(i1);
        Console.Write(" равно второму числу ");
        Console.Write(i2);
    }
}