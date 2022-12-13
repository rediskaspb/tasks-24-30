// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int GetCountOfNumber(int number)
{
    int count = number.ToString().Length;
    Console.WriteLine(count);
    return count;
}


int number = ReadInt("Введите число: ");
int result = GetCountOfNumber(number);
Console.WriteLine($"Количество цифр в числе -> {result}");