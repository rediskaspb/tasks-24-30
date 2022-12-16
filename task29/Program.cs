// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int numbers = ReadInt("Введите 8 чисел: ");

int [] array = new int[8];
for(int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("--------------");

for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ", ");
}


