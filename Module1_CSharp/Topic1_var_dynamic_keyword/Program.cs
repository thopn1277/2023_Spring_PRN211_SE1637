// Khi dung 'var' khai bao bien cuc bo -> Phải gán giá trị ban đầu

using Topic1_var_dynamic_keyword;

// Var keyword:
var a = 10;
var b = true;
var c = 3.5;
var d = "Hello";
var e = new Student(); //e = null

// In ra kiểu dữ liệu của các biến ở trên
Console.WriteLine("Type of a: " + a.GetType().Name);
Console.WriteLine("Type of b: " + b.GetType().Name);
Console.WriteLine("Type of c: " + c.GetType().Name);
Console.WriteLine("Type of d: " + d.GetType().Name);
Console.WriteLine("Type of e: " + e.GetType().Name);

// Dynamic keyword
dynamic myVar = false;
Console.WriteLine("Type of myVar: " + myVar.GetType().Name);
myVar = new Student();
Console.WriteLine("Type of myVar: " + myVar.GetType().Name);
myVar = 3.5f;
Console.WriteLine("Type of myVar: " + myVar.GetType().Name);

Console.ReadLine();
