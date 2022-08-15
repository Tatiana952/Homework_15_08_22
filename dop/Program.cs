int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m,n];
Console.WriteLine();
Console.WriteLine("Array: ");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
    arr[i,j] = new Random().Next(-100, 101);
    Console.Write("{0}\t", arr[i,j]);
    }
Console.WriteLine();
}
Console.WriteLine();
int[,] trans = new int[m,n];
Console.WriteLine("Transposition: ");
for (int k = 0; k < m; k++)
{
    for (int l = 0; l < n; l++)
    {
    trans[k,l] = arr[m-1-k,l];
    Console.Write("{0}\t", trans[k,l]);
    }
Console.WriteLine();
}