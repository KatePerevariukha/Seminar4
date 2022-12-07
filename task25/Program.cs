// Задача 25: (branch task_1)
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// */

Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень:");
int m = Convert.ToInt32(Console.ReadLine());
int i = 1;   
int res = n;

while(i < m)
{
    res = (n * res);
    i++;
 }
Console.Write($"Результат: {res}");