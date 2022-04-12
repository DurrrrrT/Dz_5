// Задача 34. Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве

// int[] RandomArray()
// {
//     Random random = new Random();
//     int[] array = new int[random.Next(4,10)];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(100, 1000);
//     }
//     return array;
// }
// void CountEven(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)

//             count++;
//         System.Console.Write(array[i] + " | ");
//     }
//     System.Console.WriteLine();
//     System.Console.WriteLine("Количество четных элементов " + count);
// }
// CountEven(RandomArray());



// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве


int[] array = ArrayRandom();
CountEven();
int[] ArrayRandom()
{
    Random random = new Random();
    int[] array = new int[random.Next(4, 10)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 1000);
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
    return array;
}
void CountEven()
{
    int count = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count++;
    }
    System.Console.WriteLine("Количество  чётных элементов в массиве : " + count + " ");
}

