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

FillArray(array);
Console.WriteLine();
PrintArray(array);