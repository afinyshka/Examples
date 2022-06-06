// Показать натуральные числа от 1 до N, N задано

int NumbersFromOneToNumber (int start, int finish)
{
    Console.WriteLine($"number = {start}");
    if (start==finish)return finish;
    else return NumbersFromOneToNumber(start+1, finish);
}

NumbersFromOneToNumber(1, 6);
