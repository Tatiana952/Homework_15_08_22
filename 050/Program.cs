Console.WriteLine("Enter sizes of array");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m,n];
Console.WriteLine();
Console.WriteLine("Enter position: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Array: ");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
    arr[i,j] = new Random().Next(-30, 30);
    Console.Write("{0}\t", arr[i,j]);
    }
Console.WriteLine();
}
Console.WriteLine();
if (a < m && b < n) Console.WriteLine(arr[a,b]);
else Console.WriteLine("No element");