var name = "Dung";
var salary = 11000.5;
DateTime dob = DateTime.Now;

// C1: String interpolation
string result = $"Name: {name,6}, Salary: {salary,9:N2}";
Console.WriteLine(result);

// C2: Dùng hàm Format() của string
Console.WriteLine(string.Format("Name {0,8}, Salary: {1,10:N2}",name, salary));

// In ra giá trị của dob theo định dạng dd/MM/yyyy
Console.WriteLine($"Dob: {dob:dd/MM/yyyy}");