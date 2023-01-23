// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int result = 1;

for (int i = 0; i < numberTwo; i++)
{
    result = result*numberOne;
}
Console.WriteLine($"{numberOne}, {numberTwo} -> {result}");

