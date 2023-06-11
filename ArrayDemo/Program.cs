//int[] marks = new int[5];

//marks[0] = 20;
//marks[1] = 30;
//marks[2] = 45;
//marks[3] = 32;
//marks[4] = 21;

////Console.WriteLine(marks[0]);
////Console.WriteLine(marks[1]);
////Console.WriteLine(marks[2]);
////Console.WriteLine(marks[3]);
////Console.WriteLine(marks[4]);

//for (int i = 0; i<=4; i++)
//{
//    Console.WriteLine(marks[i]);
//}

//get value from the user and print at the end

//int[] marks = new int[5];

//    for (int i = 0; i < marks.Length; i++)
//    {
//        Console.WriteLine("enter a value");
//        marks[i] = Convert.ToInt32(Console.ReadLine());

//}
////int sum = 0;
//int maxi = 0;
//int mini = 0;
//    for (int i = 0; i < marks.Length; i++)// this is for after print
//{
//    //Console.WriteLine(marks[i]);
//    // sum = sum + marks[i];// total print

//    //if (maxi < marks[i])
//    //{
//    //    maxi = marks[i]; 
//    //}
//    if (i == 1)
//    {
//        mini = marks[i];
//    }
//    if (marks[i]<mini)
//    {
//        mini = marks[i];

//    }

//}
////Console.WriteLine(sum);
////Console.WriteLine(maxi);
//Console.WriteLine(mini);

//To Marge 2 int array into one.

using System.Xml.Schema;

//int[] A = new int[5];
//int[] B = new int[5];
//int[] C = new int[10];


//for (int i = 0;i < A.Length;i++)
//{
//    Console.WriteLine("Enter a Value");
//    A[i] = Convert.ToInt32(Console.ReadLine());
//    C[i] = A[i];

//}
//for(int i = 0;i < B.Length; i++)
//{

//    Console.WriteLine("Again value for B");
//    B[i] = Convert.ToInt32(Console.ReadLine());
//    C[A.Length+i] = B[i];

//}
//for (int i = 0; i < C.Length; i++)
//{
//    Console.WriteLine(C[i]);

//}

//new get 5 numbers from the user and again get one number from user and count how many numbers repeat

//int[] Number = new int[5];

//int count = 0;

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Enter a 5 Value");
//    Number[i] = Convert.ToInt32(Console.ReadLine());

    

//}

//Console.WriteLine("enter a value");
//int value = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < 5; i++)
//{
//    if (Number[i] == value)
//    {
//        count++;
//    }
    
//}

//    Console.WriteLine($"No of Occurance {value} is {count}");

//new enter a 5 names and print

string[] Name = new string[5];

Name[0] = "pratik";
Name[1] = "Sanket";
Name[2] = "Jay";
Name[3] = "Akshar";
Name[4] = "Dhaval";


for(int i = 0; i < Name.Length; i++)
{
    Console.WriteLine(Name[i]);
}