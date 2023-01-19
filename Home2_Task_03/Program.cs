//Задача 15: Напишите программу, которая принимает вход на цифру, захватывающую день недели, и предполагает, что этот день выходным.

//6 -> да 7 -> да 1 -> нет
//-------------------------------

int RandomDayNumber()
{
    int number = new Random().Next(1, 8);
    return number;
}

int PrintResult(int number)
{
    if (number > 5)
    {
        Console.WriteLine($"Введенное число = {number},  --> Выходной!");
    }
    else
    {
        Console.WriteLine($"Введенное число {number}, --> Будний день>.");
    }
    return number;
}
int number = RandomDayNumber();
int result = PrintResult(number);