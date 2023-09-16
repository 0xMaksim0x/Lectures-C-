int GetNumber(string message)
{
    Console.Write($"Enter number {message} : ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int GetSum(int num)
{
    int sum = 0;
    fot (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

int numA = GetNumber("A");
int sum = GetSum(numA);
System.Console.WriteLine($"sum = {sum}");
