//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Enter number: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

int result = num / 2;

if (result == num)
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}
