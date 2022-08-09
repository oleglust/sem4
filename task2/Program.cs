// программа получает число и указывает количество цифр в нем

int Lenght(int num)
{
   int counter = 0;
   while (num > 0)
{
   num = num / 10;
   counter++;
}

return counter;

}
Console.WriteLine("Введите число:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine(Lenght(x));
