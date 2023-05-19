// factorial

int num, i, multi;

Console.WriteLine("enter a number");
num = Convert.ToInt32(Console.ReadLine());

multi = 1;
for(i= 1; i<=num; i++)
{
    multi = i * multi;
    Console.WriteLine($"{i} = {multi}");
   }

//Console.WriteLine(multi);
