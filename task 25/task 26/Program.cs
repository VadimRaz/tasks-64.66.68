// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// решение 1: 
// int Counting (int number)
// {
//     int count = 0;
//     while(number > 0)
//     {
//         number/=10;
//         count++;
//     }
//     if (count == 0)
//     {
//         count++;
//     }
//     return count;
// }

// System.Console.WriteLine ("введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = Counting(num);
// System.Console.WriteLine ($"кол-во цифр в числе {num} = {count}");


// вариант решения 2:

System.Console.WriteLine ("введите число: ");
string num = Console.ReadLine();
if (int.TryParse(num, out int number))
{
    System.Console.WriteLine(num.Length);
}
else 
{
    System.Console.WriteLine ("введите число: "); // System.Console.WriteLine ("ошибка: введите число ");
}
