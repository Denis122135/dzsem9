// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


// int PrintNum (int num)
// {
//     if (num == 0)
//         return 0;
//     Console.Write($"{num + " "}");
//     return num - PrintNum(num - 1);
// }

// Console.Clear();
// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Числа в промежутке от {num} до 0 : ");
// PrintNum(num);





// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.(рекурсия)


// int FindSum (int min, int max)
// {
//     int buff = max;
//     if (min == max)
//         return min;
//     else
//         return buff + FindSum(min, max - 1);
// }



// Console.Clear();
// Console.WriteLine("Введите число M");
// int min = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число N");
// int max = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма чисел от M до N равна: {FindSum(min, max)} ");








// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n(Рекурсия).




// int FunctionAccerman (int m, int n)
// {
//     if (m == 0)
//         return n + 1;
//     else if (n == 0)
//         return FunctionAccerman(m - 1, 1);
//     return FunctionAccerman(m - 1, FunctionAccerman(m, n -1));
// }


// Console.Clear();
// Console.WriteLine("Введите число M");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число N");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Итог: {FunctionAccerman(m, n)}");