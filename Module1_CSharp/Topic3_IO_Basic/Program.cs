/***
 * Viết 1 CT quản lý thông tin của 1 Sinhvien gồm các thông tin sau:
 *  - Id: string
 *  - Name: string
 *  - Gender: boolean 
 *  - Dob: DateTime
 *  - Mark: double
 *  
 * 
 * In thông tin sinh viên sau khi nhập dữ liệu thành công theo định dạng:
 * Id: xxx, Name: yyy, Gender: zzz, Dob: dd/MM/yyy, Mark: kkkk
 * 
 * Yêu cầu: 
 *  - Id kiểm tra tính hợp lệ. Ví dụ: SE123456
 *  - Mark: Đúng định dạng
 *  -> Dữ liệu không hợp lệ thì nhập lại
 *  - Name: Tự động chuyển đổi thành chuỗi chuẩn. Vd: hoang van binh -> Hoang Van Binh
 

// Khai báo
*/
using System.Globalization;
using System.Text.RegularExpressions;

string Id;
string Name;
bool Gender;
DateTime Dob;
double Mark;

// Input
Console.Write("Enter Id: ");
Id = Console.ReadLine();
while(!Regex.IsMatch(Id, @"^SE[0-9]{6}$"))
{
    Console.WriteLine("Invalid Id. Try again! Ex: SE123456");
    Console.Write("Enter Id:");
    Id = Console.ReadLine();
}

Console.Write("Enter Name: ");
Name = Console.ReadLine();


Console.Write("Enter Gender: ");
while(!bool.TryParse(Console.ReadLine(), out Gender))
{
    Console.Write("Re-Enter Gender: ");
}

Console.Write("Enter Dob: ");
while (!DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy", CultureInfo.CurrentCulture,
    DateTimeStyles.None ,out Dob))
{
    Console.Write("Re-Enter Dob: ");
}

Console.Write("Enter Mark: ");
while(!double.TryParse(Console.ReadLine(), out Mark))
{
    Console.Write("Re-Enter Mark: ");
}