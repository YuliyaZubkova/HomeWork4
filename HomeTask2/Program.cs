// Напишите программу, которая принимает на вход число и выдаёт 
//сумму цифр в числе. (можно написать по аналогии с задачей на факториал из лекции - Example)

// 452 -> 11

// 82 -> 10

// 9012 -> 12


Console.WriteLine("Введите число: ");
string number1 = Console.ReadLine();
int number = Convert.ToInt32(number1);
int count = number.ToString().Length;

Console.Write(MakeArray(number, count));
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int MakeArray(int a, int b)
{
int result = 0;

    for (int i = 0; i < b; i++)
    {
        result = result + a%10;
        a = a/10;
    }

Console.Write($"{number} -> ");
return result;

}

