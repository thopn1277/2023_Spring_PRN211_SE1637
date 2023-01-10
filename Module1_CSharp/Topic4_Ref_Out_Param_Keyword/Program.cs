// Sử dụng ref, out, params keyword trong khai báo tham số của hàm (method)
static void MyMethod(int x, ref int y, out int z)
{
    x = 10;
    y = 20;
    z = 30;
}

static void SumArray(out int sum, params int[] arr)
{
    sum = 0;
    foreach (int i in arr)
        sum += i;
}

// Gọi trong hàm Main
int a = 1, b = 2, c;
MyMethod(a, ref b, out c);
// In giá trị của a, b, c
Console.WriteLine($"a = {a}, b = {b}, c = {c}"); // a=1, b=20, c=30

// C1: Truyền đối số cho params
int[] arr = { 1, 2, 3 };
int result1;
SumArray(out result1, arr);
Console.WriteLine($"Sum1 = {result1}");
SumArray(out result1, 2,3,4,5,6);
Console.WriteLine($"Sum1 = {result1}");
