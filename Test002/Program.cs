// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());

if (anyNumber > 0 && anyNumber < 100)
{
    Console.WriteLine("-> третьей цифры нет");
}
if (anyNumber > 99 && anyNumber < 1000)
{
    anyNumber = anyNumber  % 10;
    Console.WriteLine("третья цифра -> " + anyNumber);
}
if (anyNumber > 999 && anyNumber < 10000)
{
    anyNumber = anyNumber  / 10 % 10;
    Console.WriteLine("третья цифра -> " + anyNumber);
}

