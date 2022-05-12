// Выяснить, кратно ли число 7 или 23:
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number%7 == 0 || number%23 == 0) Console.WriteLine($"Число {number} кратно числу 7 или 23 ");
//else if (number%23 == 0) Console.WriteLine($"Число {number} кратно числу 23 ");
else 
{
    Console.WriteLine($"Число {number} не кратно 7 или 23");
}