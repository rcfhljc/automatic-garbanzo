// //Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// for (int i = n; i >= 1; i--)
// {
//     Console.Write(i + " ");
// }


//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int summa(int m, int n)
// {
//     if (m == n)
//         return n;
//     else return m + summa(m + 1, n);
// }
// Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {summa(m, n)}");


//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Console.WriteLine("Введите два неотрицательных числа:");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Ackermann({m}, {n}) = {Ackermann(m, n)}");
// static int Ackermann(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0)
//     {
//         return Ackermann(m - 1, 1);
//     }
//     else
//     {
//         return Ackermann(m - 1, Ackermann(m, n - 1));
//     }
// }

