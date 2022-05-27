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

//Показать первые N чисел Фибоначи  
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int a = 1; int b = 0; int result;
for (int i = 0; i < n; i++)
{
    result = a + b;
    Console.WriteLine(result + " ");
    a = b;
    b = result;
}

// Показать числа Фибоначчи меньше заданного числа N 
Console.Write("Введите число: "); 
int N = int.Parse(Console.ReadLine() ?? "");
int firstValue = 0;
int secondValue = 1;
int result1 = 0;
Console.Write($"{firstValue} {secondValue} ");
while (result1 > N)
{
    result1 = firstValue + secondValue;
    if (result1 > N) break; Console.Write(result1 + " ");
    firstValue = secondValue;
    secondValue = result1;
}