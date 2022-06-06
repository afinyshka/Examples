// Показать натуральные числа от N до 1, N задано

int NumbersFromOneToNumber (int n)
{
    Console.WriteLine(n);
    if (n==1)return 1;
    else return NumbersFromOneToNumber(n-1);
}

NumbersFromOneToNumber(8);