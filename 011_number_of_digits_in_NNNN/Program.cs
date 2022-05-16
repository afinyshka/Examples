// Определить количество цифр в числе
Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int tmp = number;
int count = 0;
while (number > 0) 
{
    number = number/10;
    count++;
}
Console.WriteLine($"Number of digits of {tmp} = {count} ");