// РЕШЕНИЕ ДОМАШНЕЙ ЗАДАЧИ
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// Пример - b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

/* const int X_COORD = 0;
const int Y_COORD = 1;
const int K_DATA = 0;
const int B_DATA = 1;

int[] GetCrossPoint(int[] dataLine1, int[] dataLine2)
{
    int[] point = new int[2];
    point[X_COORD] = (dataLine1[B_DATA] - dataLine2[B_DATA]) / (dataLine2[K_DATA] - dataLine1[K_DATA]);
    point[Y_COORD] = (dataLine2[K_DATA]  * dataLine1[B_DATA] - dataLine1[K_DATA] * dataLine2[B_DATA]) / (dataLine2[K_DATA] - dataLine1[K_DATA]);
    return point;
}

bool Validate(int k1, int k2)
{
    if (k1 == k2)
    {
        Console.Write("Заданные прямые не пересекаются");
        return false;
    }
    return true;
}
int[] InputDataLine(int number)
{
    int[] dataLine = new int[2];
    Console.WriteLine($"Введите b{number}: ");
    dataLine[B_DATA] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Введите k{number}: ");
    dataLine[K_DATA] = Convert.ToInt32(Console.ReadLine());
    return dataLine;
}

int[] lineData1 = InputDataLine(1);
int[] lineData2 = InputDataLine(2);

if (Validate(lineData1[K_DATA], lineData2[K_DATA]))
{
    int[] crossPoint = GetCrossPoint(lineData1, lineData2);
    Console.Write($"Точка пересечения прямых: ({crossPoint[X_COORD]}; {crossPoint[Y_COORD]})");
}
 */

// ЗАДАЧА № 1 Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1     4    8   19
// 5   -2  33   -2
// 77  3    8     1


// int[,] GenerateArray(int rows, int columns, int minRnd, int maxRnd)
// {
//     int[,] array = new int[rows, columns];
//     Random rnd = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(minRnd, maxRnd + 1);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i,j]}\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] myArray = GenerateArray(3, 4, 0, 10);
// PrintArray(myArray);

//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int[,] GenerateArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int[,] myarray = GenerateArray(3, 4);
// PrintArray(myarray);

// Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, и замените эти элементы на их квадраты.
// int[,] GenerateArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int [,] CopyArray (int[,] array)
// {
//     int[,] dupArray = new int[array.GetLength(0), array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             dupArray[i,j] = array[i,j];
//         }
//     }
//     return dupArray;
// }

// int [,] ChangeArray (int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i % 2 == 0 && j % 2 == 0){
//                 array[i,j] *= array[i,j];
//             }
//         }
//     }
//     return array;
// }

// int[,] myarray = GenerateArray(3, 4);
// PrintArray(myarray);
// int[,] newArray = CopyArray(myarray);
// PrintArray(newArray);
// int[,] changeArray = ChangeArray(newArray);
// PrintArray(changeArray);
// PrintArray(myarray);


//Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1   4   7
// 5   9   2
// 8   4   2
// Сумма элементов главной диагонали: 1+9+2 = 12

// int[,] GenerateArray(int rows)
// {
//     int[,] array = new int[rows, rows];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int SumDigitsDiagonal(int[,] array)
// {
//     int sum = array[0, 0];
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         sum += array[i, i];
//     }
//     return sum;
// }

// int[,] NewArray = GenerateArray(3);
// PrintArray(NewArray);
// int result = SumDigitsDiagonal(NewArray);
// System.Console.WriteLine(result);

// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, выведите позиции по горизонтали и вертикали, или напишите, 
// что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.


// int[,] GenerateArray(int rows)
// {
//     int[,] array = new int[rows, rows];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write($"{matrix[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
//     System.Console.WriteLine();
// }

// int Prompt(string message)
// {
//     System.Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// (int, int) FindDigitOnArray(int[,] array, int num)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == num)
//             {
//                 return (i + 1, j + 1);
//             }
//         }
//     }
//     return (0, 0);
// }

// int[,] NewArray = GenerateArray(3);
// PrintArray(NewArray);
// int number = Prompt("Введите число, которое нужно найти в массиве: ");
// (int row, int colum) = FindDigitOnArray(NewArray, number);
// if (row == 0)
// {
//     System.Console.WriteLine("Числа нет в массиве");
// }
// else
// {
//     System.Console.WriteLine($"{row} {colum}");
// }