// 4 вида методов

// Вид 1

void Method1()
{
    Console.WriteLine("Author...");
}

Method1();

// Вид 2

void Method2(string msg)
{
    Console.WriteLine(msg);
}

Method2("Text message ");

// Вид 2.1

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21("Texts ", 4);
Method21(count: 4, msg: "Text ");

// Вид 3

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4

string Method4(int count, string c)
{
    int i = 0;
    //string result = "";
    string result = String.Empty;
    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);

// Цикл в цикле с for

for (int i = 2; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j} ");
    }
    Console.WriteLine();
}