// Определить, присутствует ли в заданном массиве, некоторое число

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

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            Console.WriteLine($"Element of array equals {find} exists! It's position is {position} ");
            break;
        }
        else Console.WriteLine($"Element of array equals {find} DOES NOT exists! ");
        index++;
    }
    return position;
    
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

//int [] array = new int[6];
int [] array = {1, 2, 32, 4, 5, 6};
PrintArray(array);
//FillArray(array);
int pos = IndexOf(array, 32);
Console.WriteLine(pos);

