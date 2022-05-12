// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.WriteLine("Ведите координату x:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Ведите координату y:");
int y = int.Parse(Console.ReadLine());
if (x > 0 && y > 0 ) Console.WriteLine($"Число с координатами (х,y) принадлежит I четверти ");
else if (x > 0 && y < 0 ) Console.WriteLine($"Число с координатами (х,y) принадлежит II четверти ");
else if (x < 0 && y < 0 ) Console.WriteLine($"Число с координатами (х,y) принадлежит III четверти ");
else if (x < 0 && y > 0 ) Console.WriteLine($"Число с координатами (х,y) принадлежит IV четверти ");