/*
Напишите программу, которая на вход принимает два числа
и проверяет является ли одно квадратом другого
5, 25 да
-4, 16 да
25, 5 да
8, 9 нет
*/
Console.WriteLine("введите два числа ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 * num1 == num2 | num2 * num2 == num1)
{
    System.Console.WriteLine("Да");
}
else { System.Console.WriteLine("Нет"); }