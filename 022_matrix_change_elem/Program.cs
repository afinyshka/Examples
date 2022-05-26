// В двумерном массиве n×k заменить четные элементы на противоположные

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
Console.WriteLine();
for (int row=0; row<n; row++)
{
    for (int column=0; column<m; column++)
    {
        if (matrix21[row, column]%2==0) matrix21[row, column] = matrix21[row, column] * -1;
        Console.Write(matrix21[row, column] + " ");
    }
    Console.WriteLine();
}

//В двумерном массиве n×k заменить четные элементы на противоположные
void FillArray(int[,] array)
{
    Random rnd           = new Random();
    int    rowsLength    = array.GetLength(0);
    int    columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            array[i,j] = rnd.Next(-100,101);
        }       
    }
}
//--------------------------------------------------------------------------------------------+
void ChangeEvenElements(int[,] array)
{
    int    rowsLength    = array.GetLength(0);
    int    columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            if(array[i,j]%2 == 0) array[i,j] = -array[i,j];
        }       
    }
}
//--------------------------------------------------------------------------------------------+
void PrintArray(int[,] array)
{
    int    rowsLength    = array.GetLength(0);
    int    columns