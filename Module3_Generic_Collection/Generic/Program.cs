// Tạo 1 tập dư liệu vơi kiểu int
using Generic;

var obj1 = new MyGeneric<int> { Value = 10 };
Console.WriteLine(obj1);

MyGeneric<string> obj2 = new MyGeneric<string> { Value = "Hello" };
Console.WriteLine(obj2);

dynamic obj3 = new MyGeneric<dynamic> { Value = new { id = 1, name = "member1" } };
Console.WriteLine(obj3);

GenericMethod gm = new GenericMethod();
gm.Display<string, double>("Dung", 10);


