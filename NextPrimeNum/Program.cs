Console.WriteLine("Enter a number");
int x = Convert.ToInt32(Console.ReadLine());
int nextPrime = x + 1;

while (true)
{
    int count = 0;

    for (int i = 1; i <= nextPrime; i++)
    {
        if (nextPrime % i == 0)
        {
            count++;
        }
    }

    if (count == 2)
    {
        Console.WriteLine("Next prime number: " + nextPrime);
        break;
    }

    nextPrime++;
}
