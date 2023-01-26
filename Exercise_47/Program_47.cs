// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArray(double [,] matr) // Заполнение массива рандомными данными
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr [i,j] = new Random().NextDouble();
        }
      }
  }
  void PrintArray(double[,] matr) // Создание матрицы 
{
    for (int i = 0; i  < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]:f2} ");
        }
    Console.WriteLine();
    }
  }
  Console.WriteLine("Введите число (количество строк): ");
    int val1 = Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Введите число (количество столбцов): ");
    int val2 = Convert.ToInt32(Console.ReadLine());
  double[,] array = new double [val1, val2];
  FillArray(array);
  PrintArray(array);
  