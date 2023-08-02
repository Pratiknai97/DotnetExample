using List_Add_FindID_Product;

int aaa = 0;
List<Product> productList = new List<Product>();
productList.Add(new Product { ID = 1, Name = "TV", Rate = 500000 });
productList.Add(new Product { ID = 2, Name = "Speaker", Rate = 102000 });
productList.Add(new Product { ID = 3, Name = "Microphone", Rate = 40000 });
//do
//{
//    Console.WriteLine("1 List, 2 Add new product, 3 Find By ID, 4 Exit");
//    int x = Convert.ToInt32(Console.ReadLine());
//} 
while (aaa == 0)
{
    Console.WriteLine("1 List, 2 Add new product, 3 Find By ID, 4 Exit");
    int x = Convert.ToInt32(Console.ReadLine());

    if (x == 1)
    {
        foreach (Product product in productList)
        {
            Console.WriteLine($"ID:{product.ID}, Name:{product.Name}, Rate:{product.Rate}");
        }
    }
    else if (x == 2)
    {
        Console.WriteLine("Enter a Product ID");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a Product Name");
        string B = Console.ReadLine();
        Console.WriteLine("Enter a Product Rate");
        int C = Convert.ToInt32(Console.ReadLine());

        productList.Add(new Product { ID = A, Name = B, Rate = C });

        Console.WriteLine($"Product ID: {A}, Name: {B}, Rate: {C} added successfully.");
    }
    else if (x == 3)
    {
        Console.WriteLine("Enter a Product ID");
        int A = Convert.ToInt32(Console.ReadLine());

        var Result = productList.Where(p => p.ID == A).ToList();
        foreach (Product product2 in Result)
        {
            Console.WriteLine($"ID: {product2.ID}, Name: {product2.Name}, Rate: {product2.Rate}");
        }
    }
    else if (x == 4)
    {
        Console.WriteLine("Exited");
        break;
    }
    else
    {
        Console.WriteLine("Invalid Num");
    }
}