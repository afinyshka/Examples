// Показать таблицу квадратов чисел от 1 до N
int number = int.Parse(Console.ReadLine() ?? "0");
int number1 = 1;
int sum = 0;
Console.Write($"Summa numbers from 1 to {number}: ");
while (number1 <= number) 
{
    sum = sum + number1;
    number1++;
}
Console.WriteLine($"{sum} ");