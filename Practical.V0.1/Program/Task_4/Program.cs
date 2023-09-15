//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Enter number: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

int num0 = 1;

while (num0 <= num)
{
    if (num0 % 2 ==0)
{
    Console.WriteLine(num0);

}
num0++;
}