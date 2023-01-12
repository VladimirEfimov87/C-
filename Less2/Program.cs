// int num = 2;         //если дробные числа пишем double

// Console.WriteLine(Math.Abs(num));    Возвращает абсолютное значение(модуль числа)Модуль числа - есть его абсолютная величина. Простыми словами модуль - расстояние от числа до нуля на числовой оси. 
//                                       Значение модуля - всегда неотрицательное число.

// Console.WriteLine(Math.Min(num, num1));  Min или Max значение из чисел (значение или переменная)

// Console.WriteLine(Math.Pow(num, 5));      Возведение в степень(цифра означает в какую степень возводим)

//Console.WriteLine(Math.Round(12.12365, 2));    // Округление значения(цифра после запятой до скольки округляем)


// Console.WriteLine(Math.Sqrt(49));

//Циклы


// for (int i = 1; i < 7; i++)
// {
//   Console.WriteLine(i);
//   if (i == 3) co;              //break - прерывание цикла
// }
// Console.WriteLine("Выполнено");

// // while (num < 7)
// // {
// //   Console.WriteLine(num);
// //   num += 2;
// // }
// // Console.WriteLine("Выполнено");

//Задачи
// №1
// // Вывести случайное трехзначное число и удалить вторую цифру этого числа
// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int x1 = num % 10;
// // int x2 = (num / 10) % 10;
// int x3 = num / 100;
// Console.WriteLine($"{x3}{x1}");

// №2
//  Напишите программу, которая принимает 2 числа
//  Console.Write("Введите число 1: ");
//  int num1 = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите число 2: ");
//  int num2 = Convert.ToInt32(Console.ReadLine());
//  if (num1 % num2 == 0)
//  {
//    Console.WriteLine("кратно");
//  }
//  else
//  {
//    Console.WriteLine($"{num1 % num2}");
//  }
// №3

//  Console.Write("Введите число 1: ");
//  int num1 = Convert.ToInt32(Console.ReadLine());
//  if (num1 % 7 == 0 && num1 % 23 == 0 )
// {
//   Console.WriteLine("кратно");
// }
// else
// {
//   Console.WriteLine("не кратно");
// }


// Домашнее задание
// Задача 10: Вход трёхзначное число и на выходе показывает вторую цифру этого чисела

//  Console.Write("Введите трехзначное число: ");
//  int num = Convert.ToInt32(Console.ReadLine());

// int x = (num / 10) % 10;

//  Console.WriteLine($"{x}");









// Задача 15: принимает на вход цифру, обозначающую день неделии проверяет, является ли
//             этот день выходным.


//  Console.Write("Введите цифру дня недели: ");
//  int num1 = Convert.ToInt32(Console.ReadLine());
//   if (num1 <= 5 )
//  {
//    Console.WriteLine("Будни");
//  }
//  else
//  {
//    Console.WriteLine("Выходной");
//  }
