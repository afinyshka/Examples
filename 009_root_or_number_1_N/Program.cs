// Показать таблицу квадратов чисел от 1 до N
Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int number1 = 1;
Console.Write($"Quares from 1 to {number}: ");
while (number1 <= number) 
{
    Console.Write($"{number1*number1} ");
    number1++;
}
