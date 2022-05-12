// Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Введите пятизначное число: ");
//int number5 = int.Parse(Console.ReadLine() ?? "0");
// int d1 = number5/10000;
// int d2 = number5/1000%10;
// int d3 = number5/100%10;
// int d4 = number5/10%10;
// int d5 = number5%10;
// if (d1 == d5 && d2 == d4) Console.WriteLine($"Число {number5} палиндром");
// if (number5/10000 == number5%10 && number5/10%10 == number5/1000%10) Console.WriteLine($"Число {number5} палиндром");
// else Console.WriteLine($"Число {number5} не палиндром");
int count = int.Parse(Console.ReadLine() ?? "0"); 
int count2 = count;
int index = 0;
while ( count > 0)
{
    int digit = count % 10; // 
    index = index *10 + digit;
    count = count / 10;  
}
if ( index == count2) Console.WriteLine("Это палиндром");    
else Console.WriteLine("Это не палиндром");