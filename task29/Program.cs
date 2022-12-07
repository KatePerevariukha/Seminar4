// Задача 29: Напишите программу, которая задаёт массив из 8 элементов, предоставить возможность пользователю ввести числа и вывести их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
int n = 8;
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    Console.Write("Ведите один из восьми элементов массива:");
    int x = Convert.ToInt32(Console.ReadLine());
    array[i] = x;
}
 Console.WriteLine($"[{string.Join(", ", array)}]");