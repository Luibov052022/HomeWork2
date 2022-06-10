// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int prompt(string message)
{
Console.Write(message);
string number = Console.ReadLine();
int numberInt = int.Parse(number);
return numberInt;
}

int numberInt = prompt("введите число: ");
int Count = (int)Math.Log10(numberInt) + 1;
if (Count < 3 )
{
    Console.WriteLine("третьей цифры нет");
   Environment.Exit(0);
}

int [] array = new int[Count];
int index = array.Length - 1;

while (numberInt > 0)
{
    array[index] = numberInt % 10;
    numberInt = numberInt / 10;
    index--;
}

Console.WriteLine($"Третья цифра этого числа - {array[2]}");
