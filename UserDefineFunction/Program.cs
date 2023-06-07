//int Addition(int a, int b)
//{
//    int ans = a+ b;
//    return ans;
//}
//int x, y;
////Addition(10, 5);
//Console.WriteLine(Addition (5,10));
//Console.WriteLine("enter value 1");
//x = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("enter value 2");
//y = Convert.ToInt32(Console.ReadLine());

//int a = Addition(x, y);
//Console.WriteLine(a);

//void addition() // void is used for any datatype that dont know
//{
//    int x;
//    int y;
//    Console.WriteLine("enter a value 1");
//    x= Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine("enter a value 2");
//    y= Convert.ToInt32(Console.ReadLine());
//    int ans = x + y;

//    Console.WriteLine(ans);
//}
//addition();
//addition();

//new 

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO.Pipes;
using System.Security.AccessControl;

//int maximum(int a, int b)
//{

//    if(a<b)
//    {

//        return b;
//    }
//    else
//    {
//        return a;
//    }

//}
//int x = maximum(10, 20);
//Console.WriteLine(x);

//new simple interest rate
//double simpleinterest(double p, double r, int n)
//{
//    double ans = p * r * n / 100;
//    return ans;
//}
//double x = simpleinterest(1000, 10, 1);
//Console.WriteLine(x);

//new simple interest rate write up to 10 year of interest

//double simpleinterest(double p, double r, int n)
//{
//    double ans = p * r * n / 100;
//    return ans;
//}
////double A = simpleinterest(1000, 10, 1);
////Console.WriteLine(A);
//for (int i = 1; i<=10; i++)
//{
//    double A = simpleinterest(1000, 10, i);
//    Console.WriteLine(A);
//}

//new even and odd and print true and false by using bloon type

//bool isEven(int a)
//{
//    if (a % 2 == 0)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}
//bool B = isEven(5);
//Console.WriteLine(B);

//new get factors 

//int Factors(int a)
//{
//    int count = 0;
//    for (int i = 1; i < a; i++)
//    {
//        if (i % 2 == 0)
//        {
//            count++;
//        }
//    }
//    return count;
//}
//int countfac = Factors(10);
//Console.WriteLine(countfac);

//new get factors and total of it

int Factors(int a)
{
    int count = 0;
    for (int i = 1; i <= a; i++)
    {
        if (a % i == 0)
        {
            count++;
        }
    }
    return count;

}
//for (int i = 1; i <= 5; i++)
//{

//    int totalfac = Factors(i);
//    Console.WriteLine($"{i}={totalfac}");

//}

// new get a number and find is it prime or not

bool prime(int n)
{
    int count;
    count=Factors(n);
    //if (count == 2)
    //{
    //    return true;
    //}
    //else
    //{
    //    return false;
    //}
    return (count == 2);// there is no need if and else condition can directly call true and false in bool
}
//bool x = prime(4);
//Console.WriteLine(x);

// new get all prime numbers from 2 to 20.

//for (int i = 1; i <= 20; i++)
//{

//    bool y = prime(i);
//    if (y == true)
//    {
//        Console.WriteLine(i);
//    }

//}
//new To print next prime number

int GetNextPrime(int start)
{ 
  



}






































