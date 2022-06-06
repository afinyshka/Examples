// Показать натуральные числа от 1 до N, N задано

int NumbersFromOneToNumber (int start, int finish)
{
    Console.WriteLine($"number = {start}");
    if (start==finish)return finish;
    else return NumbersFromOneToNumber(start+1, finish);
}
//NumbersFromOneToNumber(1, 6);
Console.WriteLine($"Numbers from 1 to {NumbersFromOneToNumber(1,6)}");

Console.WriteLine();
void NumbersFromOneToNumber1 (int start, int finish)
{
    Console.WriteLine($"number = {start}");
    if (start==finish)return;
    else NumbersFromOneToNumber(start+1, finish);
}
NumbersFromOneToNumber1(1, 4);
int n = NumbersFromOneToNumber(1,3);
Console.WriteLine(n);