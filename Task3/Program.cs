// Программа которая принимает число N и выдает произведение от 1 до N

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

int num = GetNumber("Введите число");
int result = 1;

for (int i = 1; i <= num; i++)
{
    result = result * i;
}
Console.WriteLine($"Произведение от 1 до {num} = {result}");