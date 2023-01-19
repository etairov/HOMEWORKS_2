//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что других цифр нет.

//645 -> 5
//78 -> другие цифры нет
//32679 -> 6
//-----------------------------

int EnterYourNumber()
{
    int number = new Random().Next(0, 200);
    return number;
}

int PrintThirdNumber(int number)
{
      if (number <100)
      {
        Console.WriteLine("Введенное число = " + number + " --> Других цифр нет");
      }
      else
      {
        int result = ((number % 100) % 10);
        Console.WriteLine($"Введенное число {number}, Третья цифра {result}.");
      }
      return number;
}
int number = EnterYourNumber();
int result = PrintThirdNumber(number);
