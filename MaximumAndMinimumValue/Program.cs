// See https://aka.ms/new-console-template for more information
using System.Globalization;

int i,j, num, max = 0, mini = 0;

for (i = 1; i <= 10; i++)
{
    Console.WriteLine("Please enter a number:");
    num = Convert.ToInt32(Console.ReadLine());

    if (num < mini)
    {
        mini = num;
    }
}

Console.WriteLine( mini);
//if (num > max)
//{
//    max = num;
//}