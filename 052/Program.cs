int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m,n];
Console.WriteLine();
Console.WriteLine("Array: ");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
    arr[i,j] = new Random().Next(-10, 11);
    Console.Write("{0}\t", arr[i,j]);
    }
Console.WriteLine();
}
double[] average = new double[n];
double sum = 0;
Console.WriteLine();
Console.WriteLine("Average");
for (int k = 0; k < n; k++)
{
    for (int l = 0; l < m; l++)
    {
    sum += arr[l,k];
    }
average[k] = sum/m;
sum = 0;
Console.Write(Math.Round(average[k], 2) + "  ");
}