void Z34()
{
    Random rand = new Random();
    int size = rand.Next(10);
    int[] N = new int[size];
    int length = N.Length;
    FillArray(N, 0, 1000);
    PrintArray(N);
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (N[i] % 2 == 0) count++;
    }
    Console.WriteLine($"\t Количество чётных числе: {count}");
}

void FillArray(int[] N, int minValue, int maxValue)
{
    Random rand = new Random();
    int size = N.Length;
    for (int i = 0; i < size; i++)
    {
        N[i] = rand.Next(minValue, maxValue);
    }
}

void PrintArray(int[] N)
{
    int size = N.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(N[i] + " ");
    }
}

Z34(); 

void Z36()
{
    Random rand = new Random();
    int size = rand.Next(10);
    int[] N = new int[size];
    int length = N.Length;
    FillArray(N, 0, 1000);
    PrintArray(N);
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 != 0) sum = sum + N[i];
    }
    Console.Write($"\t Сумма элементов с нечётными индексами: {sum}");
    Console.WriteLine(String.Empty);
}
Z36(); 

void Z38()
{
    Random rand = new Random();
    int size = rand.Next(3, 10);
    double[] N = new double[size];
    int length = N.Length;
    FillDoubleArray(N);
    PrintDoubleArray(N);
    double max = N[0];
    double min = N[0];
    for (int i = 0; i < length; i++)
    {
        if (N[i] > max) max = N[i];
        if (N[i] < min) min = N[i]; 
    }
    double result = Math.Round(max - min, 2);
    Console.WriteLine();
    Console.WriteLine($"{Math.Round(max, 2)} - {Math.Round(min, 2)} = {result}");
}

    void FillDoubleArray(double[] N)
    {
        Random rand = new Random();
        int size = N.Length;
        for (int i = 0; i < size; i++)
        {
            N[i] = rand.NextDouble() * (100 - 10) + 10;
        }
    }
    
    void PrintDoubleArray(double[] N)
    {
        int size = N.Length;
        for (int i = 0; i < size; i++)
        {
            Console.Write(Math.Round((N[i]), 2) + " ");
        }
    }
Z38();