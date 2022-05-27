// Выяснить являются ли три числа сторонами треугольника

Console.WriteLine("Enter first number a: ");
int a = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter second number b: ");
int b = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter third number c: ");
int c = int.Parse(Console.ReadLine() ?? "0");
if ((a+b)>c && (a+c)>b && (b+c)>a ) Console.WriteLine("This is a triangle ");
else Console.WriteLine("This is NOT a triangle ");

if (a*a+b*b==c*c) Console.WriteLine("This is square triangle ");
else if (a*a+c*c==b*b) Console.WriteLine("This is square triangle ");
else if (b*b+c*c==a*a) Console.WriteLine("This is square triangle ");
else Console.WriteLine ("This is NOT a square triangle ");