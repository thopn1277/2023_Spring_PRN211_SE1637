static (int sum, int count) MyMethod(params int [] arr)
{
    var a = (s: 0, c: 0);
    foreach (var i in arr)
    {
        if (CheckEven(i))
        {
            a.s += i;
            a.c++;
        }
    }
    return a;
    // local function
    bool CheckEven(int number)
    {
        if (number % 2 == 0)
            return true;
        else
            return false;
    }
}

var (s1, c1) = MyMethod(1, 2, 3, 4, 5, 6);
Console.WriteLine($"Sum = {s1}, Count = {c1}");
Console.ReadLine();