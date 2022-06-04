// Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.

float[,] GetArray(int a, int b)
{
    float[,] array = new float[a, b];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(-10, 10) + (float)rnd.Next(10)/10;
        }
    }
    return array;
}

void PrintArray(float[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
       for (int j = 0; j < array.GetLength(1); j++)
       {
           Console.Write(array[i,j] +"  ");
       } 
       Console.WriteLine();
    }
}

float[,] arrayResult = GetArray(3,4);
PrintArray(arrayResult);