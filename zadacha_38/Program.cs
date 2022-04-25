void Random (double[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000) / 10.0;
    }
}

void Print (double[]arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

double Min(double[]arr)
{
    double result = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < result)
            result = arr[i];
    }
    return result;
}

double Max(double[]arr)
{
    double result = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > result)
            result = arr[i];
    }
    return result;
}

double Raznica(double[]arr)
{
    return Max(arr) - Min(arr);
}

double[] array = new double[5];
Random(array);
Print(array);
double raz = Raznica(array);
System.Console.WriteLine("{0:f}", raz);
