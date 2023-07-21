using EFcore.Data;
using EFcore.Model;

MyDbContects myDbContects = new MyDbContects();
var list = myDbContects.Student.Count();
var list1 = myDbContects.Student.ToList();
Console.WriteLine(list);
foreach(var record in list1)
{
    Console.WriteLine($"Student ID:{record.ID},Name:{record.SName},Semesters{record.Semister},Hobby:{record.Hobby}");
}
