// Задать массив из 8 элементов и вывести их на экран
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        //collection[index] = new Random().Next(1,10);
        Console.WriteLine("enter array numbers: ");
        collection[index] = int.Parse(Console.ReadLine() ?? "0");
        index++;
    }
}


void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int [] array = new int[8];
Console.WriteLine("enter array numbers: ");
array[0] = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("enter array numbers: ");
array[1] = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("enter array numbers: ");
array[2] = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("enter array numbers: ");
array[3] = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("enter array numbers: ");
array[4] = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("enter array numbers: ");
array[5] = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("enter array numbers: ");
array[6] = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("enter array numbers: ");
array[7] = int.Parse(Console.ReadLine() ?? "0");

//FillArray(array);
Console.WriteLine();

Console.WriteLine($"array = {array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}");

// Console.WriteLine(array[0]);
// Console.WriteLine(array[1]);
// Console.WriteLine(array[2]);
// Console.WriteLine(array[3]);
// Console.WriteLine(array[4]);
// Console.WriteLine(array[5]);
// Console.WriteLine(array[6]);
// Console.WriteLine(array[7]);

//PrintArray(array);

// from Stoyn
//Console.Clear();
Console.WriteLine("Задать массив из 8 элементов и вывести их на экран");
Console.Write("Введите размер массива: ");
int arrSize =  int.Parse(Console.ReadLine() ?? "0"); 
int[] array1 = new int[arrSize];
for (int i=0; i<arrSize; i++) array1[i] = new Random().Next(0,100);
int count = 1;
Console.Write($"array1 = ");
foreach (int k in array1)
{
    //Console.WriteLine($"{count} элемент массива - {k}");
    Console.Write($"{k}, ");
    count++; 
}
Console.WriteLine();