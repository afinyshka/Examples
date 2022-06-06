// Показать натуральные числа от N до 1, N задано

int NumbersFromNumberToOne (int n)
{
    Console.WriteLine(n);
    if (n==1)return 1;
    else return NumbersFromNumberToOne(n-1);
}

NumbersFromNumberToOne(8);

void PrintNumber(int n)
{
    if(n<1)return;
    Console.Write (n + "");
    PrintNumber(n-1);
}
PrintNumber(10);