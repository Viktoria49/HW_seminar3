// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Digit1 = num / 10000;
int Digit5 = num % 10;
int Digit2 = (num / 1000) % 10;
int Digit4 = (num % 100) / 10; 
if (num > 9999 && num <= 99999 || (num < -9999 && num >= -99999))
{
    if(Digit1 == Digit5 && Digit2 == Digit4)
    {
        Console.WriteLine($"Число {num} -> является Палиндромом");
    }
     else
    {
        Console.WriteLine($"Число {num} -> НЕ является Палиндромом");
    }
}
else
{
    Console.WriteLine("Число не пятизначное");
} 
