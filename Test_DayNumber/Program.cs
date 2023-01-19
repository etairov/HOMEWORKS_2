//Задача 15: Напишите программу, которая принимает вход на цифру, захватывающую день недели, и предполагает, что этот день выходным.

//6 -> да 7 -> да 1 -> нет
//-------------------------------

/*void FillArray(int[] collection)//Метод, заполняющий массив
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 10);
        index++;
    }
} */

void FillArray(string[] WeekArray)
{
    string[] WeekArray = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    int length = WeekArray.Length;
    int number = new Random().Next(1, 8);
    int index = 0;
    for (int i = 0; i < length; i++)
    {
               WeekArray[index] = number;
    }
}
//int RandomDayNumber()
//{
//    int number = new Random().Next(1, 8);
//    return number;
//}

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
Console.WriteLine(WeekArray[index]);

