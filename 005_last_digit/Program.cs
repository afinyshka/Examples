Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
if (a > 99 && a<1000)
{
    int digit = a % 10;
Console.Write("Последний знак: ");
Console.WriteLine(digit);
}
else
{
Console.WriteLine("Число не трехзначное ");
}