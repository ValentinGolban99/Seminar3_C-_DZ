﻿//  Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да


Console.Write("Введите число: ");
string numb = Console.ReadLine();
if (numb.Length == 5)
{
   if(numb[0] == numb[4] || numb[1] == numb[3])
   {
    Console.WriteLine("Введенное число является палиндромом.");
   }
   else
   {
    Console.WriteLine("Введенное число не является полиндромом.");
   }
}
else
{
    Console.WriteLine("Введенное число не пятизначное. ");
}





