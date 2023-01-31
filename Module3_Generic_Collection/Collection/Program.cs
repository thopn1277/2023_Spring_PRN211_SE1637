// Khai bao 1 dictionary kieu <Student, double>
using Collection;

Dictionary<Student, double> myList = new Dictionary<Student, double>()
{
    { new Student{ Id=1, Name="Hoang"}, 7 },
    { new Student{ Id=2, Name="Tuan"}, 6.5 },
    { new Student{ Id=3, Name="Nam"}, 8.5 },
    { new Student{ Id=4, Name="Hoa"}, 4 },
    { new Student{ Id=5, Name="Hung"}, 6.5 }
};

Console.WriteLine(" ----- LIST ----- ");
foreach (var item in myList)
{
    Console.WriteLine($"{item.Key.Id} - {item.Key.Name} - {item.Value}");
}

// Su dung LINQ in ra danh sach cac sinh vien co ten bat dau voi chu cai 'H'
var result = myList.Where(e => e.Key.Name.StartsWith("h")).ToDictionary(e1 => e1.Key, e2 => e2.Value);

foreach (var item in result)
{
    Console.WriteLine($"{item.Key.Id} - {item.Key.Name} - {item.Value}");
}

// e => e.Key.Name.StartsWith("h")
// 1.0
//Dictionary<Student, double> GetStudentByName(Dictionary<Student, double> myList, string sName)
//{
//    Dictionary<Student, double> result = new Dictionary<Student, double>();
//    foreach (var item in myList)
//    {
//        if (item.Key.Name.StartsWith(sName))
//        {
//            result.Add(item.Key, item.Value);
//        }
//    }
//    return result;
//}