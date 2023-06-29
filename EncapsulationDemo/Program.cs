using EncapsulationDemo;
//int ans,ans1,x;
//Square s1 = new Square();
//s1.setlength(-10);
//x= s1.getLength();

//Console.WriteLine(x);

//this is for rectangle
int A,B,Area,Perimeter;
Rectangle rec = new Rectangle();

rec.Length1 = 10;
rec.Width1 = 10;
A = rec.Length1;
B = rec.Width1;
Area = rec.area();
Perimeter = rec.primeter();

Console.WriteLine($"{Area} = {Perimeter}");