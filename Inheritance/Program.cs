using Inheritance;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

Employee em = new Employee();
em.Id = 1;
em.Name = "Pratik";
em.Salary = 15000;

Console.WriteLine($"Employee ID = {em.Id}, Name ={em.Name}, Salary = {em.Salary}");

Salesmen s1 = new Salesmen();
s1.DailyAllowance = 100;
s1.Id =2;
s1.Name = "jay";
s1.Salary = 10000;
s1.DailyAllowance = 100;

Console.WriteLine($"Salesmen ID = {s1.Id}, Name = {s1.Name}, Salary = {s1.Salary}, DailyAllowance = {s1.DailyAllowance}");

SeniarSalesmen s2 = new SeniarSalesmen();
s2.Id  =3;
s2.Name = "Sanket";
s2.Salary = 200000;
s2.DailyAllowance = 100;
s2.TravellingAllowance = 12000;

Console.WriteLine($"Salesmen ID = {s2.Id}, Name = {s2.Name}, Salary = {s2.Salary}, DailyAllowance = {s2.DailyAllowance}, travelling allowance = {s2.TravellingAllowance}");

