// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int Input()
{
    Console.Write("Введите количество элементов массива: ");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int[] CreateMassive(int n)
{
    int[] array = new int[n];
    return (array);
}

int[] RandomFillMassive(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 1000);
    }
    return (array);
}

int[] PrintMassive(int[] array)
{
    System.Console.WriteLine("Элементы массива: ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
    return array;
}

void OddIndexSumm(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            summ = summ + array[i];
        }
    }
    Console.WriteLine("Cумма элементов, стоящих на нечётных позициях: " + summ);
}

OddIndexSumm(PrintMassive(RandomFillMassive(CreateMassive(Input()))));

