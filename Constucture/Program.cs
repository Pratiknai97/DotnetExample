using Constucture;

int x,area,parimeter;
Square s1 = new Square();
Console.WriteLine(s1.length);
s1.length = 10;
x = s1.length;
area = s1.area();
parimeter = s1.parimeter();
Console.WriteLine($"Area {area} and parimeter {parimeter}");


Square s2 = new Square(20);
Console.WriteLine(s2.length);
s2.length = 30;
Console.WriteLine(s2.length);


// this is for rectangle

Rectangle rec = new Rectangle();
Console.WriteLine($"{rec.length}, width {rec.width}");

//parameteries constructure

Rectangle rec2 = new Rectangle(10,20);
Console.WriteLine($"length is{rec2.length}and width is {rec2.width}");