//Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом
//столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого
//столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите строк: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите столбцов: ");
int b = int.Parse(Console.ReadLine());

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(10);
        }
    }
    return array;
}



void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}


int[,] arrayResult = GetArray(a, b);
PrintArray(arrayResult);

void GetAllSum()
{
    Console.Write("Среднее арифметическое столбцов: ");
    for (int i = 0; i < b; i++)
    {
        float sum = 0;
        for (int j = 0; j < a; j++)
            {
            sum += arrayResult[j, i];
            }
        float GetSum = sum / a;
        Console.Write(GetSum + ";  ");
    }
}
GetAllSum();
