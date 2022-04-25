void Random (int[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
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

int Chet (int[]arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0)
            result++;
    }
    return result;
}

int[] array = new int[5];
Random(array);
Print(array);
Console.WriteLine(Chet(array));
