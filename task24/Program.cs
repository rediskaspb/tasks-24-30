// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

//Метод считывает число от пользователя
int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}
// метод возвращает сумму от 1 до А
int GetSum1toNumber(int number)
{
    int sum = 0;
    for(int i = 1; i <= number; i++)
    {
        //sum = sum + i;
        sum += i;
    }
    return sum;
}

int A = ReadInt("Введите число: ");
int result = GetSum1toNumber(A);
Console.WriteLine($"Сумма чисел от 1 до {A} = {result}");
