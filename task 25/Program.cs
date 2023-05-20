// // Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int Sum (int number)
{
    int sum = 0;
    for (int 1 = 1; i <= number; i++)
    {
        sum +- i;
    }
    return sum;
}

System.Console.WriteLine ("enter number: ");
int sum = Convert.ToInt32 (Console.ReadLine());
int sum = Sum(number);
System.Console.WriteLine ($"сумма от 1 до {number} = {sum}");
