//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[10];
void ArrayRandom(int[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(4, 8);
        System.Console.Write(array[i] + " | ");
    }
}
ArrayRandom(array);
void SummOdd(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine("Сумма элементов на нечетных позициях : " + sum);
}
SummOdd(array);



