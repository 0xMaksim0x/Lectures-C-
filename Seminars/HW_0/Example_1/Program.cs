
Console.WriteLine("Enter number : ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.WriteLine("Enter number : ");
strNum = Console.ReadLine();
int num2 = int.Parse(strNum);

int sqr = num2 * num2;

if (sqr == num1)
{
System.Console.WriteLine("Да");
}
else
{
    System.Console.WriteLine("Нет");
}