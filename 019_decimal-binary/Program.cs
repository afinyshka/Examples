// Написать программу преобразования десятичного числа в двоичное

Console.WriteLine("Enter decimal number: ");
int number10 = int.Parse(Console.ReadLine() ?? "0");
string number2 = "";
while (number10 > 0 )
{
    number2 = number10%2 + number2;
    number10 = number10/2;
}
Console.WriteLine($"number2 = {number2} ");

int totalNumber = int.Parse(number2);
Console.WriteLine($"number2.2 = {number2} ");

// int number2 = 0;
// while (number10 > 0 )
// {
//     number2 = number10%2 + number2*10;
//     number10 = number10/2;
// }
// Console.WriteLine($"number2 = {number2} ");

//от коллеги:
// 2. Перевести число в двоичное
// Console.Write("Введите число: ");
// int Number = int.Parse(Console.ReadLine() ?? "0");
// int Bit = Number % 2;
// int NewNumber = Bit;
// Number = Number / 2;
// int i = 1;
// while (Number > 0)
// {
//     Bit = Number % 2;
//     Number = Number / 2;
//     NewNumber = NewNumber + Bit * (int)Math.Pow(10,i);
//     i++;
// }
// Console.WriteLine(NewNumber);