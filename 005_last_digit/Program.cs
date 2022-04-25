Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
int digit = a % 10;
Console.Write("Last digit:");
Console.WriteLine(digit);