int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] arr = new double[m,n];
Console.WriteLine();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
    arr[i,j] = Math.Round(new Random().NextDouble()*100, 1);
    Console.Write("{0}\t", arr[i,j]);
    }
Console.WriteLine();
}