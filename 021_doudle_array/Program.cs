// Показать двумерный массив размером m×n заполненный целыми числами


Console.WriteLine("Enter your number n");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter your number m");
int m = int.Parse(Console.ReadLine() ?? "0");
int [,] matrix21 = new int[n,m];
for (int row=0; row<n; row++)
{
    for (int column=0; column<m; column++)
    {
        matrix21[row, column] = new Random().Next(1,10);
    }
}
for (int row=0; row<n; row++)
{
    for (int column=0; column<m; column++)
    {
        Console.Write(matrix21[row, column] + " ");
    }
    Console.WriteLine();
}

// {
//     for (int column=0; column<m; column++)
//     {
//         matrix21[row, column] = new Random().Next(1,10);
//         Console.Write(matrix21[row, column] + " ");
//     }
//     Console.WriteLine();
// }