//Напишите программу, которая принимает на вход
//координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
//номер четверти плоскости, в которой находится эта
//точка.

int GetNumber(string message)
{
    Console.Write($"Enter number {message} : ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void Show(int x, int y)

{
    if (x > 0 && y > 0)
    {
        System.Console.WriteLine("1 четверть");
    }
    else if (x < 0 && y > 0)
    {
        System.Console.WriteLine("2 четверть");
    }
    else if (x < 0 && y < 0)
    {
        System.Console.WriteLine("3 четверть");
    }
    else if (x > 0 && y < 0)
    {
        System.Console.WriteLine("4 четверть");
    }
    else if (x == 0 || y == 0)
    {
        Console.WriteLine("X ≠ 0 и Y ≠ 0 ");
    }
}

int numX = GetNumber("X");
int numY = GetNumber("Y");

Show(numX, numY);
