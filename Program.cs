/*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.WriteLine("Введите пятизначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int firstDigit = N / 10000;
int secDigit = N / 1000;
int secondDigit = secDigit % 10;
int fDigit = N % 100;
int fourthDigit = fDigit / 10;
int fifthDigit = N % 10;

if(firstDigit == fifthDigit)
{
    if(secondDigit == fourthDigit)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Нет");
}

