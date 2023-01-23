// Программа которая принимает число и выдает количество цифр в числе

/* Простой ввод числа с консоли
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.Readline());
*/

//Ввод числа с консоли с проверкой 
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
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

int number = GetNumber("Введите число");


int count = 0;

while (number > 0)
{
    number = number / 10;
    count++;
}

Console.WriteLine($"Количество цифр в числе: {count}");