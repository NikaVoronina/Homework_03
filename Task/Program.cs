Console.Clear();

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

   
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99999 || num < 10000)
{
    Console.Write("Введено не пятизначное число!"); 
    return;
}
if (num / 10000 != num % 10)
{
    Console.Write($"{num} -> не палиндром");
}
else if ((num / 1000) % 10 != (num % 100) / 10)
{
    Console.Write($"{num} -> не палиндром");
}
else
{
    Console.Write($"{num} -> палиндром");
}