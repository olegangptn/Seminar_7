// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

void PrintArray(int[,] matr) // Создание матрицы 
{
    for (int i = 0; i  < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
    Console.WriteLine();
    }
}

static int GetNumberTest(int numberTest)
{
    return numberTest;
}

void FillArray(int [,] matr) // Заполнение массива рандомными данными
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr [i,j] = new Random().Next(1,100);
        }
    }
}

int [,] array = new int [4,4];

FillArray(array);
PrintArray(array);

Console.WriteLine("введите позицию на какой строке");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите позицию в каком столбце");
int columnsVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число для проверки");
int numberTest = Convert.ToInt32(Console.ReadLine());

if (array[linesVol,columnsVol] == numberTest)
{
    Console.WriteLine ($"Такое число - {numberTest} в массиве есть ");
}
else
{
    Console.WriteLine ($"Такое число отсутствует {numberTest}");
}