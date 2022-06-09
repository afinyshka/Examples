// Найти сумму цифр числа

int SumOfDigits(int number)
{
    Console.WriteLine($"{number} {number%10} ");
    if (number < 1 ) return number;
    else return number%10 + SumOfDigits(number / 10);
    // return n < 10 ? number : number % 10 + dSumOfDigits( number / 10 );
    // 749356%10 + 74935%10 + 7493%10 + 749%10 + 74%10 + 7%10 + SumOfDigits(7 / 10);
    // 749356%10 + 74935%10 + 7493%10 + 749%10 + 74%10 + 7%10 + 0;
}
Console.WriteLine($"Summa = {SumOfDigits(749356)}" );