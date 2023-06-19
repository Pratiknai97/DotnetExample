using UserDefineClass;

//Student s= new Student();
//s.RollNo = 101;
//s.studentName = "Pratik";
//s.sem = 3;

//Console.WriteLine($"{s.RollNo}={s.studentName}={s.sem}");

//  define square
//int ans, ans1;

//Square Sq = new Square();
//Sq.Length = 50;
//ans= Sq.Area();
//ans1 = Sq.perimeter();
//Console.WriteLine(ans1);

////new another object 
//int area, perimeter;
//Square Sq2 = new Square();
//Sq2.Length = 70;
//area = Sq2.Area();
//perimeter = Sq2.perimeter();

//Console.WriteLine($"Area = {area} perimeter = {perimeter}");

//define Rectengle

int Area, Perimeter;
Rectengle Rec = new Rectengle();
Rec.Length = 50;
Rec.Width = 25;
Area= Rec.Area();
Perimeter= Rec.perimeter();

Console.WriteLine($"Area = {Area}, Perimeter ={Perimeter}");


// Circle
Double Area1, Circumreference1;
Circle Cir = new Circle();

Cir.radius = 50;
Area1 = Cir.Area();
Circumreference1 = Cir.circumreference();

Console.WriteLine($"Area Of Circle={Area1} and Circumreference of Circle {Circumreference1}");







