// See https://aka.ms/new-console-template for more information
int i, num, max = 0, mini;

for (i = 1; i <= 10; i++)
{
    Console.WriteLine("please enter a number");
    num = Convert.ToInt32(Console.ReadLine());

    if (num > max)
    {
        max = num;
    }
    //if (num<mini)
    //{
    //    mini = num;
    //}
}
Console.WriteLine(max);
