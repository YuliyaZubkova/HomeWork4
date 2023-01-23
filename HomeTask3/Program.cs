/* Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран. (Задача из какой то лекции  кажется из Examples2)

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] arr = {1, 2, 5, 7, 19, 6, 1, 33};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

PrintArray(arr);
Console.Write(" -> [");
PrintArray(arr);
Console.Write("]");