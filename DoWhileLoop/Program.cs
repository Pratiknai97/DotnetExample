//new
//int i=1;

//do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i <= 5);

int x, num, sum, sub;

sum = 0;
sub = 0;
do
{
    Console.WriteLine("1 Addition, 2 substraction, 3 exit");
    x = Convert.ToInt32(Console.ReadLine());

    if (x == 1)
    {
        Console.WriteLine("enter a value");
        num = Convert.ToInt32(Console.ReadLine());

        sum = sum + num;

        Console.WriteLine("enter a value");
        num = Convert.ToInt32(Console.ReadLine());

        sum = sum + num;

        Console.WriteLine(sum);
    }
    else if (x == 2)
    {
        Console.WriteLine("a value");
        num = Convert.ToInt32(Console.ReadLine());

        sub = num - sub;

        Console.WriteLine("enter a value");
        num = Convert.ToInt32(Console.ReadLine());

        sub = sub - num;
        Console.WriteLine(sub);
    }
    else if (x == 3)
    {
        Console.WriteLine("Thank you for your time");
        break;
    }
    else
    {
        Console.WriteLine("please enter between 1 to 3");
    }
}
while (x != 3);



    