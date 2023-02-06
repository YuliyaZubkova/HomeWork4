/* Напишите программу, которая принимает на вход число и выдаёт 
сумму цифр в числе. 
 452 -> 11
 82 -> 10
 9012 -> 12 */

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

int MakeArray(int a, int b)
{
    int result = 0;

    for (int i = 0; i < b; i++)
    {
        result = result + a % 10;
        a = a / 10;
    }
    return result;
}

int number = GetNumber("Введите число: ");
int count = number.ToString().Length;
Console.Write($"Сумма цифр в числе {number} равна {MakeArray(number, count)} ");
