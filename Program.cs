// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N.
// Пример
// M=1; N=5 => "1, 2, 3, 4, 5"

// void task_1 (int start, int end)
// {
//     if(start == end)
//     {
//         Console.Write(start);
//         return;
//     }
//     Console.Write(start + " ");
//     task_1(start + 1, end);
// }
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// task_1(M, N);

//---------------------------------------------------------------------------------------------------------

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 
// Пример
// m = 2, n = 3 -> A(m,n) = 29

// int task_2 (int n, int m)
// {
//     if (n == 0)
//         return m + 1;
//     else if (m == 0)
//         return task_2 (n - 1, 1);
//     else
//         return task_2 (n - 1, task_2(n, m - 1));
// }
// Console.Write("Введите 1 число: ");
// int namberOne = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите 2 число: ");
// int namberTwo = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Ответ: {task_2(namberOne, namberTwo)}");

//---------------------------------------------------------------------------------------------------------

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// Пример
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

void task_3 (int[] arr, int i)
{
    if (i < 0)
    {
        return;
    }
    Console.Write(arr [i] + " ");
    task_3(arr, i-1);
}

int[] array = {25, 40, 83, 124, 0, 36};
int j = array.Length-1;
task_3(array, j);
