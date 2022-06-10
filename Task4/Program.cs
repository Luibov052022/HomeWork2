// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}

int numberInt = prompt("введите число от 1 до 7 включительно: ");
if (numberInt < 1 || numberInt > 7)
{
    Console.WriteLine("Введите корректное число");
    Environment.Exit(0);
}
if (numberInt == 7 || numberInt == 6)
{
    Console.WriteLine("День выходной - ДА");
}
else
{
    Console.WriteLine("День выходной - НЕТ");
}

