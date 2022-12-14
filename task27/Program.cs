// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int GetCountOfNumber(int number)
{
    int count = number.ToString().Length;
    // Console.WriteLine(count);
    return count;
}

int GetSumNumber(int number, int count)
{
    int sum = 0;
    for(int i = 1; i <= count; i++)
    {
        sum += number % 10;
        number /= 10;
        // Console.WriteLine(sum);
    }
    return sum;
}

int number = ReadInt("Введите число: ");
int count = GetCountOfNumber(number);
int result = GetSumNumber(number, count);
Console.WriteLine($"Сумма цифр в числе = {result}");
