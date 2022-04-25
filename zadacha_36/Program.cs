void Random (int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-1000, 1000);
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
    for (int i = 0; i < arr.Length; i+=2)
    {
        result = result + arr[i];
    }
    return result;
}

int[] array = new int[5];
Random(array);
Print(array);
Console.WriteLine(SumNeChet(array));