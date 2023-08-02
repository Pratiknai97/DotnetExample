//List<int> list = new List<int>();
//Console.WriteLine(list.Count);
//list.Add(20);
//list.Add(30);
//list.Add(5);
//Console.WriteLine(list.Count);
//Console.WriteLine(list[0]);
//for (int i = 0; i < list.Count; i++)
//{
//    Console.WriteLine(list[i]);
//}
//foreach (int i in list)
//{
//    Console.WriteLine(i);
//}
//list[0] = 25;
//Console.WriteLine(list[0]);
//list.RemoveAt(0);
//Console.WriteLine(list.Count);
//list.Clear();
//Console.WriteLine(list.Count);

using Collection;

List<Product> products = new List<Product>();

products.Add(new Product { ID = 1, Name = "Laptop", Rate = 35000 });
products.Add(new Product { ID = 2, Name = "Mouse", Rate = 15000 });
products.Add(new Product { ID = 3, Name = "Keyboard", Rate = 45000 });

foreach (Product product in products)
{
    Console.WriteLine($"Product:{product.ID},Name:{product.Name},Rate:{product.Rate}");
}
var Result = products.Where(x=>x.Rate>20000).ToList();// this is a lambda expression
Console.WriteLine(Result.Count);
foreach(Product product in Result)
{
    Console.WriteLine($"ID:{product.ID},Name:{product.Name},Rate:{product.Rate}");
}

var a = products.Where(x=>x.ID==1).FirstOrDefault();

Console.WriteLine($"ID:{a.ID},Name:{a.Name},Rate:{a.Rate}");








