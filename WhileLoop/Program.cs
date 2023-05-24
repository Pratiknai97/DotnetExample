// See https://aka.ms/new-console-template for more information
//int i;
//i = 1;

//while (i <= 5)
//{
//    Console.WriteLine(i);
//    i++;
//}

//int num, sum=0;
//Console.WriteLine("Enter a vlaue");
//num =Convert.ToInt32(Console.ReadLine());
//while (num>0)
//{
//    Console.WriteLine(num);
//    sum = sum + num;
//    Console.WriteLine("Enter a vlaue");
//    num = Convert.ToInt32(Console.ReadLine());

//}
//Console.WriteLine(sum);


//int x = 183;
//int y, rem;

//y = x / 10;
//rem = x % 10;

//Console.WriteLine(y);
//Console.WriteLine(rem);

//new

//int x = 183;
//x = x / 10;
//int y = x / 10;
//int rem = x % 10;

//x = x / 10;
//y = x / 10;
//rem = x % 10;


//Console.WriteLine(x);
//Console.WriteLine(y);
//Console.WriteLine(rem);

//new print 183 reverse

//int x = 183, y = 183, z = 183;

//x = x % 10;//3

//y = y / 10;// 
//y = y % 10;// 8

//z = z / 10;
//z = z / 10;//1
//Console.WriteLine(x);
//Console.WriteLine(y);
//Console.WriteLine(z);

//new ways to print reverse no of 183
int x = 183, rem;

while (x > 0)
{
    rem = x % 10;
    x = x / 10;

    Console.WriteLine($"{rem},{x}");
}