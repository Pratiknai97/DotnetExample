//int i;

//for(i = 1; i<=5; i++)
//{
//    Console.WriteLine(i);
//}

//for(i = 1; i <= 5; i = i + 2)
//{
//    Console.WriteLine(i);
//}

//reverse

//for(i =5; i>= 1; i--)
//{
//    Console.WriteLine(i);
//}

// enter a number like 5 and print 1 to 5 and each of number sum and total print

//int i, j, sum;


//Console.WriteLine("enter a Number");
//i = Convert.ToInt32(Console.ReadLine());

//sum = 0;
//for (j = 1; j <= i; j++)
//{
//    Console.WriteLine(j);
//    sum = sum + j;
//}
//Console.WriteLine(sum);

// enter a num and find a factor


//int number, i, total;

//Console.WriteLine("enter a number");
//number = Convert.ToInt32(Console.ReadLine());

//total = 0;
//for (i = 1; i <= number; i++)
//{
//    if (number % i == 0)
//    {
//        Console.WriteLine(i);
//        total++;
//    }
//    Console.WriteLine(total);
//}

//define prime and not prime 
//int number, i, total;

//Console.WriteLine("enter a number");
//number = Convert.ToInt32(Console.ReadLine());

//total = 0;
//for (i = 1; i <= number; i++)
//{
//    if (number % i == 0)
//    {
//        Console.WriteLine(i);
//        total++;
//        Console.WriteLine(total);

//    }

//}
//if (total == 2)
//{
//    Console.WriteLine("it is prime");

//}
//else
//{
//    Console.WriteLine("not prime");
//}

// 1 to 50 to print multiple of 5 
//int i;

//for (i = 1; i<=50; i++)
//{

//    if (i % 5 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

//print a 3 table
//int i, number, result;
//string data;
//number = 3;
//for (i = 1; i <= 10; i++)
//{
//    result = number * i;
//    //another ways string con
//    //data = number + "*" + i + "=" + result;
//    //string interpolation
//    Console.WriteLine($"{number} * {i} = {result}");

//    //Console.WriteLine("{0}*{1}= {2}", number, i, result);
//    //Console.WriteLine(data);
//}

//int i;

//for (i = 1; i<= 10; i=i+3)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine(i);

// new


//int i = 100;

//for(i = 10; i>=15; i++)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine(i);


//int i;
//i = 1;
//for (; i <= 5;)
//{
//    Console.WriteLine(i);
//    i = i + 2;
//}

//infinity loop

//int i;

//for(i = 5; i>=1; i++)
//{
//    Console.WriteLine(i);   
//}

//int i, m, n;
//int ans = 1;
//m = 2;
//n = 3;

//for (i = 1; i <=n; i++)
//{
//    ans = ans * m;
//}
//Console.WriteLine(ans);

// new nested loop

//int i, j, count;
//count = 0;

//for (i = 1; i<=3; i++)
//{
//    for(j = 1; j<=2; j++)
//    {
//        count = count + 1;
//    }
//}
//Console.WriteLine(count);


//new total sum of factors

//int i, j, sum = 0;

//for (i =1; i<=3; i++)
//{
//    for(j=1; j<=i; j++)
//    {
//        sum = sum + i;
//    }
//}
//Console.WriteLine(sum);


//new define a fector 1 to 5 

//int i, j;


//for (i = 1; i <= 5; i++)
//{
//   // Console.WriteLine(i);
//    for (j = 1; j <= i; j++)
//    {
//        if (i % j == 0)
//        {
//           Console.WriteLine(j);

//        }

//    }

//}

//new define a fector 1 to 5 and how many factors total

//int i, j, total;

////total = 0;
//for (i = 1; i<=5; i++)
//{
//    total = 0;
//    for (j = 1; j <= i; j++) 
//    {
//        if (i % j ==0 )
//        {
//            //Console.WriteLine(j);
//            total++;
//            
//                }

//    }

//    Console.WriteLine($"{i} = {total}");
//}

//new to print prime no between 2 to 20 



//int i, number, j, total, sum =0;

//Console.WriteLine("enter a number");
//number =Convert.ToInt32 (Console.ReadLine());
//for (i = 1; i<=number; i++)
//{
//    total = 0;
//    for (j =1; j<= i; j++)
//    {
//        if ( i % j == 0)
//        {

//            total++;
            
//        }
        
//    }
//    if (total == 2)

//    {
//        Console.WriteLine(i);
//        sum = sum + 1;
//    }

//}
//Console.WriteLine(sum);