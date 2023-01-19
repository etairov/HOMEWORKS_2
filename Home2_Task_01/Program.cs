//Задача 10: Напишите программу, которая принимает на себя трехзначное входное число и на выходе показывает цифру этого второго числа.

//456 -> 5 782 -> 8 918 -> 1
//-----------------------------

int EnterYourNumber()
{
    Console.WriteLine("Введите любое 3-значное число");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int PrintSecondNumber(int number)
{
      if (number <100 || number > 999)
      {
        Console.WriteLine("Число вне диапазона");
      }
      else
      {
        int result = ((number / 10) % 10);
        Console.WriteLine($"Введенное число {number}, Вторая цифра {result}.");
      }
      return number;
}
int number = EnterYourNumber();
int result = PrintSecondNumber(number);

//-----------------------------------------------------
//Решение без методов

  /*Console.WriteLine("Введите любое 3-значное число");
    int number = Convert.ToInt32(Console.ReadLine());
    int result = 0;

      if (number <100 || number > 999)
      {
        Console.WriteLine("Число вне диапазона");
      }
      else
      {
        result = ((number / 10) % 10);
        Console.WriteLine($"Введенное число {number}, Вторая цифра {result}.");
      }  */