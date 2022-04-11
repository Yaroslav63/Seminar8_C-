var a = new Int32[4, 5];

var random = new Random();
for (var i = 0; i < a.GetLength(0); i++, Console.WriteLine())
{
    for (var j = 0; j < a.GetLength(1); j++)
    {
        a[i, j] = random.Next(100);
        Console.Write("{0,4}", a[i, j]);
    }
}
GetStatistic(a);

for (var i = 0; i < a.GetLength(0); i++)
    for (var j = 0; j < a.GetLength(1); j++)
        for (var k = 0; k < a.GetLength(1); k++)
        {
            if (a[i, j] <= a[i, k]) continue;
            var temp = a[i, j];
            a[i, j] = a[i, k];
            a[i, k] = temp;
        }

for (var i = 0; i < a.GetLength(0); i++, Console.WriteLine())
    for (var j = 0; j < a.GetLength(1); j++)
    {
        Console.Write("{0,4}", a[i, j]);
    }

GetStatistic(a);

static void GetStatistic(Int32[,] a)
{
    
    Int32
        max = a[0, 0],
        min = a[0, 0],
        maxI = 0,
        maxJ = 0,
        minI = 0,
        minJ = 0;

    for (var i = 0; i < a.GetLength(0); i++)
        for (var j = 0; j < a.GetLength(1); j++)
        {
            if (max < a[i, j])
            {
                max = a[i, j];
                maxI = i;
                maxJ = j;
            }
            if (min > a[i, j])
            {
                min = a[i, j];
                minI = i;
                minJ = j;
            }
        }
    Console.WriteLine();
}