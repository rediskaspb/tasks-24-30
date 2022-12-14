// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Не использовать Math.Pow() и аналоги!

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int AdegreeB(int A, int B)
{
    int degree = 1;
    for(int i = 1; i <= B; i++)
    {
        degree = degree * A;
        // Console.WriteLine(degree);
    }
    return degree;
}

int A = ReadInt("Введите число A: ");
int B = ReadInt("Введите степень B: ");
int result = AdegreeB(A, B);
Console.WriteLine($"{A} в степени {B} -> {result}");

