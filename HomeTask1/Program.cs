// Напишите цикл, который принимает на вход 
//два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16



int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

int GetDegree(int numberOne, int numberTwo)
{
    int result = 1;

    for (int i = 0; i < numberTwo; i++)
    {
        result = result * numberOne;
    }

    return result;

}

int numberOne = GetNumber("Введите первое число: ");
int numberTwo = GetNumber("Введите второе число: ");

Console.WriteLine($"Число {numberOne} в степени {numberTwo} равно {GetDegree(numberOne, numberTwo)}.");






