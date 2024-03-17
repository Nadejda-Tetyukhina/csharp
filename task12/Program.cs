/*
Напишите программу, которая на вход будет принимать два числа
и выводить, является ли второе число кратным первому,
если второе число не кратно первому, то программа выводит остаток от деления
34, 5 -> некратно, остаток 4
16, 4 -> кратно
*/
Console.WriteLine("введите два числа ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
    Console.WriteLine("кратно");
}
else {Console.WriteLine("некратно " + num1 % num2);};
