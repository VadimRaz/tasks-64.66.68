// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Введите число: ");
string number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"число: {number} - палиндром.");
  }
  else Console.WriteLine($"число: {number} - не палиндром.");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Введите пятизначное число");


// вариант 2
// System.Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string str = number.ToString(); // Convert.ToString(number);
// bool isPalindrom = true;
// for (int i = 0; i < str.Length / 2; i++)
// {
//     if (str[i] != str[str.Length - i - 1])
//     {
//         isPalindrom = false;
//         break;
//     }
// }
// if (isPalindrom)
// {
//     System.Console.WriteLine("Palindrom");
// }
// else
// {
//     System.Console.WriteLine("No palindrom");
// }

