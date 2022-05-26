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

//from Alexandra:

// Показать двумерный массив размером m×n заполненный целыми числами
void PrintArray(int[,] matr)
{
    for (int i =0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();    
    }
} 

void FillArray(int[,] matr)
{
    for (int i =0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,10); 
        }  
    }
} 
Console.WriteLine("Введите число m, n: ");
int m = int.Parse(Console.ReadLine()??"0");
int n = int.Parse(Console.ReadLine()??"0");

int[,] matrix = new int [m,n];

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);