
using InheritanceWithConstructure;

Employee s1 = new Employee(101,"Pratik",15000);
//Console.WriteLine("Print constructrue");
//s1.ID = 1;
//s1.Name = "pratik";
//s1.Salary = 150000;

//Console.WriteLine($"Employee ID= {s1.ID},Name ={s1.Name}, Salary = {s1.Salary}");


SalesMen s2 = new SalesMen(s1.ID,s1.Name,s1.Salary,14000);


Console.WriteLine($"Employee ID= {s1.ID},Name ={s1.Name}, Salary = {s1.Salary} and AllowAnce = {s2.Allowance}");