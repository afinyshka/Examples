// Показать числа Фибоначчи меньше заданного числа N

Console.WriteLine("Enter your number");
int number = int.Parse(Console.ReadLine() ?? "0");
int fibbonachi1 = 0;
int fibbonachi2 = 1;
int resultFib = 0;
Console.Write($"Fibbonachi number = ");
Console.Write($"{fibbonachi1} {fibbonachi2} ");

while (fibbonachi1 + fibbonachi2 < number)
{
    resultFib = fibbonachi1 + fibbonachi2;
    fibbonachi1 = fibbonachi2;
    fibbonachi2 = resultFib;
    Console.Write($"{resultFib} ");
}
Console.WriteLine();