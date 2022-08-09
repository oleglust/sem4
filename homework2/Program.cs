// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("Введите число : ");
int number = int.Parse(Console.ReadLine());

  int SumNumber(int number)
  {
    int counter = Convert.ToString(number).Length;
    int lastNUM = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
      lastNUM = number - number % 10;
      result = result + (number - lastNUM);
      number = number / 10;
    }
   return result;
  }

int sumNumber = SumNumber(number);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);


