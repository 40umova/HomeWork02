//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//НЕЛЬЗЯ ИСПОЛЬЗОВАТЬ СТРОКИ.
//456 -> 5
//782 -> 8
//918 -> 1

Console.WriteLine("Введи трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());


if (number >  99 && number < 1000);
{
    number = number / 10 % 10;
}
    

    Console.WriteLine(number);



