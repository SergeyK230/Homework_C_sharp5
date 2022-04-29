void Random (int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 10);
    }
}

void Print (int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int SumNeChet (int[]arr)
{
    int result = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        result = result + arr[i];
    }
    return result;
}

int[] array = new int[4];
Random(array);
Print(array);
Console.WriteLine(SumNeChet(array));