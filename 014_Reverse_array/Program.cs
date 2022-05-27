// Написать программу замену элементов массива на противоположные

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine("enter array numbers: ");
        collection[index] = int.Parse(Console.ReadLine() ?? "0");
        index++;
    }
}

int[]array = {1, 2, 7, -4, 5};

void ReverseArray(int[] collect)
{
    int count = collect.Length;
    int position = 0;
    while (position<count)
    {
        int [] array1 = new int[collect.Length];
        array1[position] = array[-position];
        Console.WriteLine(collect[position]);
        position++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine(col[-position]);
        position++;
    }
}

// Console.WriteLine(array[0]*-1);
// Console.WriteLine(array[1]*-1);
// Console.WriteLine(array[2]*-1);
// Console.WriteLine(array[3]*-1);
// Console.WriteLine(array[4]*-1);
// Console.WriteLine(array[5]*-1);

PrintArray(array);
PrintArray(array);