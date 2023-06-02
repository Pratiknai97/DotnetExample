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
//int x = 183, rem;

//while (x > 0)
//{
//    rem = x % 10;
//    x = x / 10;

//    Console.WriteLine($"{rem},{x}");
//}

//new count how many no that user pass

//int x, rem, count;

//Console.WriteLine("enter a Number");
//x = Convert.ToInt32(Console.ReadLine());
//count = 0;
//while (x > 0)
//{

//    x = x / 10;
//    count = count + 1;
//}

//Console.WriteLine(count);

// new sum of digits like 5+4+6 = 15;

//int x, rem, sum;

//Console.WriteLine("enter a number");
//x = Convert.ToInt32(Console.ReadLine());
//sum = 0;
//while (x > 0)
//{
//    rem = x % 10;
//    x = x / 10;
//    sum = sum + rem;
//}
//Console.WriteLine(sum);

//new how many even and odd number

//int x, rem, even, odd;

//Console.WriteLine("enter a number");
//x = Convert.ToInt32(Console.ReadLine());
//even = 0;
//odd = 0;
//while (x > 0)
//{
//    rem = x % 10;
//    if(rem % 2 == 0)
//    {
//        even = even + 1;
//    }
//    else
//    {
//        odd = odd + 1;
//    }
//    x = x / 10;
//}
//Console.WriteLine(even);
//Console.WriteLine(odd);

// new like to give a party user say yes then print thanks otherwise ask again 

//string x;

//Console.WriteLine("like to give a party");
//x = Console.ReadLine();

//while (x != "yes")
//{

//    Console.WriteLine("like to to give a party");
//    x = Console.ReadLine();
//}
//Console.WriteLine("Thanks");

// new addition, substration and multiplication 

//int x, num, sum, sub, aaa;
//Console.WriteLine("1 Addition, 2 substraction, 3 exit");
//x = Convert.ToInt32(Console.ReadLine());
//sum = 0;
//sub = 0;
//aaa = 0;
////while (aaa==0) 
////{
////    Console.WriteLine("1 Addition, 2 substraction, 3 exit");
////    x = Convert.ToInt32(Console.ReadLine());

//while (aaa == 0)
//{
//    if (x == 1)
//    {
//        Console.WriteLine("enter a value");
//        num = Convert.ToInt32(Console.ReadLine());

//        sum = sum + num;

//        Console.WriteLine("enter a value");
//        num = Convert.ToInt32(Console.ReadLine());

//        sum = sum + num;

//        Console.WriteLine(sum);
//    }
//    else if (x == 2)
//    {
//        Console.WriteLine("a value");
//        num = Convert.ToInt32(Console.ReadLine());

//        sub = num - sub;

//        Console.WriteLine("enter a value");
//        num = Convert.ToInt32(Console.ReadLine());

//        sub = sub - num;
//        Console.WriteLine(sub);
//    }
//    else if (x == 3)
//    {
//        Console.WriteLine("Thank you for your time");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("please enter between 1 to 3");
//    }
//    Console.WriteLine("1 Addition, 2 substraction, 3 exit");
//    x = Convert.ToInt32(Console.ReadLine());
//}

// new 

//int i, j, num, count;

//Console.WriteLine("Enter a any number");
//num = Convert.ToInt32(Console.ReadLine());

//while ()
//{
//    for (i = 1; i <= num; i++)

//    {
//        count = 0;
//        for (j = 1; j <= i; j++)
//        {
//            if (i % j == 0)
//            {
//                Console.WriteLine(j);
//                count++;
//            }


//            if (count == 2)
//            {
//                Console.WriteLine(i);
//            }
//        }

//    }
//}







