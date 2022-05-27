// Найти сумму чисел одномерного массива стоящих на нечетной позиции

Console.Clear();
//int [] array15 = {3, 1, 2, 0, 4, 1, 6, 1};
Console.WriteLine("Enter numbers of elements ");
int numElem = int.Parse(Console.ReadLine());
int [] array15 = new int [numElem];
for (int i=0; i<array15.Length; i++) array15[i] = new Random().Next(1,10);
int sum = 0;
for (int i=0; i<array15.Length; i++) Console.Write($"{array15[i]} ");
Console.WriteLine();
for (int i=0; i<array15.Length; i = i + 2) sum = sum + array15[i];
Console.WriteLine();
Console.WriteLine($"Summa elements ot the array equals {sum}");