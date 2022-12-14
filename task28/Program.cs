// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}
int GetProd1toN(int N)
{
    int prod = 1;
    for(int i = 1; i <= N; i++)
    {
        prod *= i;
        // Console.WriteLine(prod);
    }
    return prod;
}

int N = ReadInt("Введите число: ");
int result = GetProd1toN(N);
Console.WriteLine($"Произведение чисел от 1 до {N} = {result}");

