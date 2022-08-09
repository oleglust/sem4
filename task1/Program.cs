//программа принимает число и выдает сумму чисел от 1 до этого числа
int getSumNums(int number)
{
   int sum = 0;
   while(number > 0)
   {
     sum += number;
    number -= 1;
   }
   return sum;
}



Console.WriteLine("Введите число:");
int x = int.Parse(Console.ReadLine());

int answer = getSumNums(x);
Console.WriteLine(answer);