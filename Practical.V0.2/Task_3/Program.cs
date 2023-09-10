//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.Write("Enter number: ");
string strNum = Console.ReadLine();
int WeekDay = int.Parse(strNum);

if(WeekDay==1)
{
    Console.WriteLine("Нет");
}
if(WeekDay==2)
{
    Console.WriteLine("Нет");
}
if(WeekDay==3)
{
    Console.WriteLine("Нет");
}
if(WeekDay==4)
{
    Console.WriteLine("Нет");
}
if(WeekDay==5)
{
    Console.WriteLine("Нет");
}
if(WeekDay==6)
{
    Console.WriteLine("Да");
}
if(WeekDay==7)
{
    Console.WriteLine("Да");
}