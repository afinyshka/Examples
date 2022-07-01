// напечатать ноый массив где его элементы текст  и менее или равно 3 символам

string [] texset = {"hollo", "54", "s34l", "git", "876", };
Console.WriteLine($"number of elements = {texset.Length}");
int count=0;
for (int i=0; i<texset.Length; i++)
{
    if (texset[i].Length<=3)
    {
        Console.WriteLine(texset[i]);
        count++;
    }
}
Console.WriteLine($"count = {count} ");

string [] newTexset = new string [count];
for (int i=0; i<texset.Length; i++)
{
    int j=0;
    if (texset[i].Length<=3)
    {
        newTexset[j] = texset[i];
        Console.Write($"{newTexset[j]} ");
        j++;
    }
}
