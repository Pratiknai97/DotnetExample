using InterfaceExample1;

// IShape Interface is only used for implementation of Anyshape not for any perticual shape and
// IShape Ishape = new IShape(); //interface not for memory location.
string Ans; 
Square s1 = new Square();
Ans = s1.Draw();
Console.WriteLine(Ans);

//New same thing for Rectangle

Rectangle s2 = new Rectangle();
Ans = s2.Draw();
Console.WriteLine(Ans);

IShape s3 = s1;
Console.WriteLine(s3.Draw());

s3 = s2;
Console.WriteLine(s3.Draw());