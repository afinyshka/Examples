// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Ведите координату x:");
int x = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Ведите координату y:");
int y = int.Parse(Console.ReadLine() ?? "0");
if (x > 0 && y > 0 ) Console.WriteLine($"Число с координатами ({x},{y}) принадлежит I четверти ");
else if (x > 0 && y < 0 ) Console.WriteLine($"Число с координатами ({x},{y}) принадлежит II четверти ");
else if (x < 0 && y < 0 ) Console.WriteLine($"Число с координатами ({x},{y}) принадлежит III четверти ");
else if (x < 0 && y > 0 ) Console.WriteLine($"Число с координатами ({x},{y}) принадлежит IV четверти ");
else Console.WriteLine($"Ошибка ввода, координата ({x},{y}) не принадлежит ни одной плоскости ");