// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Write("Введите пятизначное число N: ");
// string? number = Console.ReadLine();
// if ((number[0] == number[4]) && (number[1] == number[3])) Console.WriteLine("Да, является палиндромом");
// else
// {
//     Console.WriteLine("Нет, не является палиндромом");
// }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Введите координату точки А по оси x1: ");
// int numberX1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки А по оси y1: ");
// int numberY1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки А по оси z1: ");
// int numberZ1 = Convert.ToInt32(Console.ReadLine());


// Console.Write("Введите координату точки В по оси x2: ");
// int numberX2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки В по оси y2: ");
// int numberY2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату точки В по оси z2: ");
// int numberZ2 = Convert.ToInt32(Console.ReadLine());

// //  len = sqrt((x2 - x1)^2 + (y2 - y1)^2 + (z2 - z1)^2)
// double len = Math.Sqrt((numberX2 - numberX1)*(numberX2 - numberX1)+(numberY2-numberY1)*(numberY2-numberY1)+(numberZ2-numberZ1)*(numberZ2-numberZ1));
// Console.WriteLine("Расстояние между точками " + len);

// Задача 23
// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Write("Введите число N: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int cube = 1;

// while (cube <= number)
// {
//     int result = (cube * cube * cube);
//     Console.WriteLine(" " + result);
//     cube++;
// }