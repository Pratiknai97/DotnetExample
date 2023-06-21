//string str1 = "one";
//string  str2 = "one";
//string str3 = "ONE";
//string str4 = "two";
//string str5 = "one, too";

//if(string.Compare(str1, str2) == 0)
//{
//    Console.WriteLine(str1 + "and" + str2 + "Are equal.");
//}
//else
//{
//    Console.WriteLine(str1 + "and" + str2 + "are not equal");
//}
//if (string.Compare(str1, str3) == 0)
//{
//    Console.WriteLine(str1+"and"+str3+"are equal");
//}
//else
//{
//    Console.WriteLine(str1+"and"+str3+"are not equal");
//}
//if (string.Compare(str1, str3, true) == 0)
//{
//    Console.WriteLine(str1+"and"+str3+"are equal ignoring case ");
//}
//else
//{
//    Console.WriteLine(str1 + "and" + str3 + "are not equal ignoring case");
//}
//if (string.Compare(str1, str5) == 0)
//{
//    Console.WriteLine(str1 + "and" + str5 + "are equal");
//}
//else
//{
//    Console.WriteLine(str1 + "and" + str5 + "are not equal");
//}
string data = "BBC";
string data2 = "ABC";
int res = data.CompareTo(data2);
Console.WriteLine(res);
data = "ncoisnonKLNSVIN";
//data2=data.ToUpper();
//Console.Write(data2);
//data2=data.ToLower();
//Console.Write(data2);

//this is for trimStart () function
data = "  A   AB   ABC   ";
//data2 = data.TrimStart();
//Console.WriteLine(data);
//Console.WriteLine(data2);
//Console.WriteLine(data.Length);
//Console.WriteLine(data2.Length);

//this is for trimEnd();

data2 = data.TrimEnd();
Console.WriteLine(data);
Console.WriteLine(data2);
Console.WriteLine(data.Length);
Console.WriteLine(data2.Length);

//new this is for used for data trim

data2 = data.Trim();
Console.WriteLine(data);
Console.WriteLine(data2);
Console.WriteLine(data.Length);
Console.WriteLine(data2.Length);

