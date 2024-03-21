/*
Задайте массив, напишите программу, которая определяет, присутствует ли заданное число в массиве. (да/нет)
[1 3 4 19 3]. 8 - нет
[-4 3 4 1]. 3 - да
*/
int[] array = { 1, 3, 4, 19, 3 };
Console.Write("Введите число для поиска: ");
int x = Convert.ToInt32(Console.ReadLine());
int v = 0;

foreach (int e in array)
{
    if (e == x) { v = x; }
}
if (v == x)
{ Console.Write("Да"); }
else
{
    Console.Write("Нет");
}

// через for тоже можно