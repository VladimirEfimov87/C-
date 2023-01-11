// // Напешите программу, которая на вход принимает число и выдаёт его квадрат(num * num)
// Например:
// 4-> 16
// -3 -> 9
// // -7 ->49

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 10)
// {
// Console.Write(num*num);
// }
// else
// {
// Console.Write(num % 2);
// }


// Console.Write("Введите число 1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 == num2 * num2)
// {
//   Console.Write("Да");
// }
// else
// {
//   Console.Write("Нет");
// }




// Напишите программу, которая будет выдавать название дня недели по заданному домеру
// 3-> Среда
// 5-> Пятница

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num == 1)
// {
//   Console.Write("Понедельник");
// }
// if(num == 2)
// {
//   Console.Write("Вторник");
// }
// if(num == 3)
// {
//   Console.Write("Среда");
// }
// if(num == 4)
// {
//   Console.Write("Четверг");
// }
// if(num == 5)
// {
//   Console.Write("Пятница");
// }
// if(num == 6)
// {
//   Console.Write("Суббота");
// }
// if(num == 7)
// {
//   Console.Write("Воскресенье");
// }





// Console.Write("Введите число 1: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int max = num;

// if (num1>num) max = num1;
// {
// Console.WriteLine($"max{max}");
// }






// Console.WriteLine("Введите число 1 :");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 3: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = num1;

// if (num2 > max) max = num2;
// if (num3 > max) max = num3;
// Console.WriteLine($"max {max}");




// Чётное не чётное

// Console.WriteLine("Введите число 1 :");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0)
// {
// Console.WriteLine("Да");
// }
// else 
// {
//   Console.WriteLine("Нет");
// }







// // Запишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите число 1");
int num = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= num)
{
  if (i % 2 == 0)
  {
    Console.WriteLine($" {i} ");
  }
  i++;
} 