﻿/*
Дано натуральное трехзначное число. Создайте массив, состоящий из цифр этого числа. Младший разряд числа должен располагаться на 0-м индексе массива, старший на 2-м.
Пример
456 --- [6 5 4]
781 --- [1 8 7]
*/
int num = new Random().Next (100, 1000);
Console.WriteLine(num);
int[] arr = new int[3];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = num % 10;
    Console.Write($"{arr[i]} ");
    num = num / 10;
}


