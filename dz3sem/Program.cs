﻿/*
Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,90].

Начальные условия:

int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
Выводится: 5
*/


/* int[] array = { 1, 5, 10, 20, 30, 40, 99, 4, 90, 3 };
int k = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[i] <= 90)
    {
        k++;
    }
    
}
Console.Write(k); */ 
//--------------------
/*
using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Подсчет количества элементов массива, попадающих в заданный диапазон
    // numbers - массив, в котором ведется подсчет
    // minRange - минимальная граница диапазона
    // maxRange - максимальная граница диапазона
  
    public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
         //Введите сюда свое решение
   
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
     if (numbers[i] >= minRange && numbers[i] <= maxRange)
    {
        count++;
    }
    
}
return count;
    }
    
    public static void PrintResult(int[] array)
    {
  
        Console.WriteLine(CountItemsRange(array, 10, 90));
          //Введите сюда свое решение
    }

}


//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(int.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}

*/
//----------------------------------------------------------------------------------

/*
Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

Начальные условия:

int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
Выводится: 6
*/
/*
int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4};
int k = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        k++;
    }
    
}
Console.Write(k); */
/*
using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Подсчет количества четных элементов массива
    // numbers - массив, в котором ведется подсчет
    public static int CountEvenItems(int[] numbers)
    {
       int k = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        k++;
    }
    
}
      return k;
      //Напишите свое решение здесь
    }
    
    public static void PrintResult(int[] array)
    {
        Console.WriteLine(CountEvenItems(array));
      //Напишите свое решение здесь
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(int.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new int[] {2, 5, 2, 3, 6, 3, 7, 8, 2, 4}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}
*/
//----------------------------------------------------------------------------------------------------------------------


/*
Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

Начальные условия:

int[] array = {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
Выводится: 5.15
*/

using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Разница между максимальным и минимальным элементами массива
    
    // Нахождение минимума массива
    public static double FindMin(double[] numbers)
    {
   
double min = 1000000;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
    
        
}
 return min;
      //Напишите свое решение здесь
    }
    
    // Нахождение максимума массива
    public static double FindMax(double[] numbers)
    {
      
    double max = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] >= max)
    {
        max = numbers[i];
    }
    
        
}
   return max;
        
      //Напишите свое решение здесь
    }
    
    
    
    public static void PrintResult(double[] array)
    {
        Console.WriteLine(FindMax(array) - FindMin(array));//Напишите свое решение здесь
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        double[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(double.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new double[] {0.25, 5.4, 1.3, 2.1, 3.8, 5.2, 3.01}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}