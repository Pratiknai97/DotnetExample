// See https://aka.ms/new-console-template for more information
using System.Globalization;

int i, num, max = 0, mini = 0;

for (i = 1; i <= 10; i++)
{
    Console.WriteLine("Please enter a number:");
    num = Convert.ToInt32(Console.ReadLine());

    if (i == 1)
    {
        max = num;
        mini = num;

    }
    if (num > max)
    {
        max = num;
    }
    if (num < mini)
    {
        mini = num;
    }
    
}
Console.WriteLine(max);
Console.WriteLine( mini);
