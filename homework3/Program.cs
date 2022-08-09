// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] getNewArray(int lenghtarr)
{
    int[] array = new int[lenghtarr];

    for (int i = 0; i < array.Length; i++)
    {
         array[i] = new Random().Next(0, 999);
    }
    return array;
}
  Console.Write("[");
foreach ( int item in getNewArray(8))
{
    
    Console.Write(item + ",");
   
}
 Console.Write("]");