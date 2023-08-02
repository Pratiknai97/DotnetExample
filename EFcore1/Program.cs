using EFcore1.Data;
using EFcore1.Model;

MyDBContexts myDBContexts = new MyDBContexts();
var list = myDBContexts.Student.ToList();
foreach (var studentRecord in list)
{
    Console.WriteLine($"ID:{studentRecord.ID}Name:{studentRecord.SName}Sem:{studentRecord.Semister}Hobby:{studentRecord.Hobby}");
}
//insert new record
var Result = myDBContexts.Student.Where(x => x.ID == 1).FirstOrDefault();
Console.WriteLine(Result);

Student S1 = new Student();
S1.SName = "Harsh";
S1.Semister = 4;
S1.Hobby = "cricket";

myDBContexts.Student.Add(S1);
myDBContexts.SaveChanges();

Student S2 = new Student();
S2.SName = "aarti";
S2.Semister = 4;
S2.Hobby = "HairStylist";

myDBContexts.Student.Add(S2);
myDBContexts.SaveChanges();

//new update
var update = myDBContexts.Student.Where(x=>x.ID == 1).FirstOrDefault();
if(update != null)
{
    update.Hobby = "Gaming";
    myDBContexts.SaveChanges();
}


//Delete
var delete = myDBContexts.Student.Where(x=>x.ID == 7).FirstOrDefault();
if(delete != null)
{
    myDBContexts.Student.Remove(delete);
    myDBContexts.SaveChanges();
}
