using EFProduct.Data;
using EFProduct.Model;

MyDbContext myDbContext = new MyDbContext();
var result = myDbContext.product.ToList();
foreach(var product in result)
{
    Console.WriteLine($"{product.ID}{product.PName}{product.Rate}");
}

//New create new record

Product P1 = new Product();
P1.PName = "TV";
P1.Rate = 100000;

myDbContext.product.Add(P1);
myDbContext.SaveChanges();

//new Update the record

var Update = myDbContext.product.Where(x=> x.ID == 2).FirstOrDefault();
if (Update != null)
{
    Update.PName = "AC";
    myDbContext.SaveChanges();
}
//new Delete record
var Delete = myDbContext.product.Where(x => x.ID == 2).FirstOrDefault();
if (Delete != null)
{
    myDbContext.product.Remove(Delete);
    myDbContext.SaveChanges();
}
