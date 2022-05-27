// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.Clear();
double [] array17 = {9.53, 6.3, 2.5, 0.3, 0.1345};
for (int i=0; i<array17.Length; i++) Console.Write($"{array17[i]} ");
Console.WriteLine();
double min = array17[0];
for (int i=0; i<array17.Length; i++)
{
    if (array17[i] < min) min = array17[i];
}
Console.WriteLine($"min = {min}");

double max= array17[0];
for (int i=0; i<array17.Length-1; i++)
{
    if (array17[i] > max) max = array17[i];
}
Console.WriteLine($"max = {max}");
Console.WriteLine($"Difference between max and min elements of array is: {max-min}");

/// Найдите разницу между максимальным и минимальным элементом  
Console.Write("Введите размер массива: ");  
int Number = int.Parse(Console.ReadLine() ?? "0"); 
double[] arr = new double[Number];  
for (int index = 0; index < Number; index++)
{    arr[index] = new Random().NextDouble() * 10;
     arr[index] = Math.Round(arr[index],2); //округляет до 2 знаков     
     Console.Write($"{arr[index]} "); 
} 
Console.WriteLine("");  
int mini = 0; 
int maxi = 0; 
for (int index = 0; index < arr.Length; index++) 
{     
    if (arr[index] < arr[mini]) mini = index;     
    else if (arr[index] > arr[maxi]) maxi = index;  
}
Console.WriteLine($"Разница между {arr[maxi]} и {arr[mini]} = {arr[maxi] - arr[mini]}");