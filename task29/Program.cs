// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем


int [] array = new int[8];
for(int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(0, 2);
}
Console.WriteLine(String.Join(", ", array));


