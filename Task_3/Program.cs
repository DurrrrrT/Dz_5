// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] ArrayRandom()
{
    Random random = new Random();
    double[] array = new double[random.Next(3, 6)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble() + random.Next(-1, 4);
        System.Console.Write(array[i] + " | ");
    }
    return array;
}

void ArrayDifference(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if
         (array[i] < min) min = array[i];
    }
    System.Console.WriteLine();
    Console.WriteLine("Разница между max и min ");
    Console.WriteLine(max - min);
}
ArrayDifference(ArrayRandom());
