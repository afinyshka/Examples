// Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int number1 = 1;
int product = 1;
Console.Write($"Product numbers from 1 to {number}: ");
while (number1 <= number) 
{
    product = product * number1;
    number1++;
}
Console.WriteLine($"{product} ");