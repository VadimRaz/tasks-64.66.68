// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Console.WriteLine("введите 3 числа: ");
// int i = Convert.ToInt32(Console.ReadLine());
// int j = Convert.ToInt32(Console.ReadLine());
// int k = Convert.ToInt32(Console.ReadLine());

// if (i+j>k & j+k>i & i+k>j);
// Console.WriteLine("Треугольник существует")
// else 
// Console.WriteLine("Треугольник не существует");


System.Console.WriteLine("Введите сторону A: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите сторону B: ");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите сторону C: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a+c && c< a + b)
    System.Console.WriteLine("Треуголник существует");
else
    System.Console.WriteLine("Треуголник не существует");