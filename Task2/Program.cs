// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

Random rnd = new Random();
int number = rnd.Next(100, 1000);
Console.WriteLine($"Случайное число - {number}");
int [] array = new int[3];
int index = array.Length - 1;

while (number > 0)
{
    array[index] = number % 10;
    number = number / 10;
    index--;
}
Console.WriteLine($"Случайное число без второго знака - {array[0]}{array[2]}");
