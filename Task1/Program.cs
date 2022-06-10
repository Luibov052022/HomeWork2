// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int prompt(string message)
{
Console.Write(message);
string number = Console.ReadLine();
int numberInt = int.Parse(number);
return numberInt;
}

int numberInt = prompt("введите трехзначное число: ");
int Count = (int)Math.Log10(numberInt) + 1;
if (!(Count == 3))
{
    Console.WriteLine("Число не трехзначное!");
   Environment.Exit(0);
}

int [] array = new int[3];
int index = array.Length - 1;

while (numberInt > 0)
{
    array[index] = numberInt % 10;
    numberInt = numberInt / 10;
    index--;
}

Console.WriteLine($"Вторая цифра этого числа - {array[1]}");
