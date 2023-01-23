// Программа, котоая выводит массив из 8 элементов заполненых 0 и 1 в случайном порядке

int[] array = new int [8];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
    Console.Write($"{array[i]}, ");
}
