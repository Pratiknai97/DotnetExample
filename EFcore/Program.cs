using EFcore.Data;
using EFcore.Model;
using System.Security.Cryptography.X509Certificates;

MyDbContects myDbContects = new MyDbContects();
var list = myDbContects.Student.Count();
var list1 = myDbContects.Student.ToList();
Console.WriteLine(list);
foreach(var record in list1)
{
    Console.WriteLine($"Student ID:{record.ID},Name:{record.SName},Semesters{record.Semister},Hobby:{record.Hobby}");
}
var Result = myDbContects.Student.Where(x=>x.ID==1).FirstOrDefault();
Console.WriteLine(Result.ToString());
Console.WriteLine(Result);
// add a new record
Student S1 = new Student();
S1.ID = 0;
S1.SName = "Gaurang";
S1.Semister = 3;
S1.Hobby = "Watching Movies";

myDbContects.Student.Add(S1);
myDbContects.SaveChanges();
// Update record

var update = myDbContects.Student.FirstOrDefault(x => x.ID == 2);
if(update != null)
{
    update.SName = "Rakesh";
    myDbContects.SaveChanges();
}



//new delete
var Delete = myDbContects.Student.FirstOrDefault(x => x.ID == 5);
if(Delete != null)
{
    myDbContects.Student.Remove(Delete);
    myDbContects.SaveChanges();
}
