int n = 3,
    m = 8;
int[,] array = new int[n, m];
int[] sum = new int[n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        sum[i] = sum[i] + array[i, j];
    }
}
for (int i = 0; i < n; i++)
{
    Console.Write($"{sum[i]} ");
}
Console.WriteLine();
int min = sum[0];
int strMin = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (sum[i] < min)
        {
            min = sum[i];
            strMin = i + 1;
        }
    }
}
Console.Write($"номер строки {strMin} с наименьшей суммой элементов {min}");